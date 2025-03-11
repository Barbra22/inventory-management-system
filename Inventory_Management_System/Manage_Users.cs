using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using MySql.Data.MySqlClient;
namespace Inventory_Management_System
{
    public partial class Manage_Users : Form
    {
        public Manage_Users()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void populate()
        {
            string conString = "server=localhost;uid=root;pwd=12345;database=inventory;";
            MySqlConnection con = new MySqlConnection(conString);
            {
                con.Open();
                string query = "Select * from users";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];
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
                string query = "Insert into users values('" + Useridtb.Text + "','" + Usernametb.Text + "','" + Emailtb.Text + "','" + Passwordtb.Text + "','" + Roletb.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                UsersGV.DataSource = dt;
                populate();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Useridtb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            Usernametb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            Emailtb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            Passwordtb.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
            Roletb.Text = UsersGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Manage_Users_Load(object sender, EventArgs e)
        {
            populate();
        }
               private void button3_Click(object sender, EventArgs e)
        {
            if (Usernametb.Text == "")
            {
                MessageBox.Show("Enter the user name");
            }
            else
            {
                string conString = "server=localhost;uid=root;pwd=12345;database=inventory;";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                string query = "delete from users where username = '" + Usernametb.Text + "';";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Deleted Successfully");
                con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}