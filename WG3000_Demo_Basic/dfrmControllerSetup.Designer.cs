namespace WG3000_Demo
{
    partial class dfrmControllerSetup
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
            this.grpbIP = new System.Windows.Forms.GroupBox();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.txtSN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtControllerIP = new System.Windows.Forms.TextBox();
            this.label123 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpbIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSN)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbIP
            // 
            this.grpbIP.Controls.Add(this.nudPort);
            this.grpbIP.Controls.Add(this.txtSN);
            this.grpbIP.Controls.Add(this.label1);
            this.grpbIP.Controls.Add(this.txtControllerIP);
            this.grpbIP.Controls.Add(this.label123);
            this.grpbIP.Controls.Add(this.label124);
            this.grpbIP.Location = new System.Drawing.Point(26, 12);
            this.grpbIP.Name = "grpbIP";
            this.grpbIP.Size = new System.Drawing.Size(481, 61);
            this.grpbIP.TabIndex = 105;
            this.grpbIP.TabStop = false;
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(397, 20);
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
            this.txtSN.Location = new System.Drawing.Point(45, 20);
            this.txtSN.Maximum = new decimal(new int[] {
            499999999,
            0,
            0,
            0});
            this.txtSN.Minimum = new decimal(new int[] {
            100000001,
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
            this.txtControllerIP.Location = new System.Drawing.Point(208, 20);
            this.txtControllerIP.Name = "txtControllerIP";
            this.txtControllerIP.Size = new System.Drawing.Size(116, 21);
            this.txtControllerIP.TabIndex = 0;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label123.Location = new System.Drawing.Point(365, 24);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(35, 12);
            this.label123.TabIndex = 6;
            this.label123.Text = "PORT:";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label124.Location = new System.Drawing.Point(182, 24);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(23, 12);
            this.label124.TabIndex = 4;
            this.label124.Text = "IP:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(156, 88);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 106;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(275, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 106;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dfrmControllerSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 123);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpbIP);
            this.Name = "dfrmControllerSetup";
            this.Text = "ControllerSetup";
            this.grpbIP.ResumeLayout(false);
            this.grpbIP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbIP;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtControllerIP;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.NumericUpDown nudPort;
        public System.Windows.Forms.NumericUpDown txtSN;
    }
}