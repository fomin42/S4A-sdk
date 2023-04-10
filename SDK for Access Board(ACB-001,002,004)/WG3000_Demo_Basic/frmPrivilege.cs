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
    public partial class frmPrivilege : Form
    {
        public frmPrivilege()
        {
            InitializeComponent();
        }
        public wgMjController control;//正在处理的控制器
        private void btnClearAllPrivileges_Click(object sender, EventArgs e)
        {
            using (wgMjControllerPrivilege pri = new wgMjControllerPrivilege())
            {
                if (pri.ClearAllPrivilegeIP(control.ControllerSN, control.IP, control.PORT) >= 0)
                {
                    MessageBox.Show("Success\r\n");
                }
                else
                {
                    MessageBox.Show("failed\r\n");
                }
            }
        }

        private void frmPrivilege_Load(object sender, EventArgs e)
        {

        }

        //添加或修改单个用户权限
        private void btnUpdateOneUserPrivilege_Click(object sender, EventArgs e)
        {
            string s = this.txtCardNO.Text;
            UInt32 cardid;
            if (!UInt32.TryParse(s, System.Globalization.NumberStyles.Integer, null, out cardid))
            {
                MessageBox.Show("failed\r\n");
                return;
            }

            MjRegisterCard mjrc = new MjRegisterCard();

            //注册卡信息修改
            mjrc.CardID = cardid; //卡号 
            mjrc.Password = uint.Parse(this.txtPassword.Text); //密码
            mjrc.ymdStart = this.dtpActivate.Value;  //起始日期
            mjrc.ymdEnd = this.dtpDeactivate.Value;  //结束日期
            mjrc.ControlSegIndexSet(1, byte.Parse(comboBox1.Text)); //1号门时段
            mjrc.ControlSegIndexSet(2, byte.Parse(comboBox2.Text)); //2号门时段
            mjrc.ControlSegIndexSet(3, byte.Parse(comboBox3.Text)); //3号门时段
            mjrc.ControlSegIndexSet(4, byte.Parse(comboBox4.Text)); //4号门时段

            int ret = -1;
            using (wgMjControllerPrivilege pri = new wgMjControllerPrivilege())
            {
                ret = pri.AddPrivilegeOfOneCardIP(control.ControllerSN, control.IP, control.PORT, mjrc);

            }
            if (ret >= 0)
            {
                MessageBox.Show("Success\r\n");
            }
            else
            {
                MessageBox.Show("failed\r\n");
            }
        }

        private void btnDeleteOneUserPrivilege_Click(object sender, EventArgs e)
        {
            string s = this.txtCardNO.Text;
            UInt32 cardid;
            if (!UInt32.TryParse(s, System.Globalization.NumberStyles.Integer, null, out cardid))
            {
                MessageBox.Show("failed\r\n");
                return;
            }
            using (wgMjControllerPrivilege pri = new wgMjControllerPrivilege())
            {
                uint registerCardId = uint.Parse(this.txtCardNO.Text);            //指定注册卡卡号
                if (pri.DelPrivilegeOfOneCardIP(control.ControllerSN, control.IP, control.PORT, cardid) >= 0)
                {
                    MessageBox.Show("Success\r\n");
                }
                else
                {
                    MessageBox.Show("failed\r\n");
                }
            }
        }


        MjRegisterCard mjrcStart;
        private void btnUploadAllPrivilegs_Click(object sender, EventArgs e)
        {
            string s = this.txtCardNO.Text;
            UInt32 cardid;
            if (!UInt32.TryParse(s, System.Globalization.NumberStyles.Integer, null, out cardid))
            {
                MessageBox.Show("failed\r\n");
                return;
            }

            MjRegisterCard mjrc = new MjRegisterCard();

            //注册卡信息修改
            mjrc.CardID = cardid; //卡号 
            mjrc.Password = uint.Parse(this.txtPassword.Text); //密码
            mjrc.ymdStart = this.dtpActivate.Value;  //起始日期
            mjrc.ymdEnd = this.dtpDeactivate.Value;  //结束日期
            mjrc.ControlSegIndexSet(1, byte.Parse(comboBox1.Text)); //1号门时段
            mjrc.ControlSegIndexSet(2, byte.Parse(comboBox2.Text)); //2号门时段
            mjrc.ControlSegIndexSet(3, byte.Parse(comboBox3.Text)); //3号门时段
            mjrc.ControlSegIndexSet(4, byte.Parse(comboBox4.Text)); //4号门时段

            mjrcStart = mjrc;

            if (bkUploadPrivileges.IsBusy)
            {
                return;
            }
            bkUploadPrivileges.RunWorkerAsync();
        }

        //上传权限线程
        private void bkUploadPrivileges_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            int ret = -1;
            using (DataTable dtPrivilege = new DataTable("Privilege"))//权限表 
            {
                dtPrivilege.Columns.Add("f_CardNO", System.Type.GetType("System.UInt32"));//用户卡号
                dtPrivilege.Columns.Add("f_BeginYMD", System.Type.GetType("System.DateTime"));//用户起始日期
                dtPrivilege.Columns.Add("f_EndYMD", System.Type.GetType("System.DateTime"));//用户结束日期
                dtPrivilege.Columns.Add("f_PIN", System.Type.GetType("System.String")); //用户密码
                dtPrivilege.Columns.Add("f_ControlSegID1", System.Type.GetType("System.Byte"));//1号门时段
                dtPrivilege.Columns["f_ControlSegID1"].DefaultValue = 0;  //缺省值
                dtPrivilege.Columns.Add("f_ControlSegID2", System.Type.GetType("System.Byte"));//2号门时段
                dtPrivilege.Columns["f_ControlSegID2"].DefaultValue = 0;  //缺省值
                dtPrivilege.Columns.Add("f_ControlSegID3", System.Type.GetType("System.Byte"));//3号门时段
                dtPrivilege.Columns["f_ControlSegID3"].DefaultValue = 0;  //缺省值
                dtPrivilege.Columns.Add("f_ControlSegID4", System.Type.GetType("System.Byte"));//4号门时段
                dtPrivilege.Columns["f_ControlSegID4"].DefaultValue = 0;  //缺省值

                //添加2000个用户  卡号从指定的起始权限顺序递增
                //卡号从小到大 排序, 不要重复
                UInt32 lastCardNO = 0;
                DataRow dr;
                for (int i = 0; i < 2000; i++)
                {
                    dr = dtPrivilege.NewRow();
                    dr["f_CardNO"] = (UInt32)(mjrcStart.CardID + i); // (i); // 卡号
                    dr["f_BeginYMD"] = mjrcStart.ymdStart;
                    dr["f_EndYMD"] = mjrcStart.ymdEnd;
                    dr["f_PIN"] = mjrcStart.Password;     //要是合法数字才行
                    dr["f_ControlSegID1"] = mjrcStart.ControlSegIndexGet(1);   //1号门时段
                    dr["f_ControlSegID2"] = mjrcStart.ControlSegIndexGet(2);   //2号门时段
                    dr["f_ControlSegID3"] = mjrcStart.ControlSegIndexGet(3);   //3号门时段
                    dr["f_ControlSegID4"] = mjrcStart.ControlSegIndexGet(4);   //4号门时段

                    //要有序 且不重复
                    if ((UInt32)(dr["f_CardNO"]) <= lastCardNO)
                    {
                        MessageBox.Show("failed\r\n");
                        return;
                    }
                    else
                    {
                        lastCardNO = (UInt32)dr["f_CardNO"];
                        dtPrivilege.Rows.Add(dr);
                    }
                }
                dtPrivilege.AcceptChanges();

                //处理时要查权限表是否符合要求
                //不能用重复的卡号 这是关键点
                using (wgMjControllerPrivilege pri = new wgMjControllerPrivilege())
                {
                    pri.AllowUpload();
                    ret = pri.UploadIP(control.ControllerSN, control.IP, control.PORT, "DOOR NAME", dtPrivilege);
                }
            }
            if (ret >= 0)
            {
                MessageBox.Show("Success\r\n");
            }
            else
            {
                if (ret == -200)
                {
                    MessageBox.Show("failed:  dtPrivilege 卡没有按由小到大顺序排列\r\n");
                }
                else
                {
                    MessageBox.Show("failed\r\n");
                }
            }

            if (bw.CancellationPending)
            {
                wgMjControllerPrivilege.StopUpload();//停止权限的上传操作
                e.Cancel = true;
            }
        }

        DataTable dtPrivilegeDownload = null; //下载到的权限表
        private void btnDownloadAllPrivilegs_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;


            if (dtPrivilegeDownload != null)
            {
                dtPrivilegeDownload.Dispose();
            }
            dtPrivilegeDownload = new DataTable("Privilege");//权限表 
            dtPrivilegeDownload.Columns.Add("f_CardNO", System.Type.GetType("System.UInt32"));//用户卡号
            dtPrivilegeDownload.Columns.Add("f_BeginYMD", System.Type.GetType("System.DateTime"));//用户起始日期
            dtPrivilegeDownload.Columns.Add("f_EndYMD", System.Type.GetType("System.DateTime"));//用户结束日期
            dtPrivilegeDownload.Columns.Add("f_PIN", System.Type.GetType("System.String")); //用户密码
            dtPrivilegeDownload.Columns.Add("f_ControlSegID1", System.Type.GetType("System.Byte"));//1号门时段
            dtPrivilegeDownload.Columns["f_ControlSegID1"].DefaultValue = 0;  //缺省值
            dtPrivilegeDownload.Columns.Add("f_ControlSegID2", System.Type.GetType("System.Byte"));//2号门时段
            dtPrivilegeDownload.Columns["f_ControlSegID2"].DefaultValue = 0;  //缺省值
            dtPrivilegeDownload.Columns.Add("f_ControlSegID3", System.Type.GetType("System.Byte"));//3号门时段
            dtPrivilegeDownload.Columns["f_ControlSegID3"].DefaultValue = 0;  //缺省值
            dtPrivilegeDownload.Columns.Add("f_ControlSegID4", System.Type.GetType("System.Byte"));//4号门时段
            dtPrivilegeDownload.Columns["f_ControlSegID4"].DefaultValue = 0;  //缺省值

            int ret = -1;

            using (wgMjControllerPrivilege pri = new wgMjControllerPrivilege())
            {
                pri.AllowDownload();
                ret = pri.DownloadIP(control.ControllerSN, control.IP, control.PORT, "Door Name", ref dtPrivilegeDownload);
            }
            if (ret > 0)
            {
                if (dtPrivilegeDownload.Rows.Count >= 0)
                {
                    this.dataGridView1.DataSource = dtPrivilegeDownload;
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

            Cursor.Current = Cursors.Default;
        }

    }
}
