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
    public partial class ManageCategories: Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }
        void populate()
        {
            string conString = "server=localhost;uid=root;pwd=12345;database=inventory;";
            MySqlConnection con = new MySqlConnection(conString);
            {
                con.Open();
                string query = "Select * from categories";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CategoriesGV.DataSource = ds.Tables[0];
                con.Close();
            }
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
                string query = "Insert into categories values('" + CatIdTb.Text + "','" + CatNameTb.Text + "','" + DescriptionTb.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();                
                DataTable dt = new DataTable();
                dt.Load(reader);
                CategoriesGV.DataSource = dt;
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CatIdTb.Text == "")
            {
                MessageBox.Show("Enter the Category id");
            }
            else
            {
                string conString = "server=localhost;uid=root;pwd=12345;database=inventory;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                string query = "delete from categories where category_id = '" + CatIdTb.Text + "';";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Deleted Successfully");
                con.Close();
                populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
    
}
