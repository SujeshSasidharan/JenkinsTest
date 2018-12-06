using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

            Process.Start(@"D:\Softwares\elasticsearch-5.6.5\elasticsearch-5.6.5\bin\elasticsearch.bat1");

        }

        protected override void OnStop()
        {

            // Store all running process in the system
            Process[] runingProcess = Process.GetProcesses();
            for (int i = 0; i < runingProcess.Length; i++)
            {
                // compare equivalent process by their name
                if (runingProcess[i].ProcessName == "java1234")
                {
                    // kill  running process
                    runingProcess[i].Kill();
                }

            }

        }
    }
}
