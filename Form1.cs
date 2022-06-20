using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void start_service_Click(object sender, EventArgs e)
        {
            label1.ResetText();
            label1.BackColor = Color.Green;
            label1.Text = "логирование включена";

            //

            
        }

        private void end_service_Click(object sender, EventArgs e)
        {
            label1.ResetText();
            label1.BackColor = Color.Red;
            label1.Text = "логирование отключена";
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
