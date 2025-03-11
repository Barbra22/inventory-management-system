using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace Inventory_Management_System
{
    public partial class Form1: Form
    {
        string conString = "server=localhost;uid=root;pwd=12345;database=inventory;";
        
        public Form1()
        {
            InitializeComponent();
        }
       


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                PasswordTb.UseSystemPasswordChar = false;
            else
                PasswordTb.UseSystemPasswordChar = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from users where username='" + UnameTb.Text + "' and password_hash='" + PasswordTb.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Manage_Customers customers = new Manage_Customers();
                customers.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            con.Close();
        }
    }
}
