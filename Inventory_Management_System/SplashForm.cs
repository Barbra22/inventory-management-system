using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class SplashForm: Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer5.Start();
        }
        int startpoint = 0;

        private void timer5_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Progress.Value= 0;
            if (Progress.Value == 0)
            {
                {
                    Progress.Value = 0;
                    timer5.Stop();
                    Home login = new Home();
                    this.Hide();
                    login.Show();
                }


            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {

        }

        private void timer7_Tick(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
