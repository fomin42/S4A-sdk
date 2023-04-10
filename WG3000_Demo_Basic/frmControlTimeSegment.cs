using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WG3000_COMM.Core;

namespace WG3000_Demo
{
    public partial class frmControlTimeSegment : Form
    {
        public frmControlTimeSegment()
        {
            InitializeComponent();
        }
        public wgMjController control; //正在处理的控制器

        private void frmControlTimeSegment_Load(object sender, EventArgs e)
        {

        }

        wgMjControllerTimeSegList controlTimeSegList;
        private void btnUploadAllControlTimeSegment_Click(object sender, EventArgs e)
        {
            if (this.controlTimeSegList != null)
            {
                if (control.UpdateControlTimeSegListIP(this.controlTimeSegList.ToByte()) > 0)//上传时段列表
                {
                    MessageBox.Show("Success\r\n");
                }
                else
                {
                    MessageBox.Show("failed\r\n");
                }
            }
            else
            {
                MessageBox.Show("failed\r\n");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (controlTimeSegList == null)
            {
                controlTimeSegList = new wgMjControllerTimeSegList();
            }
            MjControlTimeSeg mjCI = new MjControlTimeSeg();
            mjCI.ymdStart = this.dateTimePicker7.Value;
            mjCI.ymdEnd = this.dateTimePicker6.Value;
            mjCI.SegIndex = byte.Parse(this.comboBox57.Text.ToString());
            mjCI.TotalLimittedAccess = (byte)(this.numericUpDown10.Value);
            mjCI.LimittedMode = this.checkBox105.Checked ? 1 : 0;
            mjCI.nextSeg = byte.Parse(this.comboBox58.Text.ToString()); 
            mjCI.weekdayControl = 0;
            mjCI.weekdayControl += (byte)(this.checkBox98.Checked ? (1 << 0) : 0);
            mjCI.weekdayControl += (byte)(this.checkBox99.Checked ? (1 << 1) : 0);
            mjCI.weekdayControl += (byte)(this.checkBox100.Checked ? (1 << 2) : 0);
            mjCI.weekdayControl += (byte)(this.checkBox101.Checked ? (1 << 3) : 0);
            mjCI.weekdayControl += (byte)(this.checkBox102.Checked ? (1 << 4) : 0);
            mjCI.weekdayControl += (byte)(this.checkBox103.Checked ? (1 << 5) : 0);
            mjCI.weekdayControl += (byte)(this.checkBox104.Checked ? (1 << 6) : 0);
            mjCI.hmsStart1 = this.dateTimePicker8.Value;
            mjCI.hmsEnd1 = this.dateTimePicker9.Value;
            mjCI.hmsStart2 = this.dateTimePicker10.Value;
            mjCI.hmsEnd2 = this.dateTimePicker11.Value;
            mjCI.hmsStart3 = this.dateTimePicker12.Value;
            mjCI.hmsEnd3 = this.dateTimePicker13.Value;
            mjCI.LimittedAccess1 = (byte)(this.numericUpDown7.Value);
            mjCI.LimittedAccess2 = (byte)(this.numericUpDown8.Value);
            mjCI.LimittedAccess3 = (byte)(this.numericUpDown9.Value);
            this.listBox2.Items.Add(this.comboBox57.Text.ToString()+ " , " + System.BitConverter.ToString(mjCI.ToBytes()));
            controlTimeSegList.AddItem(mjCI);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.controlTimeSegList=null; 
            this.listBox2.Items.Clear();
        }

        private void btnClearAllTimeSeg_Click(object sender, EventArgs e)
        {
            controlTimeSegList = new wgMjControllerTimeSegList();
            if (control.UpdateControlTimeSegListIP(controlTimeSegList.ToByte()) > 0)//上传时段列表
            {
                MessageBox.Show("Success\r\n");
            }
            else
            {
                MessageBox.Show("failed\r\n");
            }
        }
    }
}
