namespace WG3000_Demo
{
    partial class frmPrivilege
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
            this.dtpDeactivate = new System.Windows.Forms.DateTimePicker();
            this.dtpActivate = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCardNO = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteOneUserPrivilege = new System.Windows.Forms.Button();
            this.btnUpdateOneUserPrivilege = new System.Windows.Forms.Button();
            this.btnUploadAllPrivilegs = new System.Windows.Forms.Button();
            this.btnClearAllPrivileges = new System.Windows.Forms.Button();
            this.bkUploadPrivileges = new System.ComponentModel.BackgroundWorker();
            this.btnDownloadAllPrivilegs = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDeactivate
            // 
            this.dtpDeactivate.Location = new System.Drawing.Point(57, 115);
            this.dtpDeactivate.Name = "dtpDeactivate";
            this.dtpDeactivate.Size = new System.Drawing.Size(116, 21);
            this.dtpDeactivate.TabIndex = 30;
            this.dtpDeactivate.Value = new System.DateTime(2029, 12, 31, 14, 44, 0, 0);
            // 
            // dtpActivate
            // 
            this.dtpActivate.CustomFormat = "yyyy-MM-dd";
            this.dtpActivate.Location = new System.Drawing.Point(56, 88);
            this.dtpActivate.Name = "dtpActivate";
            this.dtpActivate.Size = new System.Drawing.Size(117, 21);
            this.dtpActivate.TabIndex = 29;
            this.dtpActivate.Value = new System.DateTime(2011, 3, 18, 18, 18, 0, 0);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 119);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
            this.label23.TabIndex = 28;
            this.label23.Text = "截止";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 93);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 27;
            this.label22.Text = "起始";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(56, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 26;
            this.txtPassword.Text = "345678";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 65);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 12);
            this.label21.TabIndex = 25;
            this.label21.Text = "密码:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.00001F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.comboBox4, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBox3, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBox2, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label18, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label15, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label16, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label17, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 150);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(533, 114);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox4.Location = new System.Drawing.Point(427, 31);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(88, 20);
            this.comboBox4.TabIndex = 16;
            this.comboBox4.Text = "1";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox3.Location = new System.Drawing.Point(321, 31);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(88, 20);
            this.comboBox3.TabIndex = 15;
            this.comboBox3.Text = "1";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox2.Location = new System.Drawing.Point(215, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(88, 20);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.Text = "1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(427, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 12);
            this.label18.TabIndex = 3;
            this.label18.Text = "4号门";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "功能";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(109, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 12);
            this.label15.TabIndex = 9;
            this.label15.Text = "1号门";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(215, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 12);
            this.label16.TabIndex = 10;
            this.label16.Text = "2号门";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(321, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 12);
            this.label17.TabIndex = 11;
            this.label17.Text = "3号门";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 12;
            this.label19.Text = "控制时段";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(109, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 20;
            this.label12.Text = "卡号";
            // 
            // txtCardNO
            // 
            this.txtCardNO.Location = new System.Drawing.Point(56, 31);
            this.txtCardNO.Name = "txtCardNO";
            this.txtCardNO.Size = new System.Drawing.Size(89, 21);
            this.txtCardNO.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtCardNO);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.dtpDeactivate);
            this.groupBox1.Controls.Add(this.dtpActivate);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Location = new System.Drawing.Point(71, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 220);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "指定用户权限";
            // 
            // btnDeleteOneUserPrivilege
            // 
            this.btnDeleteOneUserPrivilege.Location = new System.Drawing.Point(469, 321);
            this.btnDeleteOneUserPrivilege.Name = "btnDeleteOneUserPrivilege";
            this.btnDeleteOneUserPrivilege.Size = new System.Drawing.Size(161, 23);
            this.btnDeleteOneUserPrivilege.TabIndex = 119;
            this.btnDeleteOneUserPrivilege.Text = "删除指定用户权限";
            this.btnDeleteOneUserPrivilege.UseVisualStyleBackColor = true;
            this.btnDeleteOneUserPrivilege.Click += new System.EventHandler(this.btnDeleteOneUserPrivilege_Click);
            // 
            // btnUpdateOneUserPrivilege
            // 
            this.btnUpdateOneUserPrivilege.Location = new System.Drawing.Point(276, 321);
            this.btnUpdateOneUserPrivilege.Name = "btnUpdateOneUserPrivilege";
            this.btnUpdateOneUserPrivilege.Size = new System.Drawing.Size(161, 23);
            this.btnUpdateOneUserPrivilege.TabIndex = 118;
            this.btnUpdateOneUserPrivilege.Text = "添加或修改指定用户权限";
            this.btnUpdateOneUserPrivilege.UseVisualStyleBackColor = true;
            this.btnUpdateOneUserPrivilege.Click += new System.EventHandler(this.btnUpdateOneUserPrivilege_Click);
            // 
            // btnUploadAllPrivilegs
            // 
            this.btnUploadAllPrivilegs.Location = new System.Drawing.Point(71, 378);
            this.btnUploadAllPrivilegs.Name = "btnUploadAllPrivilegs";
            this.btnUploadAllPrivilegs.Size = new System.Drawing.Size(309, 23);
            this.btnUploadAllPrivilegs.TabIndex = 117;
            this.btnUploadAllPrivilegs.Text = "上传所有权限[以指定卡号为开始的2000个卡权限]";
            this.btnUploadAllPrivilegs.UseVisualStyleBackColor = true;
            this.btnUploadAllPrivilegs.Click += new System.EventHandler(this.btnUploadAllPrivilegs_Click);
            // 
            // btnClearAllPrivileges
            // 
            this.btnClearAllPrivileges.Location = new System.Drawing.Point(71, 321);
            this.btnClearAllPrivileges.Name = "btnClearAllPrivileges";
            this.btnClearAllPrivileges.Size = new System.Drawing.Size(161, 23);
            this.btnClearAllPrivileges.TabIndex = 116;
            this.btnClearAllPrivileges.Text = "清空所有权限";
            this.btnClearAllPrivileges.UseVisualStyleBackColor = true;
            this.btnClearAllPrivileges.Click += new System.EventHandler(this.btnClearAllPrivileges_Click);
            // 
            // bkUploadPrivileges
            // 
            this.bkUploadPrivileges.WorkerSupportsCancellation = true;
            this.bkUploadPrivileges.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkUploadPrivileges_DoWork);
            // 
            // btnDownloadAllPrivilegs
            // 
            this.btnDownloadAllPrivilegs.Location = new System.Drawing.Point(71, 429);
            this.btnDownloadAllPrivilegs.Name = "btnDownloadAllPrivilegs";
            this.btnDownloadAllPrivilegs.Size = new System.Drawing.Size(161, 23);
            this.btnDownloadAllPrivilegs.TabIndex = 120;
            this.btnDownloadAllPrivilegs.Text = "提取所有权限";
            this.btnDownloadAllPrivilegs.UseVisualStyleBackColor = true;
            this.btnDownloadAllPrivilegs.Click += new System.EventHandler(this.btnDownloadAllPrivilegs_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 469);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(737, 240);
            this.dataGridView1.TabIndex = 121;
            // 
            // frmPrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 730);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDownloadAllPrivilegs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUploadAllPrivilegs);
            this.Controls.Add(this.btnDeleteOneUserPrivilege);
            this.Controls.Add(this.btnUpdateOneUserPrivilege);
            this.Controls.Add(this.btnClearAllPrivileges);
            this.Name = "frmPrivilege";
            this.Text = "frmPrivilege";
            this.Load += new System.EventHandler(this.frmPrivilege_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDeactivate;
        private System.Windows.Forms.DateTimePicker dtpActivate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCardNO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteOneUserPrivilege;
        private System.Windows.Forms.Button btnUpdateOneUserPrivilege;
        private System.Windows.Forms.Button btnUploadAllPrivilegs;
        private System.Windows.Forms.Button btnClearAllPrivileges;
        private System.ComponentModel.BackgroundWorker bkUploadPrivileges;
        private System.Windows.Forms.Button btnDownloadAllPrivilegs;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}