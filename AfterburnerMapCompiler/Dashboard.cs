using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using System.Security;

namespace AfterburnerMapCompiler
{
	public partial class Dashboard : Form
	{
		private const string m_DefaultStatusBarText = "Hover over items to view information on their use.";

		private string m_StatusBarText = "";
		private string m_LastToolExePath = "";
		private string m_LastGameExePath = "";
		private ApplicationConfig m_AppConfig = null;
		private KnownPaths m_KnownPaths = null;
		private System.Timers.Timer m_ConfigSaveTimer = null;
		private bool m_IgnoreConfigUpdates = false;
		private CompilePreset m_LastPreset = null;

		private CompilePreset m_FastPreset;
		private CompilePreset m_DefaultPreset;
		private CompilePreset m_FinalPreset;

		public Dashboard()
		{
			InitializeComponent();

			m_AppConfig = new ApplicationConfig();
			m_KnownPaths = new KnownPaths();

			CreateFastCompilePreset();
			CreateDefaultCompilePreset();
			CreateFinalCompilePreset();

			SetStatusBarText(m_DefaultStatusBarText);
			TryLoadConfig();
			ComputePaths();
		}

		private void SetStatusBarText(string message, bool updateLabel = true)
		{
			m_StatusBarText = SanitiseMessageForStatusBar(message);

			if ( updateLabel )
			{
				RefreshStatusBarText();
			}
		}

		private void RefreshStatusBarText()
		{
			statusBarLabel.Text = m_StatusBarText;
		}

		private void OverrideStatusBarText(string message)
		{
			statusBarLabel.Text = SanitiseMessageForStatusBar(message);
		}

		private void GenericShowTooltipInStatusBar(object sender, EventArgs e)
		{
			string tooltipString = toolTip.GetToolTip((Control)sender);

			if ( tooltipString.Length > 0 )
			{
				OverrideStatusBarText(tooltipString);
			}
		}

		private void GenericRecomputeGameRelatedPathsOnEnter(object sender, KeyPressEventArgs e)
		{
			if ( e.KeyChar == '\r' )
			{
				ComputeGameRelatedPaths();
			}
		}

		private void GenericRecomputeMapSourceRelatedPathsOnEnter(object sender, KeyPressEventArgs e)
		{
			if ( e.KeyChar == '\r' )
			{
				ComputeMapSourceRelatedPaths();
				ApplyCompilePreset();
			}
		}

		private void GenericResetStatusBarMessage(object sender, EventArgs e)
		{
			RefreshStatusBarText();
		}

		private void SaveCompileLog(object sender, EventArgs e)
		{
			saveFileDialog.AddExtension = false;
			saveFileDialog.DefaultExt = "txt";
			saveFileDialog.Filter = "Text files (*.txt)|*.txt";
			saveFileDialog.InitialDirectory = m_KnownPaths.MapSourceDirectoryPath;

			if ( saveFileDialog.ShowDialog() != DialogResult.OK )
			{
				return;
			}

			System.IO.File.WriteAllText(saveFileDialog.FileName, tbCompileOutput.Text);
		}

		private void ChooseCsgExePath(object sender, EventArgs e)
		{
			ChooseExePath(csgPathInput, ref m_LastToolExePath);
		}

		private void ChooseBspExePath(object sender, EventArgs e)
		{
			ChooseExePath(bspPathInput, ref m_LastToolExePath);
		}

		private void ChooseVisExePath(object sender, EventArgs e)
		{
			ChooseExePath(visPathInput, ref m_LastToolExePath);
		}

		private void ChooseRadExePath(object sender, EventArgs e)
		{
			ChooseExePath(radPathInput, ref m_LastToolExePath);
		}

		private void ChooseGameExePath(object sender, EventArgs e)
		{
			ChooseExePath(gamePathInput, ref m_LastGameExePath);

			// Update paths immediately.
			ComputeGameRelatedPaths();
		}

		private void ChooseMapToCompile(object sender, EventArgs e)
		{
			if ( openMapToCompileDialog.ShowDialog() != DialogResult.OK )
			{
				return;
			}

			mapFileToCompile.Text = openMapToCompileDialog.FileName;
			mapFileToCompile.SelectionStart = mapFileToCompile.Text.Length;
			UpdateCompileButtonEnabledState();
		}

		private void MapSourceFileChanged(object sender, EventArgs e)
		{
			ComputeMapSourceRelatedPaths();
			ApplyCompilePreset();
		}

		private void ApplyFastPreset(object sender, EventArgs e)
		{
			ApplyCompilePreset(m_FastPreset);
		}

