using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WG3000_COMM.Core;
using System.Collections;
//using WG3000_COMM.DataOper;

namespace WG3000_Demo
{
    public partial class frmWatching : Form
    {
        public frmWatching()
        {
            InitializeComponent();
        }

        static int receivedPktCount = 0;
        Queue QueRecText = new Queue(); 
        private void evtNewInfoCallBack(string text)
        {
           System.Diagnostics.Debug.WriteLine("Got text through callback! {0}", text);
            receivedPktCount++;
            lock (QueRecText.SyncRoot)
            {
                QueRecText.Enqueue(text);  //加入到文件中
            }
        }


        wgWatchingService watching; //实时监控服务
        wgMjController wgMjControllerWatching = null; //2011-11-15_23:50:42 要监控的控制器
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.dgvControllers.RefreshEdit(); 
            if (this.dgvControllers.Rows.Count <= 0)
            {
                return;
            }
            this.btnStart.Enabled = false;
            if (watching == null)
            {
                watching = new wgWatchingService();  //加载监视服务
                watching.EventHandler += new OnEventHandler(evtNewInfoCallBack); //事件处理
            }
            this.timerUpdateDoorInfo.Enabled = false;  //停止刷新
            Cursor.Current = Cursors.WaitCursor; //2010-11-11 14:42:33 
            
            //选定要监控的控制表
            Dictionary<int, wgMjController> selectedControllers = new Dictionary<int, wgMjController>();

            foreach (DataGridViewRow dgvr in this.dgvControllers.Rows )
            {
                if (dgvr.Cells["f_ControllerSN"].Value != null)
                {
                    int sn;
                    if (int.TryParse(dgvr.Cells["f_ControllerSN"].Value.ToString(), out  sn))
                    {
                        wgMjControllerWatching = new wgMjController(); //Create New 
                        wgMjControllerWatching.ControllerSN = sn; 
                        if (dgvr.Cells["f_IP"].Value != null)
                        {
                            wgMjControllerWatching.IP = dgvr.Cells["f_IP"].Value.ToString(); 
                        }
                        int port;
                        if (dgvr.Cells["f_Port"].Value != null)
                        {
                            if (int.TryParse(dgvr.Cells["f_Port"].Value.ToString(), out port))
                            {
                                wgMjControllerWatching.PORT = port; 
                            }
                        }
                        selectedControllers.Add(wgMjControllerWatching.ControllerSN, wgMjControllerWatching);
                    }
                }
            }
            if (selectedControllers.Count > 0)
            {
               System.Diagnostics.Debug.WriteLine ("selectedControllers.Count=" + selectedControllers.Count.ToString());
                watching.WatchingController = selectedControllers;

                this.timerUpdateDoorInfo.Interval = 300; 
                this.timerUpdateDoorInfo.Enabled = true;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("selectedControllers.Count=" + selectedControllers.Count.ToString());
                watching.WatchingController = null;
                this.timerUpdateDoorInfo.Enabled = false;
 
            }
            Cursor.Current = Cursors.Default; //2010-11-11 14:42:33 
        }

        //用于定时更新门的信息  实时监控时
        private void timerUpdateDoorInfo_Tick(object sender, EventArgs e)
        {
            this.timerUpdateDoorInfo.Enabled = false;
            if (watching != null)
            {
                updateControllerStatus();
                if (QueRecText.Count > 0)
                {
                    this.Invoke(new txtInfoHaveNewInfo(txtInfoHaveNewInfoEntry)); //2010-8-1 09:09:12
                }
                Application.DoEvents();//2010-8-1 09:09:06 显示
                this.timerUpdateDoorInfo.Enabled = true; //2010-11-11 12:00:43 下次执行
            }
        }

        /// <summary>
        /// 获取控制器信息并更新显示列表
        /// </summary>
        void updateControllerStatus()  
        {
            if (watching != null)
            {
                foreach (DataGridViewRow dgvr in this.dgvControllers.Rows)
                {
                    if (dgvr.Cells["f_ControllerSN"].Value != null)
                    {
                        int sn;
                        if (int.TryParse(dgvr.Cells["f_ControllerSN"].Value.ToString(), out  sn))
                        {
                            wgMjControllerRunInformation conRunInfo=null;
                            int commStatus;
                            commStatus = watching.CheckControllerCommStatus(sn, ref conRunInfo);
                            if (commStatus == -1)
                            {
                                ////实时监控 超过3秒后 仍未通信上, 则提示未连接
                                    dgvr.Cells["f_Status"].Value = "failed";
                                    dgvr.Cells["f_Clock"].Value = "";
                            }
                            else if (commStatus == 1)
                            {
                                    dgvr.Cells["f_Status"].Value = "OK";
                                    dgvr.Cells["f_Clock"].Value = conRunInfo.dtNow.ToString("yyyy-MM-dd HH:mm:ss");
                            }
                        }
                    }
                }
                this.dgvControllers.Refresh();
            }
        }

