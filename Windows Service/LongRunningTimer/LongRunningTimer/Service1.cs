using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace LongRunningTimer
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Task taskA = Task.Factory.StartNew(() => TaskMethod());
            Thread.Sleep(5000);
            Task taskB = Task.Factory.StartNew(() => TaskMethod2());            
        }

        protected override void OnStop()
        {
        }

        protected static void TaskMethod()
        {
            string path = @"C:\temp\test.txt";
            while (true)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("wakes up 1 " + DateTime.Now.ToString());
                }
                Thread.Sleep(30000);
            }
        }

        protected static void TaskMethod2()
        {
            string path = @"C:\temp\test.txt";
            while (true)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("wakes up 2 " + DateTime.Now.ToString());
                }
                Thread.Sleep(30000);
            }
        }
    }
}