		private void ApplyDefaultPreset(object sender, EventArgs e)
		{
			ApplyCompilePreset(m_DefaultPreset);
		}

		private void ApplyFinalPreset(object sender, EventArgs e)
		{
			ApplyCompilePreset(m_FinalPreset);
		}

		private void CsgExePathChanged(object sender, EventArgs e)
		{
			if ( m_IgnoreConfigUpdates )
			{
				return;
			}

			m_AppConfig.CsgExePath = ((TextBox)sender).Text;
			UpdateCompileButtonEnabledState();
			QueueConfigSave();
		}

		private void BspExePathChanged(object sender, EventArgs e)
		{
			if ( m_IgnoreConfigUpdates )
			{
				return;
			}

			m_AppConfig.BspExePath = ((TextBox)sender).Text;
			UpdateCompileButtonEnabledState();
			QueueConfigSave();
		}

		private void VisExePathChanged(object sender, EventArgs e)
		{
			if ( m_IgnoreConfigUpdates )
			{
				return;
			}

			m_AppConfig.VisExePath = ((TextBox)sender).Text;
			UpdateCompileButtonEnabledState();
			QueueConfigSave();
		}

		private void RadExePathChanged(object sender, EventArgs e)
		{
			if ( m_IgnoreConfigUpdates )
			{
				return;
			}

			m_AppConfig.RadExePath = ((TextBox)sender).Text;
			UpdateCompileButtonEnabledState();
			QueueConfigSave();
		}

		private void GameDirPathChanged(object sender, EventArgs e)
		{
			if ( m_IgnoreConfigUpdates )
			{
				return;
			}

			m_AppConfig.GameDirPath = ((TextBox)sender).Text;
			UpdateCompileButtonEnabledState();
			QueueConfigSave(true);
		}

		private void ChooseExePath(TextBox control, ref string lastPath)
		{
			string initialDir;

			if ( control.Text.Length > 0 )
			{
				initialDir = System.IO.Path.GetDirectoryName(control.Text);
			}
			else if ( lastPath.Length > 0 )
			{
				initialDir = System.IO.Path.GetDirectoryName(lastPath);
			}
			else
			{
				initialDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			}

			openFileDialog.InitialDirectory = initialDir;
			openFileDialog.Filter = "Executable files (*.exe)|*.exe";

			if ( openFileDialog.ShowDialog() != DialogResult.OK )
			{
				return;
			}

			lastPath = openFileDialog.FileName;
			control.Text = openFileDialog.FileName;
			control.SelectionStart = control.Text.Length;
		}

		private void QueueConfigSave(bool recomputeGameRelatedPaths = false)
		{
			if ( m_ConfigSaveTimer != null )
			{
				m_ConfigSaveTimer.Stop();
			}

			m_ConfigSaveTimer = new System.Timers.Timer(2000);
			m_ConfigSaveTimer.AutoReset = false;
			m_ConfigSaveTimer.Enabled = true;

			Dashboard formObj = this;

			m_ConfigSaveTimer.Elapsed += (Object source, ElapsedEventArgs args) =>
			{
				Task.Run(() => m_AppConfig.Serialise(ConfigFilePath()));

				if ( recomputeGameRelatedPaths )
				{
					// Make sure this is invoked from the correct thread, as it modifies controls.
					formObj.Invoke((MethodInvoker)delegate
					{
						ComputePaths();
						m_ConfigSaveTimer = null;
					});
				}
			};
		}

		// Returns true if all paths are valid, false otherwise.
		private bool ComputePaths()
		{
			bool success = true;

			if ( !ComputeGameRelatedPaths() )
			{
				success = false;
			}

			if ( !ComputeMapSourceRelatedPaths() )
			{
				success = false;
			}

			return success;
		}

