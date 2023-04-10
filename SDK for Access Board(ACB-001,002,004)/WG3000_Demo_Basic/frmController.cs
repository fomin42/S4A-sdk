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
    public partial class frmController : Form
    {
        public frmController()
        {
            InitializeComponent();
        }

        //修改控制器设置
        private void btnChange_Click(object sender, EventArgs e)
        {
            using (dfrmControllerSetup dfrm = new dfrmControllerSetup())
            {
                dfrm.txtSN.Value = this.txtSN.Value;
                dfrm.txtControllerIP.Text = this.txtControllerIP.Text;
                dfrm.nudPort.Value = this.nudPort.Value;

                if (dfrm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    this.txtSN.Value = dfrm.txtSN.Value;
                    this.txtControllerIP.Text = dfrm.txtControllerIP.Text;
                    this.nudPort.Value = dfrm.nudPort.Value;

                    wgMjController1.ControllerSN = (int)this.txtSN.Value;
                    wgMjController1.IP = this.txtControllerIP.Text;
                    wgMjController1.PORT = (int)this.nudPort.Value;
                }
            }
        }

        wgMjController wgMjController1 = new wgMjController();  //此窗体使用的控制器

        private void frmController_Load(object sender, EventArgs e)
        {
            this.btnChange.PerformClick(); //指定控制器

            //加载配置
            wgMjController1.ControllerSN = (int)this.txtSN.Value;
            wgMjController1.IP = this.txtControllerIP.Text;
            wgMjController1.PORT = (int)this.nudPort.Value;
        }

        //清空信息栏
        private void btnClearInfo_Click(object sender, EventArgs e)
        {
            this.txtInfo.Text = "";
        }

        //appError 故障详细说明
        public const int ERRBIT_PARAM = 0;  //参数表
        public const int ERRBIT_DATAFLASH = 1;  //DataFlash
        public const int ERRBIT_REALCLOCK = 2;  //时钟 2010-3-31 09:47:33
        public static string ErrorDetail(int errNo)
        {
            string retStr = "";
            if ((errNo & (1 << ERRBIT_PARAM)) > 0)
            {
                retStr += "参数表"; // "Param"
            }
            if ((errNo & (1 << ERRBIT_DATAFLASH)) > 0)
            {
                retStr += " " + "存储"; // "DFLASH"
            }
            if ((errNo & (1 << ERRBIT_REALCLOCK)) > 0)
            {
                retStr += " " + "时钟"; //"RealClock"
            }
            return retStr;
        }

        //appWarn 报警详细说明
        public const int WARNBIT_FORCE = 0;	            //胁迫
        public const int WARNBIT_DOOROPENTOOLONG = 1;	//门打开时间过长
        public const int WARNBIT_DOORINVALIDOPEN = 2;	//门未刷卡打开
        public const int WARNBIT_FORCECLOSE = 3;	    //紧急双闭
        public const int WARNBIT_DOORINVALIDREAD = 4;	//不能开门的刷卡[非法刷卡]
        public const int WARNBIT_FIRELINK = 5;	        //消防联动
        public const int WARNBIT_ALARM = 6;	            //用于标识防盗报警(报警源为0,1,2)
        public static string WarnDetail(int warnNo)
        {
            string retStr = "";
            if ((warnNo & (1 << WARNBIT_FORCE)) > 0)
            {
                retStr += "-" + "胁迫报警"; //"Threate Code"
            }
            if ((warnNo & (1 << WARNBIT_DOOROPENTOOLONG)) > 0)
            {
                retStr += "-" + "正常开门时间过长报警"; //"Open Too Long"
            }
            if ((warnNo & (1 << WARNBIT_DOORINVALIDOPEN)) > 0)
            {
                retStr += "-" + "强行闯入报警"; //"Forced Open"
            }
            if ((warnNo & (1 << WARNBIT_FORCECLOSE)) > 0)
            {
                retStr += "-" + "强制锁门"; //"Forced Lock"
            }
            if ((warnNo & (1 << WARNBIT_DOORINVALIDREAD)) > 0)
            {
                retStr += "-" + "无效刷卡"; //"Invalid Card Swiping"
            }
            if ((warnNo & (1 << WARNBIT_FIRELINK)) > 0)
            {
                retStr += "-" + "火警"; //"Fire Alarm"
            }

            if ((warnNo & (1 << WARNBIT_ALARM)) > 0)
            {
                retStr += "-" + "防盗";//"ARM"
            }
            return retStr;
        }

        //读取运行信息
        private void btnReadRunInfo_Click(object sender, EventArgs e)
        {
            if (wgMjController1.GetMjControllerRunInformationIP()>0) //取控制器信息
            {
                this.txtInfo.AppendText("Success\r\n");
                this.txtInfo.AppendText(string.Format("电脑时间:  \t{0}\r\n",  
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff") + "[星期 " + DateTime.Now.DayOfWeek.ToString() + "]"));
                this.txtInfo.AppendText(string.Format("控制器SN:  \t{0}\r\n" , wgMjController1.RunInfo.CurrentControllerSN.ToString()));
                this.txtInfo.AppendText(string.Format("驱动版本:  \t{0}\r\n" , wgMjController1.RunInfo.driverVersion)); 
                this.txtInfo.AppendText(string.Format("控制器的实时时钟: \t{0}\r\n", 
                    wgMjController1.RunInfo.dtNow.ToString("yyyy-MM-dd HH:mm:ss") + "[星期 " + wgMjController1.RunInfo.weekday.ToString() + "]"));

                this.txtInfo.AppendText(string.Format("故障号: {0:d}\r\n", wgMjController1.RunInfo.appError));
                if (wgMjController1.RunInfo.appError > 0)
                {
                    this.txtInfo.AppendText(string.Format("故障: {0}\r\n", ErrorDetail(wgMjController1.RunInfo.appError)));
                }
                this.txtInfo.AppendText(string.Format("报警代号--1号门: {0:d}\r\n", wgMjController1.RunInfo.WarnInfo(1)));
                if (wgMjController1.RunInfo.WarnInfo(1) > 0)
                {
                    this.txtInfo.AppendText(string.Format("报警: {0}\r\n",WarnDetail( wgMjController1.RunInfo.WarnInfo(1))));
                }
                this.txtInfo.AppendText(string.Format("报警代号--2号门: {0:d}\r\n", wgMjController1.RunInfo.WarnInfo(2)));
                if (wgMjController1.RunInfo.WarnInfo(2) > 0)
                {
                    this.txtInfo.AppendText(string.Format("报警: {0}\r\n", WarnDetail(wgMjController1.RunInfo.WarnInfo(2))));
                }
                this.txtInfo.AppendText(string.Format("报警代号--3号门: {0:d}\r\n", wgMjController1.RunInfo.WarnInfo(3)));
                if (wgMjController1.RunInfo.WarnInfo(3) > 0)
                {
                    this.txtInfo.AppendText(string.Format("报警: {0}\r\n", WarnDetail(wgMjController1.RunInfo.WarnInfo(3))));
                }
                this.txtInfo.AppendText(string.Format("报警代号--4号门: {0:d}\r\n", wgMjController1.RunInfo.WarnInfo(4)));
                if (wgMjController1.RunInfo.WarnInfo(4) > 0)
                {
                    this.txtInfo.AppendText(string.Format("报警: {0}\r\n", WarnDetail(wgMjController1.RunInfo.WarnInfo(4))));
                }

                this.txtInfo.AppendText(string.Format("未提取记录数: {0:d}\r\n", wgMjController1.RunInfo.newRecordsNum)); 

                this.txtInfo.AppendText(string.Format("有效注册卡数: {0}\r\n", wgMjController1.RunInfo.registerCardNum));

                this.txtInfo.AppendText("\r\n");

                //门磁
                this.txtInfo.AppendText(string.Format("1号门磁状态: {0}\r\n", (wgMjController1.RunInfo.IsOpen(1)) ? "     门开" : "门关"));
                this.txtInfo.AppendText(string.Format("2号门磁状态: {0}\r\n", (wgMjController1.RunInfo.IsOpen(2)) ? "     门开" : "门关"));
                this.txtInfo.AppendText(string.Format("3号门磁状态: {0}\r\n", (wgMjController1.RunInfo.IsOpen(3)) ? "     门开" : "门关"));
                this.txtInfo.AppendText(string.Format("4号门磁状态: {0}\r\n", (wgMjController1.RunInfo.IsOpen(4)) ? "     门开" : "门关"));
                   
                this.txtInfo.AppendText("\r\n");

                //按钮
                this.txtInfo.AppendText(string.Format("1号按钮: {0}\r\n", (wgMjController1.RunInfo.PushButtonActive(1)) ? "     动作" : "未动作"));
                this.txtInfo.AppendText(string.Format("2号按钮: {0}\r\n", (wgMjController1.RunInfo.PushButtonActive(2)) ? "     动作" : "未动作"));
                this.txtInfo.AppendText(string.Format("3号按钮: {0}\r\n", (wgMjController1.RunInfo.PushButtonActive(3)) ? "     动作" : "未动作"));
                this.txtInfo.AppendText(string.Format("4号按钮: {0}\r\n", (wgMjController1.RunInfo.PushButtonActive(4)) ? "     动作" : "未动作"));

                this.txtInfo.AppendText("\r\n");

                //锁的继电器动作
                this.txtInfo.AppendText(string.Format("1号门锁: {0}\r\n", (wgMjController1.RunInfo.LockRelayActive(1)) ? "     动作" : "未动作"));
                this.txtInfo.AppendText(string.Format("2号门锁: {0}\r\n", (wgMjController1.RunInfo.LockRelayActive(2)) ? "     动作" : "未动作"));
                this.txtInfo.AppendText(string.Format("3号门锁: {0}\r\n", (wgMjController1.RunInfo.LockRelayActive(3)) ? "     动作" : "未动作"));
                this.txtInfo.AppendText(string.Format("4号门锁: {0}\r\n", (wgMjController1.RunInfo.LockRelayActive(4)) ? "     动作" : "未动作"));

                this.txtInfo.AppendText("\r\n");
                    
                //强制锁门 火警
                this.txtInfo.AppendText(string.Format("强制锁门: \t{0}\r\n", (wgMjController1.RunInfo.ForceLockIsActive) ? "     动作" : "未动作"));
                this.txtInfo.AppendText(string.Format("火警: \t{0}\r\n", (wgMjController1.RunInfo.FireIsActive) ? "     动作" : "未动作"));
            }
            else
            {
                this.txtInfo.AppendText("failed\r\n");
            }
        }

        //远程开门
        private void btnRemoteOpenDoor_Click(object sender, EventArgs e)
        {
           if ( wgMjController1.RemoteOpenDoorIP((int)this.numericUpDown1.Value) >0)
           {
               this.txtInfo.AppendText("Success\r\n");
           }
           else
           {
               this.txtInfo.AppendText("failed\r\n");
           }
        }

        //以电脑时间校准控制器
        private void btnSetControllerDateTime_Click(object sender, EventArgs e)
        {
            if (wgMjController1.AdjustTimeIP(DateTime.Now) > 0)
            {
                this.txtInfo.AppendText("Success\r\n");
            }
            else
            {
                this.txtInfo.AppendText("failed\r\n");
            }
        }

        //读取控制器时间
        private void btnReadControllerDateTime_Click(object sender, EventArgs e)
        {
            if (wgMjController1.GetMjControllerRunInformationIP()>0)
            {
                this.txtInfo.AppendText("Success\r\n");
                this.txtInfo.AppendText(wgMjController1.RunInfo.dtNow.ToString("控制器时间: yyyy-MM-dd HH:mm:ss\t") + "[星期" + wgMjController1.RunInfo.weekday.ToString() + "]\r\n");
            }
            else
            {
                this.txtInfo.AppendText("failed\r\n");
            }
        }

 
        //线程中显示信息
        private delegate void txtInfoHaveNewInfo(string info);
        private void txtInfoHaveNewInfoEntry(string info)
        {
            this.txtInfo.AppendText(info);
        }

        //更新新的数据源
        private delegate void dataGridViewNewData(DataTable dt);
        private void dataGridViewNewDataEntry(DataTable dt)
        {
            this.dataGridView1.DataSource = dt;
        }

        //修改控制器参数[简单处理]--详细的请参考 "控制参数管理"
        private void btnControllerParameter_Click(object sender, EventArgs e)
        {
            wgMjControllerConfigure controlConfigure = new wgMjControllerConfigure();
            
            //门控制方式  默认3=在线, 2=常闭, 1=常开 0=不受控
            controlConfigure.DoorControlSet(1, this.comboBox51.SelectedIndex); 
            controlConfigure.DoorControlSet(2, this.comboBox52.SelectedIndex);
            controlConfigure.DoorControlSet(3, this.comboBox53.SelectedIndex);
            controlConfigure.DoorControlSet(4, this.comboBox54.SelectedIndex); 

            //开门延时 默认3秒
            controlConfigure.DoorDelaySet(1, (int)this.numericUpDown11.Value);  
            controlConfigure.DoorDelaySet(2, (int)this.numericUpDown12.Value);
            controlConfigure.DoorDelaySet(3, (int)this.numericUpDown13.Value);
            controlConfigure.DoorDelaySet(4, (int)this.numericUpDown14.Value);
            
            if (wgMjController1.UpdateConfigureIP(controlConfigure) > 0)
            {
                this.txtInfo.AppendText("Success\r\n");
            }
            else
            {
                this.txtInfo.AppendText("failed\r\n");
            }

        }

        //清空所有控制时段
        private void btnClearAllTimeSeg_Click(object sender, EventArgs e)
        {
            wgMjControllerTimeSegList controlTimeSegList;
            controlTimeSegList = new wgMjControllerTimeSegList();
            if (wgMjController1.UpdateControlTimeSegListIP(controlTimeSegList.ToByte()) > 0)//上传时段列表
            {
                this.txtInfo.AppendText("Success\r\n");
            }
            else
            {
                this.txtInfo.AppendText("failed\r\n");
            }
        }

        #region 刷卡记录操作 使用后台线程进行提取操作#####################################################
        //提取记录的操作
        private void btnGetAllSwipeRecords_Click(object sender, EventArgs e)
        {
            if (this.bkGetRecords.IsBusy)
            {
                return;
            }
            this.bkGetRecords.RunWorkerAsync();
        }

        //提取记录的后台线程
        private void bkGetRecords_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            DataTable dtSwipeRecord;
            dtSwipeRecord = new DataTable("SwipeRecord");
            dtSwipeRecord.Columns.Add("f_Index",System.Type.GetType("System.UInt32"));//记录索引位
            dtSwipeRecord.Columns.Add("f_ReadDate",  System.Type.GetType("System.DateTime"));  //刷卡日期时间
            dtSwipeRecord.Columns.Add("f_CardNO",System.Type.GetType("System.UInt32"));  //用户卡号
            dtSwipeRecord.Columns.Add("f_DoorNO", System.Type.GetType("System.UInt32"));  //门号
            dtSwipeRecord.Columns.Add("f_InOut", System.Type.GetType("System.UInt32"));// =0表示出门;  =1 表示进门
            dtSwipeRecord.Columns.Add("f_ReaderNO", System.Type.GetType("System.UInt32")); // 读卡器号
            dtSwipeRecord.Columns.Add("f_EventCategory", System.Type.GetType("System.UInt32")); // 事件类型
            dtSwipeRecord.Columns.Add("f_ReasonNo", System.Type.GetType("System.UInt32"));// 硬件原因
            dtSwipeRecord.Columns.Add("f_ControllerSN", System.Type.GetType("System.UInt32"));// 控制器序列号
            dtSwipeRecord.Columns.Add("f_RecordAll",System.Type.GetType("System.String")); // 完整记录值
            
            int num = -1;
            using (wgMjControllerSwipeOperate swipe4GetRecords = new wgMjControllerSwipeOperate())
            {
                swipe4GetRecords.Clear(); //2010-12-10 16:46:03 清空
                num = swipe4GetRecords.GetSwipeRecords(wgMjController1.ControllerSN, wgMjController1.IP, wgMjController1.PORT, ref dtSwipeRecord);
            }
            if (num >= 0)
            {
                if (num == 0)
                {
                    this.Invoke(new txtInfoHaveNewInfo(txtInfoHaveNewInfoEntry), "记录为空\r\n"); //
                }
                else
                {
                    //this.dataGridView1.DataSource = dtSwipeRecord;
                    this.Invoke(new  dataGridViewNewData(dataGridViewNewDataEntry),dtSwipeRecord );
                    this.Invoke(new txtInfoHaveNewInfo(txtInfoHaveNewInfoEntry), string.Format("记录数={0:d}\r\n",num)); //
                    wgMjControllerSwipeRecord mjrec = new wgMjControllerSwipeRecord();
                    string recInfo = "";
                    for (int i = 0; i < num; i++)
                    {
                        mjrec.Update(dtSwipeRecord.Rows[i]["f_RecordAll"] as string); //用新的记录进行更新
                        recInfo = "";
 
                        recInfo += "\r\nCardNO = " + mjrec.CardID.ToString(); //只显示卡号, 详细信息可以通过ToDisplaySimpleInfo获取
                        this.Invoke(new txtInfoHaveNewInfo(txtInfoHaveNewInfoEntry), recInfo); //
                    }
                    //显示最后一条记录的详细信息
                    recInfo ="\r\n" + mjrec.ToDisplaySimpleInfo(true); //
                    this.Invoke(new txtInfoHaveNewInfo(txtInfoHaveNewInfoEntry), recInfo); //

                }
            }
            e.Result = num; 

            // If the operation was canceled by the user, 
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending)
            {
                wgMjControllerSwipeOperate.StopGetRecord(); //停止提取记录的操作
                e.Cancel = true;
            }
        }


         //恢复已提取的所有记录
        private void btnRestoreSwipe_Click(object sender, EventArgs e)
        {
            if (wgMjController1.RestoreAllSwipeInTheControllersIP() > 0)
            {
                this.txtInfo.AppendText("Success\r\n");
            }
            else
            {
                this.txtInfo.AppendText("failed\r\n");
            }

        }
        #endregion 刷卡记录操作结束######################################################################

        //实时监控界面
        frmWatching frmWatching1 = null;
        private void btnWatching_Click(object sender, EventArgs e)
        {
            frmWatching1 = new frmWatching();
            frmWatching1.controller = wgMjController1; //2011-4-7 13:20:23当前指定的控制器
            frmWatching1.Show(this);
        }

        //搜索控制器
        dfrmNetControllerConfig dfrmNetControllerConfig1 = null;
        private void btnSearchControllers_Click(object sender, EventArgs e)
        {
            dfrmNetControllerConfig1 = new dfrmNetControllerConfig();
            dfrmNetControllerConfig1.Show(this);
        }

        //注册卡权限管理
        frmPrivilege frmPrivilege1 = null;
        private void btnRegisterCardManage_Click(object sender, EventArgs e)
        {
            frmPrivilege1 = new frmPrivilege();
            frmPrivilege1.control = wgMjController1;
            frmPrivilege1.Text = frmPrivilege1.Text + "--" + wgMjController1.ControllerSN.ToString();
            frmPrivilege1.Show(this);
        }

        //控制时段管理
        frmControlTimeSegment frmControlTimeSegment1 = null;
        private void btnControlTimeSegManagement_Click(object sender, EventArgs e)
        {
            frmControlTimeSegment1 = new frmControlTimeSegment();
            frmControlTimeSegment1.control = wgMjController1;
            frmControlTimeSegment1.Text = frmControlTimeSegment1.Text + "--" + wgMjController1.ControllerSN.ToString();
            frmControlTimeSegment1.Show(this);
        }

        //窗体关闭事件
        private void frmController_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form frm in this.OwnedForms) //关闭相关窗体
            {
                if (frm != null)
                {
                    frm.Close();
                }
            }
        }

        /// <summary>
        /// 格式化控制器 请慎用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFormat_Click(object sender, EventArgs e)
        {
            if (wgMjController1.FormatIP() > 0)
            {
                //通过看控制器灯确认[Err红灯亮, 绿灯闪烁快]
                this.txtInfo.AppendText("指令已发出 Success\r\n"); 
            }
            else
            {
                this.txtInfo.AppendText("failed\r\n");
            }
        }

        /// <summary>
        /// 读取控制器参数 [只显示部分处理]
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetControllerParameter_Click(object sender, EventArgs e)
        {
            wgMjControllerConfigure conf = new wgMjControllerConfigure();
            if (wgMjController1.GetConfigureIP(ref conf) > 0)
            {
                this.txtInfo.AppendText("Success\r\n");
                //门控制方式  默认3=在线, 2=常闭, 1=常开 0=不受控",
                switch (conf.DoorControlGet(1))
                {
                    case 0:
                this.txtInfo.AppendText(string.Format("1号门控制方式:{0}\r\n", "不受控"));
                        break;
                    case 1:
                this.txtInfo.AppendText(string.Format("1号门控制方式:{0}\r\n", "常开"));
                        break;
                    case 2:
                this.txtInfo.AppendText(string.Format("1号门控制方式:{0}\r\n", "常闭"));
                        break;
                    case 3:
                this.txtInfo.AppendText(string.Format("1号门控制方式:{0}\r\n", "在线"));
                        break;
                    default:
                        break;
                }
                this.txtInfo.AppendText(string.Format("1号门开门延时:{0}\r\n", conf.DoorDelayGet(1).ToString()));

                //!!!!!其他参数可以依据需要进行查看 ................
                //**************************************************
                //.............................................
            }
            else
            {
                this.txtInfo.AppendText("failed\r\n");
            }
        }

 
    }
}
