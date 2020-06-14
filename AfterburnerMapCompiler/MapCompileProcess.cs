using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace AfterburnerMapCompiler
{
	class MapCompileProcess
	{
		public delegate void UnlockUIDelegate();

		public string CSGArgs { get; set; }
		public string BSPArgs { get; set; }
		public string VISArgs { get; set; }
		public string RADArgs { get; set; }
		public ApplicationConfig AppConfig { get; set; }
		public KnownPaths Paths { get; set; }
		public TextBox LogOutput { get; set; }
		public UnlockUIDelegate UnlockUI { get; set; }

		private SemaphoreSlim m_Semaphore;

		public MapCompileProcess()
		{
			m_Semaphore = new SemaphoreSlim(1);
		}

		public void Run()
		{
			Task.Run(async () =>
			{
				try
				{
					await RunCSG();
					await RunBSP();
					await RunVIS();
					await RunRAD();
				}
				catch ( Exception )
				{
					AppendLogLine("*** Compile process terminated early. Please review the logs for errors.");
				}

				UnlockUI();
			});
		}

		private async Task<int> RunCSG()
		{
			int returnCode = await ExecuteProcess(AppConfig.CsgExePath, CSGArgs);

			if ( returnCode != 0 )
			{
				throw new Exception($"CSG process returned error code {returnCode}.");
			}

			return returnCode;
		}

		private async Task<int> RunBSP()
		{
			int returnCode = await ExecuteProcess(AppConfig.BspExePath, BSPArgs);

			if ( returnCode != 0 )
			{
				throw new Exception($"BSP process returned error code {returnCode}.");
			}

			return returnCode;
		}

		private async Task<int> RunVIS()
		{
			int returnCode = await ExecuteProcess(AppConfig.VisExePath, VISArgs);

			if ( returnCode != 0 )
			{
				throw new Exception($"VIS process returned error code {returnCode}.");
			}

			return returnCode;
		}

		private async Task<int> RunRAD()
		{
			int returnCode = await ExecuteProcess(AppConfig.RadExePath, RADArgs);

			if ( returnCode != 0 )
			{
				throw new Exception($"RAD process returned error code {returnCode}.");
			}

			return returnCode;
		}

		private async Task<int> ExecuteProcess(string path, string args)
		{
			int returnCode = 1;

			using ( Process process = new Process() )
			{
				await m_Semaphore.WaitAsync();

				try
				{
					process.StartInfo.FileName = path;
					process.StartInfo.Arguments = args;
					process.StartInfo.UseShellExecute = false;
					process.StartInfo.WorkingDirectory = Paths.MapCompileDirectoryPath;
					process.StartInfo.RedirectStandardOutput = true;
					process.StartInfo.CreateNoWindow = true;

					process.OutputDataReceived += ProcessStdOutHandler;

					AppendLogLine($"*** Running process: {path} {args}\r\n");

					process.Start();
					process.BeginOutputReadLine();
					await WaitForExitAsync(process);

					returnCode = process.ExitCode;
					AppendLogLine($"\r\n*** Process {path} returned exit code {returnCode}.");
				}
				catch ( Exception ex )
				{
					Console.WriteLine(ex.ToString());
				}
				finally
				{
					m_Semaphore.Release();
				}
			}

			return returnCode;
		}

		private void ProcessStdOutHandler(object sendingProcess, DataReceivedEventArgs outLine)
		{
			if ( !string.IsNullOrEmpty(outLine.Data) )
			{
				AppendLogLine(outLine.Data);
			}
		}

		private void ClearLog()
		{
			LogOutput.Invoke((MethodInvoker)delegate
			{
				LogOutput.Text = "";
			});
		}

		private void AppendLogLine(string message)
		{
			LogOutput.Invoke((MethodInvoker)delegate
			{
				LogOutput.AppendText(message + "\r\n");
			});
		}

		public Task WaitForExitAsync(Process process)
		{
			var tcs = new TaskCompletionSource<object>();
			process.EnableRaisingEvents = true;
			process.Exited += (sender, args) => tcs.TrySetResult(null);

			return tcs.Task;
		}
	}
}