		private bool ComputeGameRelatedPaths()
		{
			string gameExePath = gamePathInput.Text;

			if ( !System.IO.File.Exists(gameExePath) )
			{
				SetComputedPathContent(ref m_KnownPaths.GameDirectoryPath, "", labelGameDirectoryPath);
				SetComputedPathContent(ref m_KnownPaths.GameMapsDirectoryPath, "", labelMapsDirectoryPath);
				SetComputedPathContent(ref m_KnownPaths.GameTexturesDirectoryPath, "", labelTexturesDirectoryPath);

				return false;
			}

			string gameDirPath = System.IO.Path.GetDirectoryName(gameExePath);
			string mapDirPath = System.IO.Path.Combine(gameDirPath, "afterburner", "maps");
			string texDirPath = System.IO.Path.Combine(gameDirPath, "afterburner", "textures");

			bool success = true;

			if ( !SetAndValidateComputedPath(ref m_KnownPaths.GameDirectoryPath, gameDirPath, labelGameDirectoryPath) )
			{
				success = false;
			}

			if ( !SetAndValidateComputedPath(ref m_KnownPaths.GameMapsDirectoryPath, mapDirPath, labelMapsDirectoryPath) )
			{
				success = false;
			}

			if ( !SetAndValidateComputedPath(ref m_KnownPaths.GameTexturesDirectoryPath, texDirPath, labelTexturesDirectoryPath) )
			{
				success = false;
			}

			return success;
		}

		private bool ComputeMapSourceRelatedPaths()
		{
			string mapSourceFilePath = mapFileToCompile.Text;

			if ( !System.IO.File.Exists(mapSourceFilePath) )
			{
				SetComputedPathContent(ref m_KnownPaths.MapCompileDirectoryPath, "", labelCompileDirectoryPath);
				SetComputedPathContent(ref m_KnownPaths.MapSourceDirectoryPath, "");
				SetComputedPathContent(ref m_KnownPaths.MapOutputFilePath, "");
				SetComputedPathContent(ref m_KnownPaths.MapSourceFilePath, "");
				SetComputedPathContent(ref m_KnownPaths.MapIntermediateFilePath, "");

				return false;
			}

			string mapSourceDirPath = System.IO.Path.GetDirectoryName(mapSourceFilePath);
			string mapSourceName = System.IO.Path.GetFileNameWithoutExtension(mapSourceFilePath);
			string mapIntermediatePath = System.IO.Path.Combine(mapSourceDirPath, $"{mapSourceName}.bsp");
			string mapOutputPath = System.IO.Path.Combine(m_KnownPaths.GameMapsDirectoryPath, $"{mapSourceName}.bsp");

			bool success = true;

			if ( !SetAndValidateComputedPath(ref m_KnownPaths.MapCompileDirectoryPath, mapSourceDirPath, labelCompileDirectoryPath) )
			{
				success = false;
			}

			if ( !SetAndValidateComputedPath(ref m_KnownPaths.MapSourceDirectoryPath, mapSourceDirPath) )
			{
				success = false;
			}

			if ( !SetAndValidateComputedPath(ref m_KnownPaths.MapSourceFilePath, mapSourceFilePath) )
			{
				success = false;
			}

			if ( !SetAndValidateComputedPath(ref m_KnownPaths.MapOutputFilePath, mapOutputPath) )
			{
				success = false;
			}

			if ( !SetAndValidateComputedPath(ref m_KnownPaths.MapIntermediateFilePath, mapIntermediatePath) )
			{
				success = false;
			}

			return success;
		}

		private bool SetAndValidateComputedPath(ref string dataItem, string dirPath, Label label = null)
		{
			string absolutePath = dirPath;

			try
			{
				absolutePath = System.IO.Path.GetFullPath(absolutePath);
			}
			catch ( Exception ex )
			{
				SetComputedPathError(ref dataItem, label, absolutePath, GetPathResolutionErrorString(absolutePath, ex.GetType()));
				return false;
			}

			if ( !System.IO.Directory.Exists(absolutePath) )
			{
				SetComputedPathError(ref dataItem, label, absolutePath, $"Path {absolutePath} does not exist.");
				return false;
			}

			SetComputedPathContent(ref dataItem, absolutePath, label);
			return true;
		}

		private void SetComputedPathError(ref string dataItem, Label label, string content, string errorString)
		{
			dataItem = content;

			if ( label != null )
			{
				label.Text = dataItem;
				label.ForeColor = Color.IndianRed;
				label.Cursor = Cursors.Help;
				toolTip.SetToolTip(label, errorString);
			}
		}

		private void SetComputedPathContent(ref string dataItem, string content, Label label = null)
		{
			dataItem = content;

			if ( label != null )
			{
				label.Text = dataItem;
				label.ForeColor = DefaultForeColor;
				label.Cursor = Cursors.Default;
				toolTip.SetToolTip(label, "");
			}
		}

		private string GetPathResolutionErrorString(string path, Type exceptionType)
		{
			if ( exceptionType == typeof(SecurityException) )
			{
				return $"Access to directory {path} was forbidden by the system.";
			}

			if ( exceptionType == typeof(NotSupportedException) )
			{
				return $"Path {path} contains invalid characters.";
			}

			if ( exceptionType == typeof(System.IO.PathTooLongException) )
			{
				return $"Path {path} exceeded maximum allowed length.";
			}

			// Fallback case:
			return "Unable to calculate path.";
		}

