using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace test_autostart
{
    partial class Service1 : ServiceBase
    {

        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        private StreamWriter file;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Добавьте код для запуска службы.
            //Файл по умолчанию будет создан в   "C:\Winnt\System32\"
            file = new System.IO.StreamWriter(new FileStream("log_autoservice.log",
                                         System.IO.FileMode.Append));
            this.file.WriteLine("log_autoservice start");
            this.file.Flush();
        }

        protected override void OnStop()
        {
            // TODO: Добавьте код, выполняющий подготовку к остановке службы.
            this.file.WriteLine("log_autoservice stop");
            this.file.Flush();
            this.file.Close();
        }
    }
}
