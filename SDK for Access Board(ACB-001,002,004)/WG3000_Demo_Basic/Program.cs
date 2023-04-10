using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WG3000_COMM.Core;
using System.Runtime.Remoting;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;

namespace WG3000_Demo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        
        [STAThread]
        static void Main(string[] cmdArgs)   
        {
            System.IO.Directory.SetCurrentDirectory(Application.StartupPath); //设定当前的运行目录
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WG3000_Demo.frmController());  
            return;
        } //Main
         
 

    }//Program
}