		private void TryLoadConfig()
		{
			m_IgnoreConfigUpdates = true;

			m_AppConfig.Deserialise(ConfigFilePath());

			csgPathInput.Text = m_AppConfig.CsgExePath;
			csgPathInput.SelectionStart = csgPathInput.Text.Length;

			bspPathInput.Text = m_AppConfig.BspExePath;
			bspPathInput.SelectionStart = bspPathInput.Text.Length;

			visPathInput.Text = m_AppConfig.VisExePath;
			visPathInput.SelectionStart = visPathInput.Text.Length;

			radPathInput.Text = m_AppConfig.RadExePath;
			radPathInput.SelectionStart = radPathInput.Text.Length;

			gamePathInput.Text = m_AppConfig.GameDirPath;
			gamePathInput.SelectionStart = gamePathInput.Text.Length;

			m_IgnoreConfigUpdates = false;
		}

		private void UpdateCompileButtonEnabledState()
		{
			btnCompile.Enabled = ValidateConfig();
		}

		private bool ValidateConfig()
		{
			return ValidateConfigExePath(m_AppConfig.CsgExePath) &&
				   ValidateConfigExePath(m_AppConfig.BspExePath) &&
				   ValidateConfigExePath(m_AppConfig.VisExePath) &&
				   ValidateConfigExePath(m_AppConfig.RadExePath) &&
				   ValidateConfigExePath(m_AppConfig.GameDirPath);
		}

		private bool ValidateConfigExePath(string path)
		{
			return !string.IsNullOrWhiteSpace(path) && System.IO.File.Exists(path);
		}

		private string SanitiseMessageForStatusBar(string message)
		{
			// Don't allow newlines in the status text. Some tooltips may contain these, so replace them with spaces.
			return message.Replace("\r\n", " ").Replace('\n', ' ');
		}

		private string ConfigFilePath()
		{
			string programPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
			string programDir = System.IO.Path.GetDirectoryName(programPath);
			return System.IO.Path.Combine(programDir, "config.json");
		}

		private void ApplyCompilePreset(CompilePreset preset = null)
		{
			if ( preset == null )
			{
				preset = m_LastPreset;
			}

			if ( m_KnownPaths.MapSourceFilePath.Length < 1 )
			{
				preset = null;
			}

			if ( preset == null )
			{
				csgCmdLine.Text = "";
				bspCmdLine.Text = "";
				visCmdLine.Text = "";
				radCmdLine.Text = "";

				m_LastPreset = null;
				btnCompile.Enabled = false;
				return;
			}

			csgCmdLine.Text = CompilePreset.GetCommandString(preset.CSGArgs, m_KnownPaths);
			bspCmdLine.Text = CompilePreset.GetCommandString(preset.BSPArgs, m_KnownPaths);
			visCmdLine.Text = CompilePreset.GetCommandString(preset.VISArgs, m_KnownPaths);
			radCmdLine.Text = CompilePreset.GetCommandString(preset.RADArgs, m_KnownPaths);

			m_LastPreset = preset;
			UpdateCompileButtonEnabledState();
		}

		private void CreateFastCompilePreset()
		{
			m_FastPreset = new CompilePreset();

			m_FastPreset.CSGArgs.Add(new StringCompileToolArgument("-texturedir"));
			m_FastPreset.CSGArgs.Add(new KnownPathCompileToolArgument(KnownPath.GameTexturesDirectory));
			m_FastPreset.CSGArgs.Add(new KnownPathCompileToolArgument(KnownPath.MapSourceFile));

			m_FastPreset.BSPArgs.Add(new KnownPathCompileToolArgument(KnownPath.MapIntermediateFile));

			m_FastPreset.VISArgs.Add(new StringCompileToolArgument("-fast"));
			m_FastPreset.VISArgs.Add(new KnownPathCompileToolArgument(KnownPath.MapIntermediateFile));

			m_FastPreset.RADArgs.Add(new StringCompileToolArgument("-fast"));
			m_FastPreset.RADArgs.Add(new StringCompileToolArgument("-texturedir"));
			m_FastPreset.RADArgs.Add(new KnownPathCompileToolArgument(KnownPath.GameTexturesDirectory));
			m_FastPreset.RADArgs.Add(new KnownPathCompileToolArgument(KnownPath.MapIntermediateFile));
		}

