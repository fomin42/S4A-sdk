namespace WG3000_Demo
{
    partial class frmController
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
            if (disposing && (wgMjController1 != null)) //要释放
            {
                wgMjController1.Dispose();
            }
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
            this.grpbIP = new System.Windows.Forms.GroupBox();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.txtSN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtControllerIP = new System.Windows.Forms.TextBox();
            this.label123 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnReadRunInfo = new System.Windows.Forms.Button();
            this.btnClearInfo = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnRemoteOpenDoor = new System.Windows.Forms.Button();
            this.label79 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReadControllerDateTime = new System.Windows.Forms.Button();
            this.btnSetControllerDateTime = new System.Windows.Forms.Button();
            this.btnControllerParameter = new System.Windows.Forms.Button();
            this.btnGetAllSwipeRecords = new System.Windows.Forms.Button();
            this.bkGetRecords = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRestoreSwipe = new System.Windows.Forms.Button();
            this.btnWatching = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSearchControllers = new System.Windows.Forms.Button();
            this.btnRegisterCardManage = new System.Windows.Forms.Button();
            this.btnControlTimeSegManagement = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGetControllerParameter = new System.Windows.Forms.Button();
            this.label70 = new System.Windows.Forms.Label();
            this.numericUpDown14 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.comboBox54 = new System.Windows.Forms.ComboBox();
            this.comboBox51 = new System.Windows.Forms.ComboBox();
            this.label55 = new System.Windows.Forms.Label();
            this.comboBox53 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.comboBox52 = new System.Windows.Forms.ComboBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.btnFormat = new System.Windows.Forms.Button();
            this.grpbIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSN)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbIP
            // 
            this.grpbIP.BackColor = System.Drawing.Color.White;
            this.grpbIP.Controls.Add(this.nudPort);
            this.grpbIP.Controls.Add(this.txtSN);
            this.grpbIP.Controls.Add(this.label1);
            this.grpbIP.Controls.Add(this.txtControllerIP);
            this.grpbIP.Controls.Add(this.label123);
            this.grpbIP.Controls.Add(this.label124);
            this.grpbIP.Controls.Add(this.btnChange);
            this.grpbIP.Location = new System.Drawing.Point(12, 12);
            this.grpbIP.Name = "grpbIP";
            this.grpbIP.Size = new System.Drawing.Size(296, 72);
            this.grpbIP.TabIndex = 104;
            this.grpbIP.TabStop = false;
            // 
            // nudPort
            // 
            this.nudPort.Enabled = false;
            this.nudPort.Location = new System.Drawing.Point(170, 46);
            this.nudPort.Maximum = new decimal(new int[] {
            65534,
            0,
            0,
            0});
            this.nudPort.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(57, 21);
            this.nudPort.TabIndex = 58;
            this.nudPort.Value = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            // 
            // txtSN
            // 
            this.txtSN.Enabled = false;
            this.txtSN.Location = new System.Drawing.Point(45, 20);
            this.txtSN.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(89, 21);
            this.txtSN.TabIndex = 103;
            this.txtSN.Value = new decimal(new int[] {
            200190063,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 102;
            this.label1.Text = "SN:";
            // 
            // txtControllerIP
            // 
            this.txtControllerIP.Enabled = false;
            this.txtControllerIP.Location = new System.Drawing.Point(170, 19);
            this.txtControllerIP.Name = "txtControllerIP";
            this.txtControllerIP.Size = new System.Drawing.Size(116, 21);
            this.txtControllerIP.TabIndex = 0;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label123.Location = new System.Drawing.Point(138, 50);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(35, 12);
            this.label123.TabIndex = 6;
            this.label123.Text = "PORT:";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label124.Location = new System.Drawing.Point(144, 23);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(23, 12);
            this.label124.TabIndex = 4;
            this.label124.Text = "IP:";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(46, 45);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 105;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnReadRunInfo
            // 
            this.btnReadRunInfo.Location = new System.Drawing.Point(28, 101);
            this.btnReadRunInfo.Name = "btnReadRunInfo";
            this.btnReadRunInfo.Size = new System.Drawing.Size(161, 23);
            this.btnReadRunInfo.TabIndex = 106;
            this.btnReadRunInfo.Text = "读取运行信息";
            this.btnReadRunInfo.UseVisualStyleBackColor = true;
            this.btnReadRunInfo.Click += new System.EventHandler(this.btnReadRunInfo_Click);
            // 
            // btnClearInfo
            // 
            this.btnClearInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearInfo.Location = new System.Drawing.Point(884, 56);
            this.btnClearInfo.Name = "btnClearInfo";
            this.btnClearInfo.Size = new System.Drawing.Size(75, 23);
            this.btnClearInfo.TabIndex = 108;
            this.btnClearInfo.Text = "清空信息";
            this.btnClearInfo.UseVisualStyleBackColor = true;
            this.btnClearInfo.Click += new System.EventHandler(this.btnClearInfo_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.Location = new System.Drawing.Point(314, 94);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(645, 601);
            this.txtInfo.TabIndex = 107;
            // 
            // btnRemoteOpenDoor
            // 
            this.btnRemoteOpenDoor.Location = new System.Drawing.Point(16, 51);
            this.btnRemoteOpenDoor.Name = "btnRemoteOpenDoor";
            this.btnRemoteOpenDoor.Size = new System.Drawing.Size(161, 23);
            this.btnRemoteOpenDoor.TabIndex = 111;
            this.btnRemoteOpenDoor.Text = "远程开门";
            this.btnRemoteOpenDoor.UseVisualStyleBackColor = true;
            this.btnRemoteOpenDoor.Click += new System.EventHandler(this.btnRemoteOpenDoor_Click);
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(17, 27);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(53, 12);
            this.label79.TabIndex = 109;
            this.label79.Text = "指定门号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label79);
            this.groupBox1.Controls.Add(this.btnRemoteOpenDoor);
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 87);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(108, 24);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 21);
            this.numericUpDown1.TabIndex = 113;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 686);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 72);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReadControllerDateTime);
            this.groupBox3.Controls.Add(this.btnSetControllerDateTime);
            this.groupBox3.Location = new System.Drawing.Point(12, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 85);
            this.groupBox3.TabIndex = 113;
            this.groupBox3.TabStop = false;
            // 
            // btnReadControllerDateTime
            // 
            this.btnReadControllerDateTime.Location = new System.Drawing.Point(16, 49);
            this.btnReadControllerDateTime.Name = "btnReadControllerDateTime";
            this.btnReadControllerDateTime.Size = new System.Drawing.Size(161, 23);
            this.btnReadControllerDateTime.TabIndex = 115;
            this.btnReadControllerDateTime.Text = "读取控制器时间";
            this.btnReadControllerDateTime.UseVisualStyleBackColor = true;
            this.btnReadControllerDateTime.Click += new System.EventHandler(this.btnReadControllerDateTime_Click);
            // 
            // btnSetControllerDateTime
            // 
            this.btnSetControllerDateTime.Location = new System.Drawing.Point(16, 20);
            this.btnSetControllerDateTime.Name = "btnSetControllerDateTime";
            this.btnSetControllerDateTime.Size = new System.Drawing.Size(161, 23);
            this.btnSetControllerDateTime.TabIndex = 114;
            this.btnSetControllerDateTime.Text = "以电脑时间校准控制器";
            this.btnSetControllerDateTime.UseVisualStyleBackColor = true;
            this.btnSetControllerDateTime.Click += new System.EventHandler(this.btnSetControllerDateTime_Click);
            // 
            // btnControllerParameter
            // 
            this.btnControllerParameter.Location = new System.Drawing.Point(16, 144);
            this.btnControllerParameter.Name = "btnControllerParameter";
            this.btnControllerParameter.Size = new System.Drawing.Size(161, 23);
            this.btnControllerParameter.TabIndex = 120;
            this.btnControllerParameter.Text = "修改控制参数";
            this.btnControllerParameter.UseVisualStyleBackColor = true;
            this.btnControllerParameter.Click += new System.EventHandler(this.btnControllerParameter_Click);
            // 
            // btnGetAllSwipeRecords
            // 
            this.btnGetAllSwipeRecords.Location = new System.Drawing.Point(16, 20);
            this.btnGetAllSwipeRecords.Name = "btnGetAllSwipeRecords";
            this.btnGetAllSwipeRecords.Size = new System.Drawing.Size(161, 23);
            this.btnGetAllSwipeRecords.TabIndex = 121;
            this.btnGetAllSwipeRecords.Text = "提取所有刷卡记录";
            this.btnGetAllSwipeRecords.UseVisualStyleBackColor = true;
            this.btnGetAllSwipeRecords.Click += new System.EventHandler(this.btnGetAllSwipeRecords_Click);
            // 
            // bkGetRecords
            // 
            this.bkGetRecords.WorkerSupportsCancellation = true;
            this.bkGetRecords.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkGetRecords_DoWork);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 699);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(947, 181);
            this.dataGridView1.TabIndex = 122;
            // 
            // btnRestoreSwipe
            // 
            this.btnRestoreSwipe.Location = new System.Drawing.Point(16, 49);
            this.btnRestoreSwipe.Name = "btnRestoreSwipe";
            this.btnRestoreSwipe.Size = new System.Drawing.Size(161, 23);
            this.btnRestoreSwipe.TabIndex = 123;
            this.btnRestoreSwipe.Text = "恢复已提取记录";
            this.btnRestoreSwipe.UseVisualStyleBackColor = true;
            this.btnRestoreSwipe.Click += new System.EventHandler(this.btnRestoreSwipe_Click);
            // 
            // btnWatching
            // 
            this.btnWatching.Location = new System.Drawing.Point(334, 57);
            this.btnWatching.Name = "btnWatching";
            this.btnWatching.Size = new System.Drawing.Size(161, 23);
            this.btnWatching.TabIndex = 124;
            this.btnWatching.Text = "实时监控";
            this.btnWatching.UseVisualStyleBackColor = true;
            this.btnWatching.Click += new System.EventHandler(this.btnWatching_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnGetAllSwipeRecords);
            this.groupBox5.Controls.Add(this.btnRestoreSwipe);
            this.groupBox5.Location = new System.Drawing.Point(12, 540);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 79);
            this.groupBox5.TabIndex = 113;
            this.groupBox5.TabStop = false;
            // 
            // btnSearchControllers
            // 
            this.btnSearchControllers.Location = new System.Drawing.Point(334, 24);
            this.btnSearchControllers.Name = "btnSearchControllers";
            this.btnSearchControllers.Size = new System.Drawing.Size(161, 23);
            this.btnSearchControllers.TabIndex = 125;
            this.btnSearchControllers.Text = "搜索控制器 修改IP设置";
            this.btnSearchControllers.UseVisualStyleBackColor = true;
            this.btnSearchControllers.Click += new System.EventHandler(this.btnSearchControllers_Click);
            // 
            // btnRegisterCardManage
            // 
            this.btnRegisterCardManage.Location = new System.Drawing.Point(502, 57);
            this.btnRegisterCardManage.Name = "btnRegisterCardManage";
            this.btnRegisterCardManage.Size = new System.Drawing.Size(161, 23);
            this.btnRegisterCardManage.TabIndex = 126;
            this.btnRegisterCardManage.Text = "注册卡权限管理";
            this.btnRegisterCardManage.UseVisualStyleBackColor = true;
            this.btnRegisterCardManage.Click += new System.EventHandler(this.btnRegisterCardManage_Click);
            // 
            // btnControlTimeSegManagement
            // 
            this.btnControlTimeSegManagement.Location = new System.Drawing.Point(670, 57);
            this.btnControlTimeSegManagement.Name = "btnControlTimeSegManagement";
            this.btnControlTimeSegManagement.Size = new System.Drawing.Size(161, 23);
            this.btnControlTimeSegManagement.TabIndex = 128;
            this.btnControlTimeSegManagement.Text = "控制时段管理";
            this.btnControlTimeSegManagement.UseVisualStyleBackColor = true;
            this.btnControlTimeSegManagement.Click += new System.EventHandler(this.btnControlTimeSegManagement_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGetControllerParameter);
            this.groupBox4.Controls.Add(this.label70);
            this.groupBox4.Controls.Add(this.numericUpDown14);
            this.groupBox4.Controls.Add(this.numericUpDown13);
            this.groupBox4.Controls.Add(this.numericUpDown12);
            this.groupBox4.Controls.Add(this.numericUpDown11);
            this.groupBox4.Controls.Add(this.comboBox54);
            this.groupBox4.Controls.Add(this.comboBox51);
            this.groupBox4.Controls.Add(this.label55);
            this.groupBox4.Controls.Add(this.comboBox53);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label56);
            this.groupBox4.Controls.Add(this.comboBox52);
            this.groupBox4.Controls.Add(this.label58);
            this.groupBox4.Controls.Add(this.btnControllerParameter);
            this.groupBox4.Controls.Add(this.label57);
            this.groupBox4.Location = new System.Drawing.Point(12, 335);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 199);
            this.groupBox4.TabIndex = 113;
            this.groupBox4.TabStop = false;
            // 
            // btnGetControllerParameter
            // 
            this.btnGetControllerParameter.Location = new System.Drawing.Point(16, 176);
            this.btnGetControllerParameter.Name = "btnGetControllerParameter";
            this.btnGetControllerParameter.Size = new System.Drawing.Size(161, 23);
            this.btnGetControllerParameter.TabIndex = 140;
            this.btnGetControllerParameter.Text = "读取控制参数";
            this.btnGetControllerParameter.UseVisualStyleBackColor = true;
            this.btnGetControllerParameter.Click += new System.EventHandler(this.btnGetControllerParameter_Click);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(146, 23);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(53, 12);
            this.label70.TabIndex = 139;
            this.label70.Text = "延时(秒)";
            // 
            // numericUpDown14
            // 
            this.numericUpDown14.Location = new System.Drawing.Point(148, 109);
            this.numericUpDown14.Maximum = new decimal(new int[] {
            6553,
            0,
            0,
            0});
            this.numericUpDown14.Name = "numericUpDown14";
            this.numericUpDown14.Size = new System.Drawing.Size(48, 21);
            this.numericUpDown14.TabIndex = 138;
            this.numericUpDown14.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.Location = new System.Drawing.Point(148, 86);
            this.numericUpDown13.Maximum = new decimal(new int[] {
            6553,
            0,
            0,
            0});
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(48, 21);
            this.numericUpDown13.TabIndex = 138;
            this.numericUpDown13.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Location = new System.Drawing.Point(148, 63);
            this.numericUpDown12.Maximum = new decimal(new int[] {
            6553,
            0,
            0,
            0});
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(48, 21);
            this.numericUpDown12.TabIndex = 138;
            this.numericUpDown12.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Location = new System.Drawing.Point(148, 40);
            this.numericUpDown11.Maximum = new decimal(new int[] {
            6553,
            0,
            0,
            0});
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(48, 21);
            this.numericUpDown11.TabIndex = 138;
            this.numericUpDown11.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // comboBox54
            // 
            this.comboBox54.FormattingEnabled = true;
            this.comboBox54.Items.AddRange(new object[] {
            "00 不受控制",
            "01 常开",
            "02 常闭",
            "03 在线"});
            this.comboBox54.Location = new System.Drawing.Point(45, 113);
            this.comboBox54.Name = "comboBox54";
            this.comboBox54.Size = new System.Drawing.Size(90, 20);
            this.comboBox54.TabIndex = 137;
            this.comboBox54.Text = "03 在线";
            // 
            // comboBox51
            // 
            this.comboBox51.FormattingEnabled = true;
            this.comboBox51.Items.AddRange(new object[] {
            "00 不受控制",
            "01 常开",
            "02 常闭",
            "03 在线"});
            this.comboBox51.Location = new System.Drawing.Point(45, 38);
            this.comboBox51.Name = "comboBox51";
            this.comboBox51.Size = new System.Drawing.Size(89, 20);
            this.comboBox51.TabIndex = 134;
            this.comboBox51.Text = "03 在线";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(4, 117);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(35, 12);
            this.label55.TabIndex = 130;
            this.label55.Text = "4号门";
            // 
            // comboBox53
            // 
            this.comboBox53.FormattingEnabled = true;
            this.comboBox53.Items.AddRange(new object[] {
            "00 不受控制",
            "01 常开",
            "02 常闭",
            "03 在线"});
            this.comboBox53.Location = new System.Drawing.Point(45, 88);
            this.comboBox53.Name = "comboBox53";
            this.comboBox53.Size = new System.Drawing.Size(90, 20);
            this.comboBox53.TabIndex = 136;
            this.comboBox53.Text = "03 在线";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 131;
            this.label2.Text = "控制方式";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(4, 41);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(35, 12);
            this.label56.TabIndex = 131;
            this.label56.Text = "1号门";
            // 
            // comboBox52
            // 
            this.comboBox52.FormattingEnabled = true;
            this.comboBox52.Items.AddRange(new object[] {
            "00 不受控制",
            "01 常开",
            "02 常闭",
            "03 在线"});
            this.comboBox52.Location = new System.Drawing.Point(45, 63);
            this.comboBox52.Name = "comboBox52";
            this.comboBox52.Size = new System.Drawing.Size(90, 20);
            this.comboBox52.TabIndex = 135;
            this.comboBox52.Text = "03 在线";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(4, 93);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(35, 12);
            this.label58.TabIndex = 133;
            this.label58.Text = "3号门";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(4, 69);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(35, 12);
            this.label57.TabIndex = 132;
            this.label57.Text = "2号门";
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(28, 634);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(161, 23);
            this.btnFormat.TabIndex = 130;
            this.btnFormat.Text = "格式化 慎用!!![约2分钟]";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // frmController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 882);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.btnControlTimeSegManagement);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnRegisterCardManage);
            this.Controls.Add(this.btnSearchControllers);
            this.Controls.Add(this.btnWatching);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearInfo);
            this.Controls.Add(this.btnReadRunInfo);
            this.Controls.Add(this.grpbIP);
            this.Name = "frmController";
            this.Text = "frmController";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmController_FormClosed);
            this.Load += new System.EventHandler(this.frmController_Load);
            this.grpbIP.ResumeLayout(false);
            this.grpbIP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbIP;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.NumericUpDown txtSN;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtControllerIP;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnReadRunInfo;
        private System.Windows.Forms.Button btnClearInfo;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnRemoteOpenDoor;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReadControllerDateTime;
        private System.Windows.Forms.Button btnSetControllerDateTime;
        private System.Windows.Forms.Button btnControllerParameter;
        private System.Windows.Forms.Button btnGetAllSwipeRecords;
        private System.ComponentModel.BackgroundWorker bkGetRecords;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRestoreSwipe;
        private System.Windows.Forms.Button btnWatching;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSearchControllers;
        private System.Windows.Forms.Button btnRegisterCardManage;
        private System.Windows.Forms.Button btnControlTimeSegManagement;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox54;
        private System.Windows.Forms.ComboBox comboBox51;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.ComboBox comboBox53;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ComboBox comboBox52;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.NumericUpDown numericUpDown14;
        private System.Windows.Forms.NumericUpDown numericUpDown13;
        private System.Windows.Forms.NumericUpDown numericUpDown12;
        private System.Windows.Forms.NumericUpDown numericUpDown11;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Button btnGetControllerParameter;
    }
}