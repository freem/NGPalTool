
namespace NGPalTool
{
	partial class MainForm
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
			if (disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newPaletteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.savePaletteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nextIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.previousIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.nextSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.previousSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importFromPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.exportCurrentSetAsASMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportSetRangeAsASMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.convertJascToNgpalToolstripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnColorPicker = new System.Windows.Forms.Button();
			this.gbInputColor = new System.Windows.Forms.GroupBox();
			this.tlpInputColor = new System.Windows.Forms.TableLayoutPanel();
			this.lblInRed = new System.Windows.Forms.Label();
			this.lblInGreen = new System.Windows.Forms.Label();
			this.lblInBlue = new System.Windows.Forms.Label();
			this.nudInRed = new System.Windows.Forms.NumericUpDown();
			this.nudInGreen = new System.Windows.Forms.NumericUpDown();
			this.nudInBlue = new System.Windows.Forms.NumericUpDown();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.gbOutputColor = new System.Windows.Forms.GroupBox();
			this.tlpOutputColor = new System.Windows.Forms.TableLayoutPanel();
			this.lblOutRed = new System.Windows.Forms.Label();
			this.lblOutBlue = new System.Windows.Forms.Label();
			this.lblOutGreen = new System.Windows.Forms.Label();
			this.tbOutRed = new System.Windows.Forms.TextBox();
			this.tbOutGreen = new System.Windows.Forms.TextBox();
			this.tbOutBlue = new System.Windows.Forms.TextBox();
			this.lblOutHex = new System.Windows.Forms.Label();
			this.tbOutHex = new System.Windows.Forms.TextBox();
			this.lblOutDark = new System.Windows.Forms.Label();
			this.cbDarkBit = new System.Windows.Forms.CheckBox();
			this.panelOutColorPreview = new System.Windows.Forms.Panel();
			this.pbPalettePreview = new System.Windows.Forms.PictureBox();
			this.tlpPaletteSetIndex = new System.Windows.Forms.TableLayoutPanel();
			this.lblPaletteSet = new System.Windows.Forms.Label();
			this.lblPaletteIndex = new System.Windows.Forms.Label();
			this.nudPalIndex = new System.Windows.Forms.NumericUpDown();
			this.nudPalSet = new System.Windows.Forms.NumericUpDown();
			this.tlpPalSetName = new System.Windows.Forms.TableLayoutPanel();
			this.lblPalSetName = new System.Windows.Forms.Label();
			this.tbPalSetName = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.gbInputColor.SuspendLayout();
			this.tlpInputColor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudInRed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudInGreen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudInBlue)).BeginInit();
			this.gbOutputColor.SuspendLayout();
			this.tlpOutputColor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPalettePreview)).BeginInit();
			this.tlpPaletteSetIndex.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPalIndex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPalSet)).BeginInit();
			this.tlpPalSetName.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.navigationToolStripMenuItem,
            this.importExportToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.convertToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(504, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPaletteFileToolStripMenuItem,
            this.openToolStripMenuItem,
            this.savePaletteFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newPaletteFileToolStripMenuItem
			// 
			this.newPaletteFileToolStripMenuItem.Name = "newPaletteFileToolStripMenuItem";
			this.newPaletteFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newPaletteFileToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			this.newPaletteFileToolStripMenuItem.Text = "&New Palette File";
			this.newPaletteFileToolStripMenuItem.Click += new System.EventHandler(this.newPaletteFileToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			this.openToolStripMenuItem.Text = "&Open Palette File...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// savePaletteFileToolStripMenuItem
			// 
			this.savePaletteFileToolStripMenuItem.Name = "savePaletteFileToolStripMenuItem";
			this.savePaletteFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.savePaletteFileToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			this.savePaletteFileToolStripMenuItem.Text = "&Save Palette File...";
			this.savePaletteFileToolStripMenuItem.Click += new System.EventHandler(this.savePaletteFileToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// navigationToolStripMenuItem
			// 
			this.navigationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextSetToolStripMenuItem,
            this.previousSetToolStripMenuItem,
            this.toolStripSeparator2,
            this.nextIndexToolStripMenuItem,
            this.previousIndexToolStripMenuItem});
			this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
			this.navigationToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.navigationToolStripMenuItem.Text = "Na&vigation";
			// 
			// nextIndexToolStripMenuItem
			// 
			this.nextIndexToolStripMenuItem.Name = "nextIndexToolStripMenuItem";
			this.nextIndexToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
			this.nextIndexToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.nextIndexToolStripMenuItem.Text = "N&ext Index";
			this.nextIndexToolStripMenuItem.Click += new System.EventHandler(this.nextIndexToolStripMenuItem_Click);
			// 
			// previousIndexToolStripMenuItem
			// 
			this.previousIndexToolStripMenuItem.Name = "previousIndexToolStripMenuItem";
			this.previousIndexToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
			this.previousIndexToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.previousIndexToolStripMenuItem.Text = "P&revious Index";
			this.previousIndexToolStripMenuItem.Click += new System.EventHandler(this.previousIndexToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// nextSetToolStripMenuItem
			// 
			this.nextSetToolStripMenuItem.Name = "nextSetToolStripMenuItem";
			this.nextSetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
			this.nextSetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.nextSetToolStripMenuItem.Text = "&Next Set";
			this.nextSetToolStripMenuItem.Click += new System.EventHandler(this.nextSetToolStripMenuItem_Click);
			// 
			// previousSetToolStripMenuItem
			// 
			this.previousSetToolStripMenuItem.Name = "previousSetToolStripMenuItem";
			this.previousSetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.previousSetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.previousSetToolStripMenuItem.Text = "&Previous Set";
			this.previousSetToolStripMenuItem.Click += new System.EventHandler(this.previousSetToolStripMenuItem_Click);
			// 
			// importExportToolStripMenuItem
			// 
			this.importExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromPNGToolStripMenuItem,
            this.toolStripSeparator3,
            this.exportCurrentSetAsASMToolStripMenuItem,
            this.exportSetRangeAsASMToolStripMenuItem});
			this.importExportToolStripMenuItem.Name = "importExportToolStripMenuItem";
			this.importExportToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.importExportToolStripMenuItem.Text = "I&mport/Export";
			// 
			// importFromPNGToolStripMenuItem
			// 
			this.importFromPNGToolStripMenuItem.Name = "importFromPNGToolStripMenuItem";
			this.importFromPNGToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.importFromPNGToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
			this.importFromPNGToolStripMenuItem.Text = "Import from &PNG...";
			this.importFromPNGToolStripMenuItem.Click += new System.EventHandler(this.importFromPNGToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(258, 6);
			// 
			// exportCurrentSetAsASMToolStripMenuItem
			// 
			this.exportCurrentSetAsASMToolStripMenuItem.Name = "exportCurrentSetAsASMToolStripMenuItem";
			this.exportCurrentSetAsASMToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.exportCurrentSetAsASMToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
			this.exportCurrentSetAsASMToolStripMenuItem.Text = "&Export Current Set as ASM...";
			this.exportCurrentSetAsASMToolStripMenuItem.Click += new System.EventHandler(this.exportCurrentSetAsASMToolStripMenuItem_Click);
			// 
			// exportSetRangeAsASMToolStripMenuItem
			// 
			this.exportSetRangeAsASMToolStripMenuItem.Name = "exportSetRangeAsASMToolStripMenuItem";
			this.exportSetRangeAsASMToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.exportSetRangeAsASMToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
			this.exportSetRangeAsASMToolStripMenuItem.Text = "Export Set &Range as ASM...";
			this.exportSetRangeAsASMToolStripMenuItem.Click += new System.EventHandler(this.exportSetRangeAsASMToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.toolStripSeparator4,
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Hel&p";
			// 
			// manualToolStripMenuItem
			// 
			this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
			this.manualToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.manualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.manualToolStripMenuItem.Text = "&Manual...";
			this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.aboutToolStripMenuItem.Text = "&About NGPalTool...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// convertToolStripMenuItem
			// 
			this.convertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertJascToNgpalToolstripMenuItem});
			this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
			this.convertToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.convertToolStripMenuItem.Text = "C&onvert";
			this.convertToolStripMenuItem.Visible = false;
			// 
			// convertJascToNgpalToolstripMenuItem
			// 
			this.convertJascToNgpalToolstripMenuItem.Name = "convertJascToNgpalToolstripMenuItem";
			this.convertJascToNgpalToolstripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.convertJascToNgpalToolstripMenuItem.Text = "&JASC Palette to NGPal...";
			this.convertJascToNgpalToolstripMenuItem.Click += new System.EventHandler(this.convertJascToNgpalToolstripMenuItem_Click);
			// 
			// btnColorPicker
			// 
			this.btnColorPicker.Location = new System.Drawing.Point(12, 269);
			this.btnColorPicker.Name = "btnColorPicker";
			this.btnColorPicker.Size = new System.Drawing.Size(200, 23);
			this.btnColorPicker.TabIndex = 12;
			this.btnColorPicker.Text = "&Color Picker...";
			this.btnColorPicker.UseVisualStyleBackColor = true;
			this.btnColorPicker.Click += new System.EventHandler(this.btnColorPicker_Click);
			// 
			// gbInputColor
			// 
			this.gbInputColor.Controls.Add(this.tlpInputColor);
			this.gbInputColor.Location = new System.Drawing.Point(12, 130);
			this.gbInputColor.Name = "gbInputColor";
			this.gbInputColor.Size = new System.Drawing.Size(200, 133);
			this.gbInputColor.TabIndex = 6;
			this.gbInputColor.TabStop = false;
			this.gbInputColor.Text = "Input Color";
			// 
			// tlpInputColor
			// 
			this.tlpInputColor.ColumnCount = 2;
			this.tlpInputColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.17526F));
			this.tlpInputColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.82474F));
			this.tlpInputColor.Controls.Add(this.lblInRed, 0, 0);
			this.tlpInputColor.Controls.Add(this.lblInGreen, 0, 1);
			this.tlpInputColor.Controls.Add(this.lblInBlue, 0, 2);
			this.tlpInputColor.Controls.Add(this.nudInRed, 1, 0);
			this.tlpInputColor.Controls.Add(this.nudInGreen, 1, 1);
			this.tlpInputColor.Controls.Add(this.nudInBlue, 1, 2);
			this.tlpInputColor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpInputColor.Location = new System.Drawing.Point(3, 16);
			this.tlpInputColor.Name = "tlpInputColor";
			this.tlpInputColor.RowCount = 3;
			this.tlpInputColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpInputColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpInputColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpInputColor.Size = new System.Drawing.Size(194, 114);
			this.tlpInputColor.TabIndex = 6;
			// 
			// lblInRed
			// 
			this.lblInRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblInRed.AutoSize = true;
			this.lblInRed.Location = new System.Drawing.Point(3, 12);
			this.lblInRed.Name = "lblInRed";
			this.lblInRed.Size = new System.Drawing.Size(70, 13);
			this.lblInRed.TabIndex = 6;
			this.lblInRed.Text = "&Red";
			// 
			// lblInGreen
			// 
			this.lblInGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblInGreen.AutoSize = true;
			this.lblInGreen.Location = new System.Drawing.Point(3, 50);
			this.lblInGreen.Name = "lblInGreen";
			this.lblInGreen.Size = new System.Drawing.Size(70, 13);
			this.lblInGreen.TabIndex = 8;
			this.lblInGreen.Text = "&Green";
			// 
			// lblInBlue
			// 
			this.lblInBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblInBlue.AutoSize = true;
			this.lblInBlue.Location = new System.Drawing.Point(3, 88);
			this.lblInBlue.Name = "lblInBlue";
			this.lblInBlue.Size = new System.Drawing.Size(70, 13);
			this.lblInBlue.TabIndex = 10;
			this.lblInBlue.Text = "&Blue";
			// 
			// nudInRed
			// 
			this.nudInRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nudInRed.Location = new System.Drawing.Point(79, 9);
			this.nudInRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudInRed.Name = "nudInRed";
			this.nudInRed.Size = new System.Drawing.Size(112, 20);
			this.nudInRed.TabIndex = 7;
			this.nudInRed.ValueChanged += new System.EventHandler(this.nudInColor_ValueChanged);
			this.nudInRed.Enter += new System.EventHandler(this.nudInColor_Enter);
			// 
			// nudInGreen
			// 
			this.nudInGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nudInGreen.Location = new System.Drawing.Point(79, 47);
			this.nudInGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudInGreen.Name = "nudInGreen";
			this.nudInGreen.Size = new System.Drawing.Size(112, 20);
			this.nudInGreen.TabIndex = 9;
			this.nudInGreen.ValueChanged += new System.EventHandler(this.nudInColor_ValueChanged);
			this.nudInGreen.Enter += new System.EventHandler(this.nudInColor_Enter);
			// 
			// nudInBlue
			// 
			this.nudInBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nudInBlue.Location = new System.Drawing.Point(79, 85);
			this.nudInBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudInBlue.Name = "nudInBlue";
			this.nudInBlue.Size = new System.Drawing.Size(112, 20);
			this.nudInBlue.TabIndex = 11;
			this.nudInBlue.ValueChanged += new System.EventHandler(this.nudInColor_ValueChanged);
			this.nudInBlue.Enter += new System.EventHandler(this.nudInColor_Enter);
			// 
			// colorDialog1
			// 
			this.colorDialog1.AnyColor = true;
			this.colorDialog1.FullOpen = true;
			// 
			// gbOutputColor
			// 
			this.gbOutputColor.Controls.Add(this.tlpOutputColor);
			this.gbOutputColor.Location = new System.Drawing.Point(292, 130);
			this.gbOutputColor.Name = "gbOutputColor";
			this.gbOutputColor.Size = new System.Drawing.Size(200, 162);
			this.gbOutputColor.TabIndex = 13;
			this.gbOutputColor.TabStop = false;
			this.gbOutputColor.Text = "Output Color";
			// 
			// tlpOutputColor
			// 
			this.tlpOutputColor.ColumnCount = 2;
			this.tlpOutputColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpOutputColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tlpOutputColor.Controls.Add(this.lblOutRed, 0, 0);
			this.tlpOutputColor.Controls.Add(this.lblOutBlue, 0, 2);
			this.tlpOutputColor.Controls.Add(this.lblOutGreen, 0, 1);
			this.tlpOutputColor.Controls.Add(this.tbOutRed, 1, 0);
			this.tlpOutputColor.Controls.Add(this.tbOutGreen, 1, 1);
			this.tlpOutputColor.Controls.Add(this.tbOutBlue, 1, 2);
			this.tlpOutputColor.Controls.Add(this.lblOutHex, 0, 4);
			this.tlpOutputColor.Controls.Add(this.tbOutHex, 1, 4);
			this.tlpOutputColor.Controls.Add(this.lblOutDark, 0, 3);
			this.tlpOutputColor.Controls.Add(this.cbDarkBit, 1, 3);
			this.tlpOutputColor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpOutputColor.Location = new System.Drawing.Point(3, 16);
			this.tlpOutputColor.Name = "tlpOutputColor";
			this.tlpOutputColor.RowCount = 5;
			this.tlpOutputColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpOutputColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpOutputColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpOutputColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpOutputColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpOutputColor.Size = new System.Drawing.Size(194, 143);
			this.tlpOutputColor.TabIndex = 13;
			// 
			// lblOutRed
			// 
			this.lblOutRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblOutRed.AutoSize = true;
			this.lblOutRed.Location = new System.Drawing.Point(3, 7);
			this.lblOutRed.Name = "lblOutRed";
			this.lblOutRed.Size = new System.Drawing.Size(42, 13);
			this.lblOutRed.TabIndex = 13;
			this.lblOutRed.Text = "Re&d";
			// 
			// lblOutBlue
			// 
			this.lblOutBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblOutBlue.AutoSize = true;
			this.lblOutBlue.Location = new System.Drawing.Point(3, 63);
			this.lblOutBlue.Name = "lblOutBlue";
			this.lblOutBlue.Size = new System.Drawing.Size(42, 13);
			this.lblOutBlue.TabIndex = 17;
			this.lblOutBlue.Text = "B&lue";
			// 
			// lblOutGreen
			// 
			this.lblOutGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblOutGreen.AutoSize = true;
			this.lblOutGreen.Location = new System.Drawing.Point(3, 35);
			this.lblOutGreen.Name = "lblOutGreen";
			this.lblOutGreen.Size = new System.Drawing.Size(42, 13);
			this.lblOutGreen.TabIndex = 15;
			this.lblOutGreen.Text = "Gree&n";
			// 
			// tbOutRed
			// 
			this.tbOutRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbOutRed.Location = new System.Drawing.Point(51, 4);
			this.tbOutRed.Name = "tbOutRed";
			this.tbOutRed.ReadOnly = true;
			this.tbOutRed.Size = new System.Drawing.Size(140, 20);
			this.tbOutRed.TabIndex = 14;
			// 
			// tbOutGreen
			// 
			this.tbOutGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbOutGreen.Location = new System.Drawing.Point(51, 32);
			this.tbOutGreen.Name = "tbOutGreen";
			this.tbOutGreen.ReadOnly = true;
			this.tbOutGreen.Size = new System.Drawing.Size(140, 20);
			this.tbOutGreen.TabIndex = 16;
			// 
			// tbOutBlue
			// 
			this.tbOutBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbOutBlue.Location = new System.Drawing.Point(51, 60);
			this.tbOutBlue.Name = "tbOutBlue";
			this.tbOutBlue.ReadOnly = true;
			this.tbOutBlue.Size = new System.Drawing.Size(140, 20);
			this.tbOutBlue.TabIndex = 18;
			// 
			// lblOutHex
			// 
			this.lblOutHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblOutHex.AutoSize = true;
			this.lblOutHex.Location = new System.Drawing.Point(3, 121);
			this.lblOutHex.Name = "lblOutHex";
			this.lblOutHex.Size = new System.Drawing.Size(42, 13);
			this.lblOutHex.TabIndex = 21;
			this.lblOutHex.Text = "&Hex";
			// 
			// tbOutHex
			// 
			this.tbOutHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbOutHex.Location = new System.Drawing.Point(51, 117);
			this.tbOutHex.Name = "tbOutHex";
			this.tbOutHex.ReadOnly = true;
			this.tbOutHex.Size = new System.Drawing.Size(140, 20);
			this.tbOutHex.TabIndex = 22;
			this.tbOutHex.Enter += new System.EventHandler(this.tbOutHex_Enter);
			// 
			// lblOutDark
			// 
			this.lblOutDark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblOutDark.AutoSize = true;
			this.lblOutDark.Location = new System.Drawing.Point(3, 91);
			this.lblOutDark.Name = "lblOutDark";
			this.lblOutDark.Size = new System.Drawing.Size(42, 13);
			this.lblOutDark.TabIndex = 19;
			this.lblOutDark.Text = "Dark";
			// 
			// cbDarkBit
			// 
			this.cbDarkBit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbDarkBit.AutoCheck = false;
			this.cbDarkBit.AutoSize = true;
			this.cbDarkBit.Location = new System.Drawing.Point(51, 89);
			this.cbDarkBit.Name = "cbDarkBit";
			this.cbDarkBit.Size = new System.Drawing.Size(140, 17);
			this.cbDarkBit.TabIndex = 20;
			this.cbDarkBit.TabStop = false;
			this.cbDarkBit.Text = "Dark bit ($8000)";
			this.cbDarkBit.UseVisualStyleBackColor = true;
			// 
			// panelOutColorPreview
			// 
			this.panelOutColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelOutColorPreview.Location = new System.Drawing.Point(218, 130);
			this.panelOutColorPreview.Name = "panelOutColorPreview";
			this.panelOutColorPreview.Size = new System.Drawing.Size(68, 162);
			this.panelOutColorPreview.TabIndex = 4;
			// 
			// pbPalettePreview
			// 
			this.pbPalettePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbPalettePreview.Location = new System.Drawing.Point(12, 98);
			this.pbPalettePreview.Name = "pbPalettePreview";
			this.pbPalettePreview.Size = new System.Drawing.Size(480, 26);
			this.pbPalettePreview.TabIndex = 9;
			this.pbPalettePreview.TabStop = false;
			// 
			// tlpPaletteSetIndex
			// 
			this.tlpPaletteSetIndex.ColumnCount = 4;
			this.tlpPaletteSetIndex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpPaletteSetIndex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tlpPaletteSetIndex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpPaletteSetIndex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tlpPaletteSetIndex.Controls.Add(this.lblPaletteSet, 0, 0);
			this.tlpPaletteSetIndex.Controls.Add(this.lblPaletteIndex, 2, 0);
			this.tlpPaletteSetIndex.Controls.Add(this.nudPalIndex, 3, 0);
			this.tlpPaletteSetIndex.Controls.Add(this.nudPalSet, 1, 0);
			this.tlpPaletteSetIndex.Location = new System.Drawing.Point(12, 27);
			this.tlpPaletteSetIndex.Name = "tlpPaletteSetIndex";
			this.tlpPaletteSetIndex.RowCount = 1;
			this.tlpPaletteSetIndex.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpPaletteSetIndex.Size = new System.Drawing.Size(480, 29);
			this.tlpPaletteSetIndex.TabIndex = 0;
			// 
			// lblPaletteSet
			// 
			this.lblPaletteSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPaletteSet.AutoSize = true;
			this.lblPaletteSet.Location = new System.Drawing.Point(3, 8);
			this.lblPaletteSet.Name = "lblPaletteSet";
			this.lblPaletteSet.Size = new System.Drawing.Size(90, 13);
			this.lblPaletteSet.TabIndex = 0;
			this.lblPaletteSet.Text = "Palette &Set";
			// 
			// lblPaletteIndex
			// 
			this.lblPaletteIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPaletteIndex.AutoSize = true;
			this.lblPaletteIndex.Location = new System.Drawing.Point(243, 8);
			this.lblPaletteIndex.Name = "lblPaletteIndex";
			this.lblPaletteIndex.Size = new System.Drawing.Size(90, 13);
			this.lblPaletteIndex.TabIndex = 2;
			this.lblPaletteIndex.Text = "Palette &Index";
			// 
			// nudPalIndex
			// 
			this.nudPalIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nudPalIndex.Location = new System.Drawing.Point(339, 4);
			this.nudPalIndex.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.nudPalIndex.Name = "nudPalIndex";
			this.nudPalIndex.Size = new System.Drawing.Size(138, 20);
			this.nudPalIndex.TabIndex = 3;
			this.nudPalIndex.ValueChanged += new System.EventHandler(this.nudPalIndex_ValueChanged);
			// 
			// nudPalSet
			// 
			this.nudPalSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nudPalSet.Location = new System.Drawing.Point(99, 4);
			this.nudPalSet.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudPalSet.Name = "nudPalSet";
			this.nudPalSet.Size = new System.Drawing.Size(138, 20);
			this.nudPalSet.TabIndex = 1;
			this.nudPalSet.ValueChanged += new System.EventHandler(this.nudPalSet_ValueChanged);
			// 
			// tlpPalSetName
			// 
			this.tlpPalSetName.ColumnCount = 2;
			this.tlpPalSetName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tlpPalSetName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tlpPalSetName.Controls.Add(this.lblPalSetName, 0, 0);
			this.tlpPalSetName.Controls.Add(this.tbPalSetName, 1, 0);
			this.tlpPalSetName.Location = new System.Drawing.Point(12, 62);
			this.tlpPalSetName.Name = "tlpPalSetName";
			this.tlpPalSetName.RowCount = 1;
			this.tlpPalSetName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpPalSetName.Size = new System.Drawing.Size(480, 30);
			this.tlpPalSetName.TabIndex = 4;
			// 
			// lblPalSetName
			// 
			this.lblPalSetName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPalSetName.AutoSize = true;
			this.lblPalSetName.Location = new System.Drawing.Point(3, 8);
			this.lblPalSetName.Name = "lblPalSetName";
			this.lblPalSetName.Size = new System.Drawing.Size(138, 13);
			this.lblPalSetName.TabIndex = 4;
			this.lblPalSetName.Text = "Palette Set N&ame";
			// 
			// tbPalSetName
			// 
			this.tbPalSetName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPalSetName.Location = new System.Drawing.Point(147, 5);
			this.tbPalSetName.Name = "tbPalSetName";
			this.tbPalSetName.Size = new System.Drawing.Size(330, 20);
			this.tbPalSetName.TabIndex = 5;
			this.tbPalSetName.TextChanged += new System.EventHandler(this.tbPalSetName_TextChanged);
			this.tbPalSetName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPalSetName_KeyPress);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 304);
			this.Controls.Add(this.tlpPalSetName);
			this.Controls.Add(this.tlpPaletteSetIndex);
			this.Controls.Add(this.pbPalettePreview);
			this.Controls.Add(this.panelOutColorPreview);
			this.Controls.Add(this.gbOutputColor);
			this.Controls.Add(this.gbInputColor);
			this.Controls.Add(this.btnColorPicker);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(520, 343);
			this.Name = "MainForm";
			this.Text = "NGPalTool";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.gbInputColor.ResumeLayout(false);
			this.tlpInputColor.ResumeLayout(false);
			this.tlpInputColor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudInRed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudInGreen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudInBlue)).EndInit();
			this.gbOutputColor.ResumeLayout(false);
			this.tlpOutputColor.ResumeLayout(false);
			this.tlpOutputColor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPalettePreview)).EndInit();
			this.tlpPaletteSetIndex.ResumeLayout(false);
			this.tlpPaletteSetIndex.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPalIndex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPalSet)).EndInit();
			this.tlpPalSetName.ResumeLayout(false);
			this.tlpPalSetName.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Button btnColorPicker;
		private System.Windows.Forms.GroupBox gbInputColor;
		private System.Windows.Forms.TableLayoutPanel tlpInputColor;
		private System.Windows.Forms.Label lblInRed;
		private System.Windows.Forms.Label lblInGreen;
		private System.Windows.Forms.Label lblInBlue;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.NumericUpDown nudInRed;
		private System.Windows.Forms.NumericUpDown nudInGreen;
		private System.Windows.Forms.NumericUpDown nudInBlue;
		private System.Windows.Forms.GroupBox gbOutputColor;
		private System.Windows.Forms.Panel panelOutColorPreview;
		private System.Windows.Forms.TableLayoutPanel tlpOutputColor;
		private System.Windows.Forms.Label lblOutRed;
		private System.Windows.Forms.Label lblOutBlue;
		private System.Windows.Forms.Label lblOutGreen;
		private System.Windows.Forms.Label lblOutHex;
		private System.Windows.Forms.TextBox tbOutRed;
		private System.Windows.Forms.TextBox tbOutGreen;
		private System.Windows.Forms.TextBox tbOutBlue;
		private System.Windows.Forms.TextBox tbOutHex;
		private System.Windows.Forms.Label lblOutDark;
		private System.Windows.Forms.CheckBox cbDarkBit;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.PictureBox pbPalettePreview;
		private System.Windows.Forms.TableLayoutPanel tlpPaletteSetIndex;
		private System.Windows.Forms.Label lblPaletteSet;
		private System.Windows.Forms.Label lblPaletteIndex;
		private System.Windows.Forms.NumericUpDown nudPalIndex;
		private System.Windows.Forms.NumericUpDown nudPalSet;
		private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem convertJascToNgpalToolstripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem savePaletteFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newPaletteFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nextIndexToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem previousIndexToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem nextSetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem previousSetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importExportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importFromPNGToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem exportCurrentSetAsASMToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportSetRangeAsASMToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tlpPalSetName;
		private System.Windows.Forms.Label lblPalSetName;
		private System.Windows.Forms.TextBox tbPalSetName;
		private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
	}
}

