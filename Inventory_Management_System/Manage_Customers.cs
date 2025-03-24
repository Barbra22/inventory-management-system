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
    public partial class Manage_Customers : Form
    {
        public Manage_Customers()
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
                CustomersGV.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void Manage_Customers_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddData();
        }
        public void AddData()
        {

            {
                string conString = "server=localhost;uid=root;pwd=12345;database=inventory;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                string query = "Insert into customers values('" + CustomeridTb.Text + "','" + NameTb.Text + "','" + EmailTb.Text + "','" + PhoneTb.Text + "','" + AddressTb.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                CustomersGV.DataSource = dt;
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CustomeridTb.Text == "")
            {
                MessageBox.Show("Enter the customer id");
            }
            else
            {
                string conString = "server=localhost;uid=root;pwd=12345;database=inventory;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                string query = "delete from customers where customer_id = '" + CustomeridTb.Text + "';";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Deleted Successfully");
                con.Close();
                populate();
            }
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomeridTb.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            NameTb.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
            NameTb.Text = CustomersGV.SelectedRows[0].Cells[2].Value.ToString();
            EmailTb.Text = CustomersGV.SelectedRows[0].Cells[3].Value.ToString();
            PhoneTb.Text = CustomersGV.SelectedRows[0].Cells[4].Value.ToString();
            AddressTb.Text = CustomersGV.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
