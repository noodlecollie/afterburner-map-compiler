namespace AfterburnerMapCompiler
{
	partial class Dashboard
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.labelCsg = new System.Windows.Forms.Label();
			this.labelBsp = new System.Windows.Forms.Label();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.csgPathInput = new System.Windows.Forms.TextBox();
			this.bspPathInput = new System.Windows.Forms.TextBox();
			this.visPathInput = new System.Windows.Forms.TextBox();
			this.radPathInput = new System.Windows.Forms.TextBox();
			this.labelVis = new System.Windows.Forms.Label();
			this.labelRad = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnChooseRadPath = new System.Windows.Forms.Button();
			this.btnChooseVisPath = new System.Windows.Forms.Button();
			this.btnChooseBspPath = new System.Windows.Forms.Button();
			this.btnChooseCsgPath = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnChooseGameDir = new System.Windows.Forms.Button();
			this.gamePathInput = new System.Windows.Forms.TextBox();
			this.labelGameExeDir = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.labelPreset = new System.Windows.Forms.Label();
			this.btnFastPreset = new System.Windows.Forms.Button();
			this.btnDefaultPreset = new System.Windows.Forms.Button();
			this.btnFinalPreset = new System.Windows.Forms.Button();
			this.labelCsgCmdLine = new System.Windows.Forms.Label();
			this.labelBspCmdLine = new System.Windows.Forms.Label();
			this.labelVisCmdLine = new System.Windows.Forms.Label();
			this.labelRadCmdLine = new System.Windows.Forms.Label();
			this.btnCompile = new System.Windows.Forms.Button();
			this.labelMapFile = new System.Windows.Forms.Label();
			this.labelGameDir = new System.Windows.Forms.Label();
			this.labelMapsDir = new System.Windows.Forms.Label();
			this.labelCompileDir = new System.Windows.Forms.Label();
			this.labelTexDir = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnChooseMapFile = new System.Windows.Forms.Button();
			this.mapFileToCompile = new System.Windows.Forms.TextBox();
			this.radCmdLine = new System.Windows.Forms.TextBox();
			this.visCmdLine = new System.Windows.Forms.TextBox();
			this.bspCmdLine = new System.Windows.Forms.TextBox();
			this.csgCmdLine = new System.Windows.Forms.TextBox();
			this.tbCompileOutput = new System.Windows.Forms.TextBox();
			this.btnSaveLog = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.labelTexturesDirectoryPath = new System.Windows.Forms.Label();
			this.labelCompileDirectoryPath = new System.Windows.Forms.Label();
			this.labelMapsDirectoryPath = new System.Windows.Forms.Label();
			this.labelGameDirectoryPath = new System.Windows.Forms.Label();
			this.openMapToCompileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.statusBar.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelCsg
			// 
			this.labelCsg.AutoSize = true;
			this.labelCsg.Cursor = System.Windows.Forms.Cursors.Help;
			this.labelCsg.Location = new System.Drawing.Point(18, 25);
			this.labelCsg.Name = "labelCsg";
			this.labelCsg.Size = new System.Drawing.Size(87, 13);
			this.labelCsg.TabIndex = 0;
			this.labelCsg.Text = "CSG executable:";
			this.toolTip.SetToolTip(this.labelCsg, "Path to the CSG executable (abcsg.exe).");
			this.labelCsg.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelCsg.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// labelBsp
			// 
			this.labelBsp.AutoSize = true;
			this.labelBsp.Cursor = System.Windows.Forms.Cursors.Help;
			this.labelBsp.Location = new System.Drawing.Point(18, 51);
			this.labelBsp.Name = "labelBsp";
			this.labelBsp.Size = new System.Drawing.Size(86, 13);
			this.labelBsp.TabIndex = 1;
			this.labelBsp.Text = "BSP executable:";
			this.toolTip.SetToolTip(this.labelBsp, "Path to the BSP executable (abbsp.exe).");
			this.labelBsp.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelBsp.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// csgPathInput
			// 
			this.csgPathInput.Location = new System.Drawing.Point(111, 22);
			this.csgPathInput.Name = "csgPathInput";
			this.csgPathInput.Size = new System.Drawing.Size(268, 20);
			this.csgPathInput.TabIndex = 2;
			this.csgPathInput.TextChanged += new System.EventHandler(this.CsgExePathChanged);
			// 
			// bspPathInput
			// 
			this.bspPathInput.Location = new System.Drawing.Point(111, 48);
			this.bspPathInput.Name = "bspPathInput";
			this.bspPathInput.Size = new System.Drawing.Size(268, 20);
			this.bspPathInput.TabIndex = 3;
			this.bspPathInput.TextChanged += new System.EventHandler(this.BspExePathChanged);
			// 
			// visPathInput
			// 
			this.visPathInput.Location = new System.Drawing.Point(111, 74);
			this.visPathInput.Name = "visPathInput";
			this.visPathInput.Size = new System.Drawing.Size(268, 20);
			this.visPathInput.TabIndex = 4;
			this.visPathInput.TextChanged += new System.EventHandler(this.VisExePathChanged);
			// 
			// radPathInput
			// 
			this.radPathInput.Location = new System.Drawing.Point(111, 100);
			this.radPathInput.Name = "radPathInput";
			this.radPathInput.Size = new System.Drawing.Size(268, 20);
			this.radPathInput.TabIndex = 5;
			this.radPathInput.TextChanged += new System.EventHandler(this.RadExePathChanged);
			// 
			// labelVis
			// 
			this.labelVis.AutoSize = true;
			this.labelVis.Cursor = System.Windows.Forms.Cursors.Help;
			this.labelVis.Location = new System.Drawing.Point(22, 77);
			this.labelVis.Name = "labelVis";
			this.labelVis.Size = new System.Drawing.Size(82, 13);
			this.labelVis.TabIndex = 6;
			this.labelVis.Text = "VIS executable:";
			this.toolTip.SetToolTip(this.labelVis, "Path to the VIS executable (abvis.exe).");
			this.labelVis.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelVis.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// labelRad
			// 
			this.labelRad.AutoSize = true;
			this.labelRad.Cursor = System.Windows.Forms.Cursors.Help;
			this.labelRad.Location = new System.Drawing.Point(16, 103);
			this.labelRad.Name = "labelRad";
			this.labelRad.Size = new System.Drawing.Size(88, 13);
			this.labelRad.TabIndex = 7;
			this.labelRad.Text = "RAD executable:";
			this.toolTip.SetToolTip(this.labelRad, "Path to the RAD executable (abrad.exe).");
			this.labelRad.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelRad.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnChooseRadPath);
			this.groupBox1.Controls.Add(this.btnChooseVisPath);
			this.groupBox1.Controls.Add(this.btnChooseBspPath);
			this.groupBox1.Controls.Add(this.btnChooseCsgPath);
			this.groupBox1.Controls.Add(this.labelCsg);
			this.groupBox1.Controls.Add(this.labelRad);
			this.groupBox1.Controls.Add(this.labelBsp);
			this.groupBox1.Controls.Add(this.labelVis);
			this.groupBox1.Controls.Add(this.csgPathInput);
			this.groupBox1.Controls.Add(this.radPathInput);
			this.groupBox1.Controls.Add(this.bspPathInput);
			this.groupBox1.Controls.Add(this.visPathInput);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(468, 131);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Compile Tools";
			// 
			// btnChooseRadPath
			// 
			this.btnChooseRadPath.Location = new System.Drawing.Point(385, 98);
			this.btnChooseRadPath.Name = "btnChooseRadPath";
			this.btnChooseRadPath.Size = new System.Drawing.Size(75, 23);
			this.btnChooseRadPath.TabIndex = 12;
			this.btnChooseRadPath.Text = "Choose...";
			this.btnChooseRadPath.UseVisualStyleBackColor = true;
			this.btnChooseRadPath.Click += new System.EventHandler(this.ChooseRadExePath);
			// 
			// btnChooseVisPath
			// 
			this.btnChooseVisPath.Location = new System.Drawing.Point(385, 72);
			this.btnChooseVisPath.Name = "btnChooseVisPath";
			this.btnChooseVisPath.Size = new System.Drawing.Size(75, 23);
			this.btnChooseVisPath.TabIndex = 11;
			this.btnChooseVisPath.Text = "Choose...";
			this.btnChooseVisPath.UseVisualStyleBackColor = true;
			this.btnChooseVisPath.Click += new System.EventHandler(this.ChooseVisExePath);
			// 
			// btnChooseBspPath
			// 
			this.btnChooseBspPath.Location = new System.Drawing.Point(385, 46);
			this.btnChooseBspPath.Name = "btnChooseBspPath";
			this.btnChooseBspPath.Size = new System.Drawing.Size(75, 23);
			this.btnChooseBspPath.TabIndex = 10;
			this.btnChooseBspPath.Text = "Choose...";
			this.btnChooseBspPath.UseVisualStyleBackColor = true;
			this.btnChooseBspPath.Click += new System.EventHandler(this.ChooseBspExePath);
			// 
			// btnChooseCsgPath
			// 
			this.btnChooseCsgPath.Location = new System.Drawing.Point(385, 20);
			this.btnChooseCsgPath.Name = "btnChooseCsgPath";
			this.btnChooseCsgPath.Size = new System.Drawing.Size(75, 23);
			this.btnChooseCsgPath.TabIndex = 9;
			this.btnChooseCsgPath.Text = "Choose...";
			this.btnChooseCsgPath.UseVisualStyleBackColor = true;
			this.btnChooseCsgPath.Click += new System.EventHandler(this.ChooseCsgExePath);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnChooseGameDir);
			this.groupBox2.Controls.Add(this.gamePathInput);
			this.groupBox2.Controls.Add(this.labelGameExeDir);
			this.groupBox2.Location = new System.Drawing.Point(12, 149);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(468, 54);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Game";
			// 
			// btnChooseGameDir
			// 
			this.btnChooseGameDir.Location = new System.Drawing.Point(385, 20);
			this.btnChooseGameDir.Name = "btnChooseGameDir";
			this.btnChooseGameDir.Size = new System.Drawing.Size(75, 23);
			this.btnChooseGameDir.TabIndex = 2;
			this.btnChooseGameDir.Text = "Choose...";
			this.btnChooseGameDir.UseVisualStyleBackColor = true;
			this.btnChooseGameDir.Click += new System.EventHandler(this.ChooseGameExePath);
			// 
			// gamePathInput
			// 
			this.gamePathInput.Location = new System.Drawing.Point(111, 22);
			this.gamePathInput.Name = "gamePathInput";
			this.gamePathInput.Size = new System.Drawing.Size(268, 20);
			this.gamePathInput.TabIndex = 1;
			this.gamePathInput.TextChanged += new System.EventHandler(this.GameDirPathChanged);
			this.gamePathInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GenericRecomputeGameRelatedPathsOnEnter);
			// 
			// labelGameExeDir
			// 
			this.labelGameExeDir.AutoSize = true;
			this.labelGameExeDir.Cursor = System.Windows.Forms.Cursors.Help;
			this.labelGameExeDir.Location = new System.Drawing.Point(12, 25);
			this.labelGameExeDir.Name = "labelGameExeDir";
			this.labelGameExeDir.Size = new System.Drawing.Size(93, 13);
			this.labelGameExeDir.TabIndex = 0;
			this.labelGameExeDir.Text = "Game executable:";
			this.toolTip.SetToolTip(this.labelGameExeDir, "Path to game executable (bond.exe).");
			this.labelGameExeDir.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelGameExeDir.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// labelPreset
			// 
			this.labelPreset.AutoSize = true;
			this.labelPreset.Cursor = System.Windows.Forms.Cursors.Help;
			this.labelPreset.Location = new System.Drawing.Point(65, 50);
			this.labelPreset.Name = "labelPreset";
			this.labelPreset.Size = new System.Drawing.Size(40, 13);
			this.labelPreset.TabIndex = 0;
			this.labelPreset.Text = "Preset:";
			this.toolTip.SetToolTip(this.labelPreset, "Select a preset to configure the map compile tools with recommended settings.\r\nOn" +
        "ce configured, these settings can be changed manually if desired.");
			this.labelPreset.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelPreset.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// btnFastPreset
			// 
			this.btnFastPreset.Location = new System.Drawing.Point(111, 45);
			this.btnFastPreset.Name = "btnFastPreset";
			this.btnFastPreset.Size = new System.Drawing.Size(75, 23);
			this.btnFastPreset.TabIndex = 1;
			this.btnFastPreset.Text = "Fast";
			this.toolTip.SetToolTip(this.btnFastPreset, "Compile quickly, with low-fidelity settings.\r\nLighting will be coarse and visibil" +
        "ity calculations will\r\nbe less accurate.\r\nNot recommended for final releases.");
			this.btnFastPreset.UseVisualStyleBackColor = true;
			this.btnFastPreset.Click += new System.EventHandler(this.ApplyFastPreset);
			this.btnFastPreset.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.btnFastPreset.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// btnDefaultPreset
			// 
			this.btnDefaultPreset.Location = new System.Drawing.Point(192, 45);
			this.btnDefaultPreset.Name = "btnDefaultPreset";
			this.btnDefaultPreset.Size = new System.Drawing.Size(75, 23);
			this.btnDefaultPreset.TabIndex = 2;
			this.btnDefaultPreset.Text = "Default";
			this.toolTip.SetToolTip(this.btnDefaultPreset, "Compile with general settings.\r\nLighting and visibility calculations will be suit" +
        "able\r\nfor general-purpose in-game testing.");
			this.btnDefaultPreset.UseVisualStyleBackColor = true;
			this.btnDefaultPreset.Click += new System.EventHandler(this.ApplyDefaultPreset);
			this.btnDefaultPreset.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.btnDefaultPreset.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// btnFinalPreset
			// 
			this.btnFinalPreset.Location = new System.Drawing.Point(273, 45);
			this.btnFinalPreset.Name = "btnFinalPreset";
			this.btnFinalPreset.Size = new System.Drawing.Size(75, 23);
			this.btnFinalPreset.TabIndex = 3;
			this.btnFinalPreset.Text = "Final";
			this.toolTip.SetToolTip(this.btnFinalPreset, "Compile with general settings, but with extra time\r\nspent improving visibility an" +
        "d lighting.\r\nThese settings are recommended for final releases.");
			this.btnFinalPreset.UseVisualStyleBackColor = true;
			this.btnFinalPreset.Click += new System.EventHandler(this.ApplyFinalPreset);
			this.btnFinalPreset.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.btnFinalPreset.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// labelCsgCmdLine
			// 
			this.labelCsgCmdLine.AutoSize = true;
			this.labelCsgCmdLine.Cursor = System.Windows.Forms.Cursors.Help;
			this.labelCsgCmdLine.Location = new System.Drawing.Point(74, 88);
			this.labelCsgCmdLine.Name = "labelCsgCmdLine";
			this.labelCsgCmdLine.Size = new System.Drawing.Size(32, 13);
			this.labelCsgCmdLine.TabIndex = 5;
			this.labelCsgCmdLine.Text = "CSG:";
			this.toolTip.SetToolTip(this.labelCsgCmdLine, "Command line arguments to pass to the CSG executable.");
			this.labelCsgCmdLine.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelCsgCmdLine.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// labelBspCmdLine
			// 
			this.labelBspCmdLine.AutoSize = true;
			this.labelBspCmdLine.Cursor = System.Windows.Forms.Cursors.Help;
			this.labelBspCmdLine.Location = new System.Drawing.Point(76, 114);
			this.labelBspCmdLine.Name = "labelBspCmdLine";
			this.labelBspCmdLine.Size = new System.Drawing.Size(31, 13);
			this.labelBspCmdLine.TabIndex = 9;
			this.labelBspCmdLine.Text = "BSP:";
			this.toolTip.SetToolTip(this.labelBspCmdLine, "Command line arguments to pass to the BSP executable.");
			this.labelBspCmdLine.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelBspCmdLine.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// labelVisCmdLine
			// 
			this.labelVisCmdLine.AutoSize = true;
			this.labelVisCmdLine.Cursor = System.Windows.Forms.Cursors.Help;
			this.labelVisCmdLine.Location = new System.Drawing.Point(80, 140);
			this.labelVisCmdLine.Name = "labelVisCmdLine";
			this.labelVisCmdLine.Size = new System.Drawing.Size(27, 13);
			this.labelVisCmdLine.TabIndex = 10;
			this.labelVisCmdLine.Text = "VIS:";
			this.toolTip.SetToolTip(this.labelVisCmdLine, "Command line arguments to pass to the VIS executable.");
			this.labelVisCmdLine.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelVisCmdLine.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// labelRadCmdLine
			// 
			this.labelRadCmdLine.AutoSize = true;
			this.labelRadCmdLine.Cursor = System.Windows.Forms.Cursors.Help;
			this.labelRadCmdLine.Location = new System.Drawing.Point(74, 166);
			this.labelRadCmdLine.Name = "labelRadCmdLine";
			this.labelRadCmdLine.Size = new System.Drawing.Size(33, 13);
			this.labelRadCmdLine.TabIndex = 11;
			this.labelRadCmdLine.Text = "RAD:";
			this.toolTip.SetToolTip(this.labelRadCmdLine, "Command line arguments to pass to the RAD executable.");
			this.labelRadCmdLine.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelRadCmdLine.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// btnCompile
			// 
			this.btnCompile.Enabled = false;
			this.btnCompile.Location = new System.Drawing.Point(111, 199);
			this.btnCompile.Name = "btnCompile";
			this.btnCompile.Size = new System.Drawing.Size(237, 23);
			this.btnCompile.TabIndex = 12;
			this.btnCompile.Text = "Compile";
			this.toolTip.SetToolTip(this.btnCompile, "Begin the map compile process.");
			this.btnCompile.UseVisualStyleBackColor = true;
			this.btnCompile.Click += new System.EventHandler(this.CompileMap);
			this.btnCompile.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.btnCompile.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// labelMapFile
			// 
			this.labelMapFile.AutoSize = true;
			this.labelMapFile.Cursor = System.Windows.Forms.Cursors.Help;
			this.labelMapFile.Location = new System.Drawing.Point(58, 22);
			this.labelMapFile.Name = "labelMapFile";
			this.labelMapFile.Size = new System.Drawing.Size(47, 13);
			this.labelMapFile.TabIndex = 14;
			this.labelMapFile.Text = "Map file:";
			this.toolTip.SetToolTip(this.labelMapFile, "Map source file to compile.");
			this.labelMapFile.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelMapFile.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// labelGameDir
			// 
			this.labelGameDir.AutoSize = true;
			this.labelGameDir.Cursor = System.Windows.Forms.Cursors.Help;
			this.labelGameDir.Location = new System.Drawing.Point(18, 25);
			this.labelGameDir.Name = "labelGameDir";
			this.labelGameDir.Size = new System.Drawing.Size(81, 13);
			this.labelGameDir.TabIndex = 0;
			this.labelGameDir.Text = "Game directory:";
			this.toolTip.SetToolTip(this.labelGameDir, "Main directory of the game (where bond.exe is located).");
			this.labelGameDir.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelGameDir.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// labelMapsDir
			// 
			this.labelMapsDir.AutoSize = true;
			this.labelMapsDir.Cursor = System.Windows.Forms.Cursors.Help;
			this.labelMapsDir.Location = new System.Drawing.Point(20, 51);
			this.labelMapsDir.Name = "labelMapsDir";
			this.labelMapsDir.Size = new System.Drawing.Size(79, 13);
			this.labelMapsDir.TabIndex = 1;
			this.labelMapsDir.Text = "Maps directory:";
			this.toolTip.SetToolTip(this.labelMapsDir, "Directory where compiled maps are stored.");
			this.labelMapsDir.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelMapsDir.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// labelCompileDir
			// 
			this.labelCompileDir.AutoSize = true;
			this.labelCompileDir.Cursor = System.Windows.Forms.Cursors.Help;
			this.labelCompileDir.Location = new System.Drawing.Point(9, 103);
			this.labelCompileDir.Name = "labelCompileDir";
			this.labelCompileDir.Size = new System.Drawing.Size(90, 13);
			this.labelCompileDir.TabIndex = 2;
			this.labelCompileDir.Text = "Compile directory:";
			this.toolTip.SetToolTip(this.labelCompileDir, "Directory where map compilation takes place.\r\nThis is where intermediate files an" +
        "d build logs will\r\nbe written.");
			this.labelCompileDir.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelCompileDir.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// labelTexDir
			// 
			this.labelTexDir.AutoSize = true;
			this.labelTexDir.Location = new System.Drawing.Point(5, 77);
			this.labelTexDir.Name = "labelTexDir";
			this.labelTexDir.Size = new System.Drawing.Size(94, 13);
			this.labelTexDir.TabIndex = 8;
			this.labelTexDir.Text = "Textures directory:";
			this.toolTip.SetToolTip(this.labelTexDir, "Directory containing game textures.");
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.btnChooseMapFile);
			this.groupBox3.Controls.Add(this.labelMapFile);
			this.groupBox3.Controls.Add(this.mapFileToCompile);
			this.groupBox3.Controls.Add(this.btnCompile);
			this.groupBox3.Controls.Add(this.labelRadCmdLine);
			this.groupBox3.Controls.Add(this.labelVisCmdLine);
			this.groupBox3.Controls.Add(this.labelBspCmdLine);
			this.groupBox3.Controls.Add(this.radCmdLine);
			this.groupBox3.Controls.Add(this.visCmdLine);
			this.groupBox3.Controls.Add(this.bspCmdLine);
			this.groupBox3.Controls.Add(this.labelCsgCmdLine);
			this.groupBox3.Controls.Add(this.csgCmdLine);
			this.groupBox3.Controls.Add(this.btnFinalPreset);
			this.groupBox3.Controls.Add(this.btnDefaultPreset);
			this.groupBox3.Controls.Add(this.btnFastPreset);
			this.groupBox3.Controls.Add(this.labelPreset);
			this.groupBox3.Location = new System.Drawing.Point(12, 209);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(939, 234);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Compile";
			// 
			// btnChooseMapFile
			// 
			this.btnChooseMapFile.Location = new System.Drawing.Point(385, 17);
			this.btnChooseMapFile.Name = "btnChooseMapFile";
			this.btnChooseMapFile.Size = new System.Drawing.Size(75, 23);
			this.btnChooseMapFile.TabIndex = 15;
			this.btnChooseMapFile.Text = "Choose...";
			this.btnChooseMapFile.UseVisualStyleBackColor = true;
			this.btnChooseMapFile.Click += new System.EventHandler(this.ChooseMapToCompile);
			// 
			// mapFileToCompile
			// 
			this.mapFileToCompile.Location = new System.Drawing.Point(111, 19);
			this.mapFileToCompile.Name = "mapFileToCompile";
			this.mapFileToCompile.Size = new System.Drawing.Size(268, 20);
			this.mapFileToCompile.TabIndex = 13;
			this.mapFileToCompile.TextChanged += new System.EventHandler(this.MapSourceFileChanged);
			this.mapFileToCompile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GenericRecomputeMapSourceRelatedPathsOnEnter);
			// 
			// radCmdLine
			// 
			this.radCmdLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radCmdLine.Location = new System.Drawing.Point(111, 165);
			this.radCmdLine.Name = "radCmdLine";
			this.radCmdLine.Size = new System.Drawing.Size(822, 20);
			this.radCmdLine.TabIndex = 8;
			// 
			// visCmdLine
			// 
			this.visCmdLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.visCmdLine.Location = new System.Drawing.Point(111, 139);
			this.visCmdLine.Name = "visCmdLine";
			this.visCmdLine.Size = new System.Drawing.Size(822, 20);
			this.visCmdLine.TabIndex = 7;
			// 
			// bspCmdLine
			// 
			this.bspCmdLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bspCmdLine.Location = new System.Drawing.Point(111, 113);
			this.bspCmdLine.Name = "bspCmdLine";
			this.bspCmdLine.Size = new System.Drawing.Size(822, 20);
			this.bspCmdLine.TabIndex = 6;
			// 
			// csgCmdLine
			// 
			this.csgCmdLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.csgCmdLine.Location = new System.Drawing.Point(111, 87);
			this.csgCmdLine.Name = "csgCmdLine";
			this.csgCmdLine.Size = new System.Drawing.Size(822, 20);
			this.csgCmdLine.TabIndex = 4;
			// 
			// tbCompileOutput
			// 
			this.tbCompileOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCompileOutput.BackColor = System.Drawing.Color.White;
			this.tbCompileOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCompileOutput.Location = new System.Drawing.Point(6, 19);
			this.tbCompileOutput.Multiline = true;
			this.tbCompileOutput.Name = "tbCompileOutput";
			this.tbCompileOutput.ReadOnly = true;
			this.tbCompileOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbCompileOutput.Size = new System.Drawing.Size(927, 127);
			this.tbCompileOutput.TabIndex = 13;
			// 
			// btnSaveLog
			// 
			this.btnSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSaveLog.Location = new System.Drawing.Point(6, 151);
			this.btnSaveLog.Name = "btnSaveLog";
			this.btnSaveLog.Size = new System.Drawing.Size(75, 23);
			this.btnSaveLog.TabIndex = 14;
			this.btnSaveLog.Text = "Save Log...";
			this.btnSaveLog.UseVisualStyleBackColor = true;
			this.btnSaveLog.Click += new System.EventHandler(this.SaveCompileLog);
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.tbCompileOutput);
			this.groupBox4.Controls.Add(this.btnSaveLog);
			this.groupBox4.Location = new System.Drawing.Point(12, 449);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(939, 180);
			this.groupBox4.TabIndex = 15;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Output";
			// 
			// statusBar
			// 
			this.statusBar.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
			this.statusBar.Location = new System.Drawing.Point(0, 639);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(962, 22);
			this.statusBar.TabIndex = 16;
			this.statusBar.Text = "statusStrip1";
			// 
			// statusBarLabel
			// 
			this.statusBarLabel.Name = "statusBarLabel";
			this.statusBarLabel.Size = new System.Drawing.Size(102, 17);
			this.statusBarLabel.Text = "[Default text here]";
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox5.Controls.Add(this.labelTexturesDirectoryPath);
			this.groupBox5.Controls.Add(this.labelTexDir);
			this.groupBox5.Controls.Add(this.labelCompileDirectoryPath);
			this.groupBox5.Controls.Add(this.labelMapsDirectoryPath);
			this.groupBox5.Controls.Add(this.labelGameDirectoryPath);
			this.groupBox5.Controls.Add(this.labelCompileDir);
			this.groupBox5.Controls.Add(this.labelMapsDir);
			this.groupBox5.Controls.Add(this.labelGameDir);
			this.groupBox5.Location = new System.Drawing.Point(492, 12);
			this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox5.Size = new System.Drawing.Size(459, 131);
			this.groupBox5.TabIndex = 17;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Computed Paths";
			// 
			// labelTexturesDirectoryPath
			// 
			this.labelTexturesDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTexturesDirectoryPath.AutoEllipsis = true;
			this.labelTexturesDirectoryPath.Location = new System.Drawing.Point(105, 77);
			this.labelTexturesDirectoryPath.Name = "labelTexturesDirectoryPath";
			this.labelTexturesDirectoryPath.Size = new System.Drawing.Size(348, 13);
			this.labelTexturesDirectoryPath.TabIndex = 9;
			this.labelTexturesDirectoryPath.Text = "[placeholder]";
			this.labelTexturesDirectoryPath.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelTexturesDirectoryPath.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// labelCompileDirectoryPath
			// 
			this.labelCompileDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelCompileDirectoryPath.AutoEllipsis = true;
			this.labelCompileDirectoryPath.Location = new System.Drawing.Point(105, 103);
			this.labelCompileDirectoryPath.Name = "labelCompileDirectoryPath";
			this.labelCompileDirectoryPath.Size = new System.Drawing.Size(348, 13);
			this.labelCompileDirectoryPath.TabIndex = 7;
			this.labelCompileDirectoryPath.Text = "[placeholder]";
			this.labelCompileDirectoryPath.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelCompileDirectoryPath.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// labelMapsDirectoryPath
			// 
			this.labelMapsDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelMapsDirectoryPath.AutoEllipsis = true;
			this.labelMapsDirectoryPath.Location = new System.Drawing.Point(105, 51);
			this.labelMapsDirectoryPath.Name = "labelMapsDirectoryPath";
			this.labelMapsDirectoryPath.Size = new System.Drawing.Size(348, 13);
			this.labelMapsDirectoryPath.TabIndex = 6;
			this.labelMapsDirectoryPath.Text = "[placeholder]";
			this.labelMapsDirectoryPath.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelMapsDirectoryPath.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// labelGameDirectoryPath
			// 
			this.labelGameDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelGameDirectoryPath.AutoEllipsis = true;
			this.labelGameDirectoryPath.Location = new System.Drawing.Point(105, 25);
			this.labelGameDirectoryPath.Name = "labelGameDirectoryPath";
			this.labelGameDirectoryPath.Size = new System.Drawing.Size(348, 13);
			this.labelGameDirectoryPath.TabIndex = 5;
			this.labelGameDirectoryPath.Text = "[placeholder]";
			this.labelGameDirectoryPath.MouseEnter += new System.EventHandler(this.GenericShowTooltipInStatusBar);
			this.labelGameDirectoryPath.MouseLeave += new System.EventHandler(this.GenericResetStatusBarMessage);
			// 
			// openMapToCompileDialog
			// 
			this.openMapToCompileDialog.Filter = "Map files|*.map";
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(962, 661);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MinimumSize = new System.Drawing.Size(650, 650);
			this.Name = "Dashboard";
			this.Text = "Afterburner Map Compiler";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelCsg;
		private System.Windows.Forms.Label labelBsp;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.TextBox csgPathInput;
		private System.Windows.Forms.TextBox bspPathInput;
		private System.Windows.Forms.TextBox visPathInput;
		private System.Windows.Forms.TextBox radPathInput;
		private System.Windows.Forms.Label labelVis;
		private System.Windows.Forms.Label labelRad;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnChooseRadPath;
		private System.Windows.Forms.Button btnChooseVisPath;
		private System.Windows.Forms.Button btnChooseBspPath;
		private System.Windows.Forms.Button btnChooseCsgPath;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button btnChooseGameDir;
		private System.Windows.Forms.TextBox gamePathInput;
		private System.Windows.Forms.Label labelGameExeDir;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnFinalPreset;
		private System.Windows.Forms.Button btnDefaultPreset;
		private System.Windows.Forms.Button btnFastPreset;
		private System.Windows.Forms.Label labelPreset;
		private System.Windows.Forms.Label labelRadCmdLine;
		private System.Windows.Forms.Label labelVisCmdLine;
		private System.Windows.Forms.Label labelBspCmdLine;
		private System.Windows.Forms.TextBox radCmdLine;
		private System.Windows.Forms.TextBox visCmdLine;
		private System.Windows.Forms.TextBox bspCmdLine;
		private System.Windows.Forms.Label labelCsgCmdLine;
		private System.Windows.Forms.TextBox csgCmdLine;
		private System.Windows.Forms.TextBox tbCompileOutput;
		private System.Windows.Forms.Button btnCompile;
		private System.Windows.Forms.Button btnSaveLog;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
		private System.Windows.Forms.Button btnChooseMapFile;
		private System.Windows.Forms.Label labelMapFile;
		private System.Windows.Forms.TextBox mapFileToCompile;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label labelCompileDir;
		private System.Windows.Forms.Label labelMapsDir;
		private System.Windows.Forms.Label labelGameDir;
		private System.Windows.Forms.OpenFileDialog openMapToCompileDialog;
		private System.Windows.Forms.Label labelCompileDirectoryPath;
		private System.Windows.Forms.Label labelMapsDirectoryPath;
		private System.Windows.Forms.Label labelGameDirectoryPath;
		private System.Windows.Forms.Label labelTexturesDirectoryPath;
		private System.Windows.Forms.Label labelTexDir;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
	}
}

