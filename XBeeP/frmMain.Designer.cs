namespace XBeeP
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoText = new System.Windows.Forms.RadioButton();
            this.rdoHex = new System.Windows.Forms.RadioButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboData = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboStop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboBaud = new System.Windows.Forms.ComboBox();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.cmdToggle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.scrollChk = new System.Windows.Forms.CheckBox();
            this.frameInfoGrp = new System.Windows.Forms.GroupBox();
            this.frPanel = new System.Windows.Forms.Panel();
            this.basicInfoGrp = new System.Windows.Forms.GroupBox();
            this.vrefUpDown = new System.Windows.Forms.NumericUpDown();
            this.vrefLabel = new System.Windows.Forms.Label();
            this.resolutionUpDown = new System.Windows.Forms.NumericUpDown();
            this.resolutionLbl = new System.Windows.Forms.Label();
            this.checksumInfoLbl = new System.Windows.Forms.Label();
            this.checksumLbl = new System.Windows.Forms.Label();
            this.typeInfoLbl = new System.Windows.Forms.Label();
            this.lengthInfoLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.lengthLbl = new System.Windows.Forms.Label();
            this.recTimeInfoLbl = new System.Windows.Forms.Label();
            this.frameNrInfoLbl = new System.Windows.Forms.Label();
            this.recTimeLbl = new System.Windows.Forms.Label();
            this.frameNrLbl = new System.Windows.Forms.Label();
            this.rawInputGrp = new System.Windows.Forms.GroupBox();
            this.asciiTxtbox = new System.Windows.Forms.TextBox();
            this.hexTxtbox = new System.Windows.Forms.TextBox();
            this.asciiLbl = new System.Windows.Forms.Label();
            this.hexLbl = new System.Windows.Forms.Label();
            this.lstFrames = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sendStatusLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.frameTypeCombo = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sendFrameBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.asciiOutTxt = new System.Windows.Forms.TextBox();
            this.hexOutTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.frameInfoGrp.SuspendLayout();
            this.basicInfoGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vrefUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionUpDown)).BeginInit();
            this.rawInputGrp.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(688, 490);
            this.tabControl.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.GroupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.cmdToggle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(680, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoText);
            this.groupBox3.Controls.Add(this.rdoHex);
            this.groupBox3.Location = new System.Drawing.Point(571, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 60);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mode";
            // 
            // rdoText
            // 
            this.rdoText.AutoSize = true;
            this.rdoText.CausesValidation = false;
            this.rdoText.Location = new System.Drawing.Point(6, 38);
            this.rdoText.Name = "rdoText";
            this.rdoText.Size = new System.Drawing.Size(52, 17);
            this.rdoText.TabIndex = 1;
            this.rdoText.TabStop = true;
            this.rdoText.Text = "ASCII";
            this.rdoText.UseVisualStyleBackColor = true;
            // 
            // rdoHex
            // 
            this.rdoHex.AutoSize = true;
            this.rdoHex.Location = new System.Drawing.Point(6, 16);
            this.rdoHex.Name = "rdoHex";
            this.rdoHex.Size = new System.Drawing.Size(44, 17);
            this.rdoHex.TabIndex = 0;
            this.rdoHex.TabStop = true;
            this.rdoHex.Text = "Hex";
            this.rdoHex.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cmdClear);
            this.GroupBox1.Controls.Add(this.cmdSend);
            this.GroupBox1.Controls.Add(this.txtSend);
            this.GroupBox1.Controls.Add(this.rtbDisplay);
            this.GroupBox1.Location = new System.Drawing.Point(9, 15);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(556, 288);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Serial Port Communication";
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(456, 260);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(94, 23);
            this.cmdClear.TabIndex = 6;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(369, 260);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(75, 23);
            this.cmdSend.TabIndex = 5;
            this.cmdSend.Text = "Send";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(7, 259);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(356, 20);
            this.txtSend.TabIndex = 4;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(6, 16);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(543, 234);
            this.rtbDisplay.TabIndex = 3;
            this.rtbDisplay.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboData);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboStop);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboParity);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.cboBaud);
            this.groupBox2.Controls.Add(this.cboPort);
            this.groupBox2.Location = new System.Drawing.Point(575, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 221);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Data Bits";
            // 
            // cboData
            // 
            this.cboData.FormattingEnabled = true;
            this.cboData.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cboData.Location = new System.Drawing.Point(9, 195);
            this.cboData.Name = "cboData";
            this.cboData.Size = new System.Drawing.Size(76, 21);
            this.cboData.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Stop Bits";
            // 
            // cboStop
            // 
            this.cboStop.FormattingEnabled = true;
            this.cboStop.Location = new System.Drawing.Point(9, 155);
            this.cboStop.Name = "cboStop";
            this.cboStop.Size = new System.Drawing.Size(76, 21);
            this.cboStop.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Parity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Baud Rate";
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(9, 114);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(76, 21);
            this.cboParity.TabIndex = 12;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(26, 13);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Port";
            // 
            // cboBaud
            // 
            this.cboBaud.FormattingEnabled = true;
            this.cboBaud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115000"});
            this.cboBaud.Location = new System.Drawing.Point(9, 74);
            this.cboBaud.Name = "cboBaud";
            this.cboBaud.Size = new System.Drawing.Size(76, 21);
            this.cboBaud.TabIndex = 11;
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(9, 34);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(76, 21);
            this.cboPort.TabIndex = 10;
            // 
            // cmdToggle
            // 
            this.cmdToggle.Location = new System.Drawing.Point(575, 309);
            this.cmdToggle.Name = "cmdToggle";
            this.cmdToggle.Size = new System.Drawing.Size(94, 23);
            this.cmdToggle.TabIndex = 17;
            this.cmdToggle.Text = "Open Port";
            this.cmdToggle.UseVisualStyleBackColor = true;
            this.cmdToggle.Click += new System.EventHandler(this.cmdToggle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.scrollChk);
            this.tabPage2.Controls.Add(this.frameInfoGrp);
            this.tabPage2.Controls.Add(this.lstFrames);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(680, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Incoming Packets";
            // 
            // scrollChk
            // 
            this.scrollChk.AutoSize = true;
            this.scrollChk.Checked = true;
            this.scrollChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scrollChk.Location = new System.Drawing.Point(108, 419);
            this.scrollChk.Name = "scrollChk";
            this.scrollChk.Size = new System.Drawing.Size(77, 17);
            this.scrollChk.TabIndex = 3;
            this.scrollChk.Text = "Auto Scroll";
            this.scrollChk.UseVisualStyleBackColor = true;
            // 
            // frameInfoGrp
            // 
            this.frameInfoGrp.Controls.Add(this.frPanel);
            this.frameInfoGrp.Controls.Add(this.basicInfoGrp);
            this.frameInfoGrp.Controls.Add(this.rawInputGrp);
            this.frameInfoGrp.Location = new System.Drawing.Point(190, 8);
            this.frameInfoGrp.Name = "frameInfoGrp";
            this.frameInfoGrp.Size = new System.Drawing.Size(479, 431);
            this.frameInfoGrp.TabIndex = 2;
            this.frameInfoGrp.TabStop = false;
            this.frameInfoGrp.Text = "Frame Info";
            // 
            // frPanel
            // 
            this.frPanel.Location = new System.Drawing.Point(6, 181);
            this.frPanel.Name = "frPanel";
            this.frPanel.Size = new System.Drawing.Size(385, 250);
            this.frPanel.TabIndex = 5;
            // 
            // basicInfoGrp
            // 
            this.basicInfoGrp.Controls.Add(this.vrefUpDown);
            this.basicInfoGrp.Controls.Add(this.vrefLabel);
            this.basicInfoGrp.Controls.Add(this.resolutionUpDown);
            this.basicInfoGrp.Controls.Add(this.resolutionLbl);
            this.basicInfoGrp.Controls.Add(this.checksumInfoLbl);
            this.basicInfoGrp.Controls.Add(this.checksumLbl);
            this.basicInfoGrp.Controls.Add(this.typeInfoLbl);
            this.basicInfoGrp.Controls.Add(this.lengthInfoLbl);
            this.basicInfoGrp.Controls.Add(this.typeLbl);
            this.basicInfoGrp.Controls.Add(this.lengthLbl);
            this.basicInfoGrp.Controls.Add(this.recTimeInfoLbl);
            this.basicInfoGrp.Controls.Add(this.frameNrInfoLbl);
            this.basicInfoGrp.Controls.Add(this.recTimeLbl);
            this.basicInfoGrp.Controls.Add(this.frameNrLbl);
            this.basicInfoGrp.Location = new System.Drawing.Point(6, 19);
            this.basicInfoGrp.Name = "basicInfoGrp";
            this.basicInfoGrp.Size = new System.Drawing.Size(467, 81);
            this.basicInfoGrp.TabIndex = 4;
            this.basicInfoGrp.TabStop = false;
            this.basicInfoGrp.Text = "Basic Info";
            // 
            // vrefUpDown
            // 
            this.vrefUpDown.DecimalPlaces = 1;
            this.vrefUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.vrefUpDown.Location = new System.Drawing.Point(422, 14);
            this.vrefUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.vrefUpDown.Name = "vrefUpDown";
            this.vrefUpDown.Size = new System.Drawing.Size(40, 20);
            this.vrefUpDown.TabIndex = 21;
            this.vrefUpDown.Value = new decimal(new int[] {
            33,
            0,
            0,
            65536});
            this.vrefUpDown.ValueChanged += new System.EventHandler(this.vrefUpDown_ValueChanged);
            // 
            // vrefLabel
            // 
            this.vrefLabel.AutoSize = true;
            this.vrefLabel.Location = new System.Drawing.Point(359, 16);
            this.vrefLabel.Name = "vrefLabel";
            this.vrefLabel.Size = new System.Drawing.Size(26, 13);
            this.vrefLabel.TabIndex = 18;
            this.vrefLabel.Text = "Vref";
            // 
            // resolutionUpDown
            // 
            this.resolutionUpDown.Location = new System.Drawing.Point(422, 36);
            this.resolutionUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.resolutionUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.resolutionUpDown.Name = "resolutionUpDown";
            this.resolutionUpDown.Size = new System.Drawing.Size(40, 20);
            this.resolutionUpDown.TabIndex = 20;
            this.resolutionUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.resolutionUpDown.ValueChanged += new System.EventHandler(this.resolutionUpDown_ValueChanged);
            // 
            // resolutionLbl
            // 
            this.resolutionLbl.AutoSize = true;
            this.resolutionLbl.Location = new System.Drawing.Point(359, 38);
            this.resolutionLbl.Name = "resolutionLbl";
            this.resolutionLbl.Size = new System.Drawing.Size(42, 13);
            this.resolutionLbl.TabIndex = 19;
            this.resolutionLbl.Text = "AD Bits";
            // 
            // checksumInfoLbl
            // 
            this.checksumInfoLbl.AutoSize = true;
            this.checksumInfoLbl.Location = new System.Drawing.Point(71, 60);
            this.checksumInfoLbl.Name = "checksumInfoLbl";
            this.checksumInfoLbl.Size = new System.Drawing.Size(27, 13);
            this.checksumInfoLbl.TabIndex = 15;
            this.checksumInfoLbl.Text = "N/A";
            // 
            // checksumLbl
            // 
            this.checksumLbl.AutoSize = true;
            this.checksumLbl.Location = new System.Drawing.Point(12, 60);
            this.checksumLbl.Name = "checksumLbl";
            this.checksumLbl.Size = new System.Drawing.Size(57, 13);
            this.checksumLbl.TabIndex = 14;
            this.checksumLbl.Text = "Checksum";
            // 
            // typeInfoLbl
            // 
            this.typeInfoLbl.AutoSize = true;
            this.typeInfoLbl.Location = new System.Drawing.Point(195, 38);
            this.typeInfoLbl.Name = "typeInfoLbl";
            this.typeInfoLbl.Size = new System.Drawing.Size(27, 13);
            this.typeInfoLbl.TabIndex = 13;
            this.typeInfoLbl.Text = "N/A";
            // 
            // lengthInfoLbl
            // 
            this.lengthInfoLbl.AutoSize = true;
            this.lengthInfoLbl.Location = new System.Drawing.Point(71, 38);
            this.lengthInfoLbl.Name = "lengthInfoLbl";
            this.lengthInfoLbl.Size = new System.Drawing.Size(27, 13);
            this.lengthInfoLbl.TabIndex = 12;
            this.lengthInfoLbl.Text = "N/A";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(136, 38);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(31, 13);
            this.typeLbl.TabIndex = 11;
            this.typeLbl.Text = "Type";
            // 
            // lengthLbl
            // 
            this.lengthLbl.AutoSize = true;
            this.lengthLbl.Location = new System.Drawing.Point(12, 38);
            this.lengthLbl.Name = "lengthLbl";
            this.lengthLbl.Size = new System.Drawing.Size(40, 13);
            this.lengthLbl.TabIndex = 10;
            this.lengthLbl.Text = "Length";
            // 
            // recTimeInfoLbl
            // 
            this.recTimeInfoLbl.AutoSize = true;
            this.recTimeInfoLbl.Location = new System.Drawing.Point(195, 16);
            this.recTimeInfoLbl.Name = "recTimeInfoLbl";
            this.recTimeInfoLbl.Size = new System.Drawing.Size(27, 13);
            this.recTimeInfoLbl.TabIndex = 3;
            this.recTimeInfoLbl.Text = "N/A";
            // 
            // frameNrInfoLbl
            // 
            this.frameNrInfoLbl.AutoSize = true;
            this.frameNrInfoLbl.Location = new System.Drawing.Point(71, 16);
            this.frameNrInfoLbl.Name = "frameNrInfoLbl";
            this.frameNrInfoLbl.Size = new System.Drawing.Size(27, 13);
            this.frameNrInfoLbl.TabIndex = 2;
            this.frameNrInfoLbl.Text = "N/A";
            // 
            // recTimeLbl
            // 
            this.recTimeLbl.AutoSize = true;
            this.recTimeLbl.Location = new System.Drawing.Point(136, 16);
            this.recTimeLbl.Name = "recTimeLbl";
            this.recTimeLbl.Size = new System.Drawing.Size(53, 13);
            this.recTimeLbl.TabIndex = 1;
            this.recTimeLbl.Text = "Received";
            // 
            // frameNrLbl
            // 
            this.frameNrLbl.AutoSize = true;
            this.frameNrLbl.Location = new System.Drawing.Point(12, 16);
            this.frameNrLbl.Name = "frameNrLbl";
            this.frameNrLbl.Size = new System.Drawing.Size(46, 13);
            this.frameNrLbl.TabIndex = 0;
            this.frameNrLbl.Text = "Frame #";
            // 
            // rawInputGrp
            // 
            this.rawInputGrp.Controls.Add(this.asciiTxtbox);
            this.rawInputGrp.Controls.Add(this.hexTxtbox);
            this.rawInputGrp.Controls.Add(this.asciiLbl);
            this.rawInputGrp.Controls.Add(this.hexLbl);
            this.rawInputGrp.Location = new System.Drawing.Point(6, 106);
            this.rawInputGrp.Name = "rawInputGrp";
            this.rawInputGrp.Size = new System.Drawing.Size(467, 69);
            this.rawInputGrp.TabIndex = 1;
            this.rawInputGrp.TabStop = false;
            this.rawInputGrp.Text = "Raw Data";
            // 
            // asciiTxtbox
            // 
            this.asciiTxtbox.Location = new System.Drawing.Point(61, 38);
            this.asciiTxtbox.Name = "asciiTxtbox";
            this.asciiTxtbox.Size = new System.Drawing.Size(400, 20);
            this.asciiTxtbox.TabIndex = 3;
            // 
            // hexTxtbox
            // 
            this.hexTxtbox.Location = new System.Drawing.Point(61, 16);
            this.hexTxtbox.Name = "hexTxtbox";
            this.hexTxtbox.Size = new System.Drawing.Size(400, 20);
            this.hexTxtbox.TabIndex = 2;
            // 
            // asciiLbl
            // 
            this.asciiLbl.AutoSize = true;
            this.asciiLbl.Location = new System.Drawing.Point(12, 41);
            this.asciiLbl.Name = "asciiLbl";
            this.asciiLbl.Size = new System.Drawing.Size(34, 13);
            this.asciiLbl.TabIndex = 1;
            this.asciiLbl.Text = "ASCII";
            // 
            // hexLbl
            // 
            this.hexLbl.AutoSize = true;
            this.hexLbl.Location = new System.Drawing.Point(12, 16);
            this.hexLbl.Name = "hexLbl";
            this.hexLbl.Size = new System.Drawing.Size(26, 13);
            this.hexLbl.TabIndex = 0;
            this.hexLbl.Text = "Hex";
            // 
            // lstFrames
            // 
            this.lstFrames.FormattingEnabled = true;
            this.lstFrames.Location = new System.Drawing.Point(8, 6);
            this.lstFrames.Name = "lstFrames";
            this.lstFrames.Size = new System.Drawing.Size(177, 407);
            this.lstFrames.TabIndex = 0;
            this.lstFrames.SelectedIndexChanged += new System.EventHandler(this.lstFrames_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.sendStatusLbl);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.frameTypeCombo);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.sendFrameBtn);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(680, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Send Packets";
            // 
            // sendStatusLbl
            // 
            this.sendStatusLbl.AutoSize = true;
            this.sendStatusLbl.Location = new System.Drawing.Point(96, 253);
            this.sendStatusLbl.Name = "sendStatusLbl";
            this.sendStatusLbl.Size = new System.Drawing.Size(0, 13);
            this.sendStatusLbl.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Frame Type";
            // 
            // frameTypeCombo
            // 
            this.frameTypeCombo.FormattingEnabled = true;
            this.frameTypeCombo.Location = new System.Drawing.Point(92, 6);
            this.frameTypeCombo.Name = "frameTypeCombo";
            this.frameTypeCombo.Size = new System.Drawing.Size(143, 21);
            this.frameTypeCombo.TabIndex = 5;
            this.frameTypeCombo.Text = "Select a frame type";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(11, 108);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(464, 135);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Frame Assembly";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Destination";
            // 
            // sendFrameBtn
            // 
            this.sendFrameBtn.Enabled = false;
            this.sendFrameBtn.Location = new System.Drawing.Point(11, 249);
            this.sendFrameBtn.Name = "sendFrameBtn";
            this.sendFrameBtn.Size = new System.Drawing.Size(79, 20);
            this.sendFrameBtn.TabIndex = 3;
            this.sendFrameBtn.Text = "Send Frame";
            this.sendFrameBtn.UseVisualStyleBackColor = true;
            this.sendFrameBtn.Click += new System.EventHandler(this.sendFrameBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.asciiOutTxt);
            this.groupBox4.Controls.Add(this.hexOutTxt);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(11, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(467, 69);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Raw Data";
            // 
            // asciiOutTxt
            // 
            this.asciiOutTxt.Location = new System.Drawing.Point(61, 38);
            this.asciiOutTxt.Name = "asciiOutTxt";
            this.asciiOutTxt.Size = new System.Drawing.Size(400, 20);
            this.asciiOutTxt.TabIndex = 3;
            // 
            // hexOutTxt
            // 
            this.hexOutTxt.Location = new System.Drawing.Point(61, 16);
            this.hexOutTxt.Name = "hexOutTxt";
            this.hexOutTxt.Size = new System.Drawing.Size(400, 20);
            this.hexOutTxt.TabIndex = 2;
            this.hexOutTxt.Text = "7E";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ASCII";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hex";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 518);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XBeeP";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.frameInfoGrp.ResumeLayout(false);
            this.basicInfoGrp.ResumeLayout(false);
            this.basicInfoGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vrefUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionUpDown)).EndInit();
            this.rawInputGrp.ResumeLayout(false);
            this.rawInputGrp.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoText;
        private System.Windows.Forms.RadioButton rdoHex;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox cboBaud;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Button cmdToggle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstFrames;
        private System.Windows.Forms.GroupBox frameInfoGrp;
        private System.Windows.Forms.GroupBox basicInfoGrp;
        private System.Windows.Forms.Label recTimeInfoLbl;
        private System.Windows.Forms.Label frameNrInfoLbl;
        private System.Windows.Forms.Label recTimeLbl;
        private System.Windows.Forms.Label frameNrLbl;
        private System.Windows.Forms.GroupBox rawInputGrp;
        private System.Windows.Forms.TextBox asciiTxtbox;
        private System.Windows.Forms.TextBox hexTxtbox;
        private System.Windows.Forms.Label asciiLbl;
        private System.Windows.Forms.Label hexLbl;
        private System.Windows.Forms.Label checksumInfoLbl;
        private System.Windows.Forms.Label checksumLbl;
        private System.Windows.Forms.Label typeInfoLbl;
        private System.Windows.Forms.Label lengthInfoLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label lengthLbl;
        private System.Windows.Forms.Panel frPanel;
        private System.Windows.Forms.Label resolutionLbl;
        private System.Windows.Forms.Label vrefLabel;
        private System.Windows.Forms.NumericUpDown vrefUpDown;
        private System.Windows.Forms.NumericUpDown resolutionUpDown;
        private System.Windows.Forms.CheckBox scrollChk;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox frameTypeCombo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sendFrameBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox asciiOutTxt;
        private System.Windows.Forms.TextBox hexOutTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label sendStatusLbl;
    }
}