		private void CreateDefaultCompilePreset()
		{
			m_DefaultPreset = new CompilePreset();

			m_DefaultPreset.CSGArgs.Add(new StringCompileToolArgument("-texturedir"));
			m_DefaultPreset.CSGArgs.Add(new KnownPathCompileToolArgument(KnownPath.GameTexturesDirectory));
			m_DefaultPreset.CSGArgs.Add(new KnownPathCompileToolArgument(KnownPath.MapSourceFile));

			m_DefaultPreset.BSPArgs.Add(new KnownPathCompileToolArgument(KnownPath.MapIntermediateFile));

			m_DefaultPreset.VISArgs.Add(new KnownPathCompileToolArgument(KnownPath.MapIntermediateFile));

			m_DefaultPreset.RADArgs.Add(new StringCompileToolArgument("-texturedir"));
			m_DefaultPreset.RADArgs.Add(new KnownPathCompileToolArgument(KnownPath.GameTexturesDirectory));
			m_DefaultPreset.RADArgs.Add(new KnownPathCompileToolArgument(KnownPath.MapIntermediateFile));
		}

		private void CreateFinalCompilePreset()
		{
			m_FinalPreset = new CompilePreset();

			m_FinalPreset.CSGArgs.Add(new StringCompileToolArgument("-texturedir"));
			m_FinalPreset.CSGArgs.Add(new KnownPathCompileToolArgument(KnownPath.GameTexturesDirectory));
			m_FinalPreset.CSGArgs.Add(new KnownPathCompileToolArgument(KnownPath.MapSourceFile));

			m_FinalPreset.BSPArgs.Add(new KnownPathCompileToolArgument(KnownPath.MapIntermediateFile));

			m_FinalPreset.VISArgs.Add(new StringCompileToolArgument("-full"));
			m_FinalPreset.VISArgs.Add(new KnownPathCompileToolArgument(KnownPath.MapIntermediateFile));

			m_FinalPreset.RADArgs.Add(new StringCompileToolArgument("-extra"));
			m_FinalPreset.RADArgs.Add(new StringCompileToolArgument("-bounce"));
			m_FinalPreset.RADArgs.Add(new StringCompileToolArgument("16"));
			m_FinalPreset.RADArgs.Add(new StringCompileToolArgument("-texturedir"));
			m_FinalPreset.RADArgs.Add(new KnownPathCompileToolArgument(KnownPath.GameTexturesDirectory));
			m_FinalPreset.RADArgs.Add(new KnownPathCompileToolArgument(KnownPath.MapIntermediateFile));
		}

		private void CompileMap(object sender, EventArgs e)
		{
			ApplyCompilePreset();

			// Don't do anything if we haven't applied a preset.
			if ( m_LastPreset == null )
			{
				return;
			}

			SetUILocked(true);

			MapCompileProcess compileProcess = new MapCompileProcess();

			compileProcess.CSGArgs = csgCmdLine.Text;
			compileProcess.BSPArgs = bspCmdLine.Text;
			compileProcess.VISArgs = visCmdLine.Text;
			compileProcess.RADArgs = radCmdLine.Text;
			compileProcess.AppConfig = m_AppConfig;
			compileProcess.Paths = m_KnownPaths;
			compileProcess.LogOutput = tbCompileOutput;

			compileProcess.UnlockUI = () =>
			{
				Invoke((MethodInvoker)delegate
				{
					SetUILocked(false);
				});
			};

			compileProcess.Run();
		}

		private void SetUILocked(bool locked)
		{
			btnCompile.Enabled = !locked;
			btnFastPreset.Enabled = !locked;
			btnDefaultPreset.Enabled = !locked;
			btnFinalPreset.Enabled = !locked;
			btnChooseCsgPath.Enabled = !locked;
			btnChooseBspPath.Enabled = !locked;
			btnChooseVisPath.Enabled = !locked;
			btnChooseRadPath.Enabled = !locked;
			btnChooseGameDir.Enabled = !locked;
			btnChooseMapFile.Enabled = !locked;

			csgPathInput.Enabled = !locked;
			bspPathInput.Enabled = !locked;
			visPathInput.Enabled = !locked;
			radPathInput.Enabled = !locked;
			gamePathInput.Enabled = !locked;
			mapFileToCompile.Enabled = !locked;

			csgCmdLine.Enabled = !locked;
			bspCmdLine.Enabled = !locked;
			visCmdLine.Enabled = !locked;
			radCmdLine.Enabled = !locked;
		}
	}
}
