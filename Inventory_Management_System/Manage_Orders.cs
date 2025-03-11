using MySql.Data.MySqlClient;
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
    public partial class Manage_Orders: Form
    {
        public Manage_Orders()
        {
            InitializeComponent();
        }
        void populate()
        {
            string conString = "server=localhost;uid=root;pwd=12345;database=inventory;";
            MySqlConnection con = new MySqlConnection(conString);
            {
                con.Open();
                string query = "Select * from customers";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGv.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void Manage_Orders_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderidTb.Text = CustomersGv.SelectedRows[0].Cells[0].Value.ToString();
           CustomeridTb.Text = CustomersGv.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
