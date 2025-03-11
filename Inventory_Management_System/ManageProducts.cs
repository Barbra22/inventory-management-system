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
    public partial class ManageProducts: Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }
        void populate()
        {
            string conString = "server=localhost;uid=root;pwd=12345;database=inventory;";
            MySqlConnection con = new MySqlConnection(conString);
            {
                con.Open();
                string query = "Select * from products";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageProducts_Load(object sender, EventArgs e)
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
                string query = "Insert into products values('" + ProductidTb.Text + "','" + NameTb.Text + "','" + DescriptionTb.Text + "','" + CategoryidTb.Text + "','" + MeasureTb.Text + "','" + SupplierTb.Text + "','" + StockTb.Text + "','" + PurchaseTb.Text + "','" + SellingTb.Text + "','" + MinStockTb.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                ProductsGV.DataSource = dt;
               populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ProductidTb.Text == "")
            {
                MessageBox.Show("Enter the customer id");
            }
            else
            {
                string conString = "server=localhost;uid=root;pwd=12345;database=inventory;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                string query = "delete from products where product_id = '" + ProductidTb.Text + "';";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Deleted Successfully");
                con.Close();
                populate();
            }
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryidTb.Text = ProductsGV.SelectedRows[0].Cells[0].Value.ToString();
            NameTb.Text = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            DescriptionTb.Text = ProductsGV.SelectedRows[0].Cells[2].Value.ToString();
            CategoryidTb.Text =ProductsGV.SelectedRows[0].Cells[3].Value.ToString();
            MeasureTb.Text = ProductsGV.SelectedRows[0].Cells[4].Value.ToString();
            SupplierTb.Text = ProductsGV.SelectedRows[0].Cells[5].Value.ToString();
            StockTb.Text = ProductsGV.SelectedRows[0].Cells[5].Value.ToString();
            PurchaseTb.Text = ProductsGV.SelectedRows[0].Cells[5].Value.ToString();
            SellingTb.Text = ProductsGV.SelectedRows[0].Cells[5].Value.ToString();
            MinStockTb.Text = ProductsGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
