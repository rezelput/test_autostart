using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_autostart
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            notify.Click += notify_Click;
            notify.ContextMenuStrip = this.MenuStrip;
        }

       
        void notify_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            //Cleanup so that the icon will be removed when the application is closed
            notify.Visible = false;
        }

        private void start_service_Click(object sender, EventArgs e)
        {

            label1.ResetText();
            label1.BackColor = Color.Green;
            label1.Text = "логирование включена";

            //
            notify.BalloonTipText = "Служба включена";
            notify.ShowBalloonTip(12);
        }


        

        private void end_service_Click(object sender, EventArgs e)
        {
            label1.ResetText();
            label1.BackColor = Color.Red;
            label1.Text = "логирование отключена";


            notify.BalloonTipText = "Служба отключена";
            notify.ShowBalloonTip(12);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void exit_closemenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