        private delegate void txtInfoHaveNewInfo();
        static int dealingTxt = 0;
        static int infoRowsCount = 0;
        private void txtInfoHaveNewInfoEntry()
        {
            if (dealingTxt > 0)
            {
                return;
            }
            if (watching.WatchingController == null) //2010-8-1 08:27:15 没有选中监控的就退出
            {
                return;
            }
            System.Threading.Interlocked.Exchange(ref dealingTxt, 1);
            int dealt = 0;
            object obj;
            long startTicks = DateTime.Now.Ticks; // Date.Now.Ticks  'us
            long updateSpan = 2000 * 1000 * 10;
            long endTicks = startTicks + updateSpan; // '100毫微秒的倍数  '一个Ticks＝10亿分之一秒，一毫秒＝10000Ticks
            while (QueRecText.Count > 0)
            {
                lock (QueRecText.SyncRoot)
                {
                    obj = QueRecText.Dequeue();//取出
                }
                txtInfoUpdateEntry(obj);
                infoRowsCount++;
                dealt++;
                if (DateTime.Now.Ticks > endTicks)
                {
                    endTicks = DateTime.Now.Ticks + updateSpan;
                    if (watching.WatchingController == null)
                    {
                        break;
                    }
                }
            }
            Application.DoEvents();//显示
            System.Threading.Interlocked.Exchange(ref dealingTxt, 0);
        }

        private void txtInfoUpdateEntry(object info)
        {
            wgMjControllerSwipeRecord mjrec = new wgMjControllerSwipeRecord(info as string);
            if (mjrec.ControllerSN > 0)
            {
                //如果不处于监控的控制器 则不作数据处理
                try
                {
                    if (!watching.WatchingController.ContainsKey((int)mjrec.ControllerSN))
                    {
                        return; //不属于监控的控制器发出的信息 则返回
                    }
                }
                catch (Exception)
                {
                    return;
                }
                this.textBox1.AppendText(mjrec.ToDisplaySimpleInfo(true));
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //将所有的停止放在一个按钮上
            if (watching != null)
            {
                //停止实时监控
                watching.WatchingController = null;
                this.timerUpdateDoorInfo.Enabled = false;
            }
            System.Threading.Interlocked.Exchange(ref dealingTxt, 0); //2010-11-11 11:13:48允许下一次激活
            this.btnStart.Enabled = true;
            Cursor.Current = Cursors.Default; //2010-11-11 14:45:37 恢复正常
         }

        public wgMjController controller;  //

        DataTable dtController = null; //控制器表 
        private void frmWatching_Load(object sender, EventArgs e)
        {
            dtController = new DataTable("Controllers");
            dtController.Columns.Add("f_ControllerSN", System.Type.GetType("System.UInt32"));//控制器号
            dtController.Columns.Add("f_IP", System.Type.GetType("System.String"));//IP地址
            dtController.Columns.Add("f_Port", System.Type.GetType("System.UInt32"));//端口号
            dtController.Columns.Add("f_Status", System.Type.GetType("System.String")); //状态
            dtController.Columns.Add("f_Clock", System.Type.GetType("System.String")); //时钟

            this.dgvControllers.DataSource = dtController;

            if (controller != null) //2011-4-7 13:17:43 如果指定了控制器
            {
                DataRow dr = dtController.NewRow();
                dr["f_ControllerSN"] = (uint)controller.ControllerSN;
                dr["f_IP"] = controller.IP;
                dr["f_Port"] = controller.PORT;
                dtController.Rows.Add(dr);
                dtController.AcceptChanges();
            }
            else
            {
                this.btnAddController.PerformClick(); //增加一台控制器
            }
        }

        //clear controllers
        private void btnClear_Click(object sender, EventArgs e)
        {
             //清空控制器
            DataTable dt = this.dgvControllers.DataSource as DataTable ;
            if (dt != null)
            {
                dt.Rows.Clear();
            }
        }

        //add a controller
        private void btnAddController_Click(object sender, EventArgs e)
        {
            using (dfrmControllerSetup dfrm = new dfrmControllerSetup())
            {
                if (dfrm.ShowDialog(this) == DialogResult.OK)
                {
                    //加入控制器
                    DataTable dt = this.dgvControllers.DataSource as DataTable;
                    if (dt != null)
                    {
                        using (DataView dv = new DataView(dt))
                        {
                            dv.RowFilter = string.Format("f_ControllerSN = {0:d}", (uint)dfrm.txtSN.Value);
                            if (dv.Count == 0)
                            {
                                DataRow dr = dt.NewRow();
                                dr["f_ControllerSN"] = (uint)(dfrm.txtSN.Value);
                                dr["f_IP"] = dfrm.txtControllerIP.Text;
                                dr["f_Port"] = dfrm.nudPort.Value;
                                dt.Rows.Add(dr);
                                dt.AcceptChanges();
                            }
                        }
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           //将所有的停止放在一个按钮上
            if (watching != null)
            {
                //停止实时监控
                watching.WatchingController = null;
                this.timerUpdateDoorInfo.Enabled = false;
            }
            if (watching != null)
            {
                watching.StopWatch(); //2010-6-24 09:11:04 停止监控
            }
            this.Close();
        }

        //窗体已关闭事件
        private void frmWatching_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (watching != null)
            {
                watching.StopWatch(); //2010-6-24 09:11:04 停止监控
            }
        }

    }
}
