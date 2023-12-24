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
//using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HotelBooking
{
    public partial class Search : Form
    {
        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\UOV\Year 2\VP\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30;";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();

        public Search()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool idSearchselelcted = radioButtonID.Checked;
            bool nameSearchselelcted = radioButtonName.Checked;
            bool phoneNoSearchselelcted = radioButtonPhone.Checked;
            conn.ConnectionString = CONNECTION_STRING;
            SqlCommand cmd = new SqlCommand();
            string textToSearch = textBoxSearch.Text.ToString();
            if (idSearchselelcted)
            {
                MessageBox.Show("Identity search selected!");

                // cmd.CommandText = "SELECT * FROM customerDetails WHERE identityNo ='" +textToSearch + "'";
                adpt = new SqlDataAdapter("SELECT * FROM customer_table WHERE idNo = '" + textToSearch + "'", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridViewSearchResult.DataSource = dt;
            }
            else if (nameSearchselelcted)
            {
                MessageBox.Show("Name search selected!");
                try
                {
                    adpt = new SqlDataAdapter("SELECT * FROM customer_table WHERE customerName = '" + textToSearch + "'", conn);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridViewSearchResult.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (phoneNoSearchselelcted)
            {
                MessageBox.Show("Phone search selected!");
                adpt = new SqlDataAdapter("SELECT * FROM customer_table WHERE phoneNo = %'" + textToSearch + "'%", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridViewSearchResult.DataSource = dt;
            }

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home g = new Home();
            g.Show();
        }

        private void linkLabelGallery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Gallery g = new Gallery();
            g.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Gallery g = new Gallery();
            g.Show();
        }
    }
}
