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
using System.Data;

namespace Hotel_Booking_System
{
    public partial class Search : Form
    {
        //private string CONNECTION_STRING = "";
        //SqlDataAdapter adpt;
        //DataTable dt;
        //SqlConnection conn = new SqlConnection();

        public Search()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool idSearchselelcted = radioButtonID.Checked;
            bool nameSearchselelcted = radioButtonName.Checked;
            bool phoneNoSearchselelcted = radioButtonPhone.Checked;
            //conn.ConnectionString = CONNECTION_STRING;
            //SqlCommand cmd = new SqlCommand();
            //string textToSearch = textBoxSearch.Text.ToString();
            if (idSearchselelcted)
            {
                MessageBox.Show("Identity search selected!");

                // cmd.CommandText = "SELECT * FROM customerDetails WHERE identityNo ='" +textToSearch + "'";
                adpt = new SqlDataAdapter("SELECT * FROM customerDetails WHERE identityNo = '" + textToSearch + "'", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridViewSearchResult.DataSource = dt;
            }
            else if(nameSearchselelcted)
            {
                MessageBox.Show("Name search selected!");
                try
                {
                    adpt = new SqlDataAdapter("SELECT * FROM customerDetails WHERE customerName = '" + textToSearch + "'", conn);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridViewSearchResult.DataSource = dt;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ex.Message");
                }
            }
            else if(phoneNoSearchselelcted)
            {
                MessageBox.Show("Phone search selected!");
                adpt = new SqlDataAdapter("SELECT * FROM customerDetails WHERE customerPhone = %'" + textToSearch + "'%", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridViewSearchResult.DataSource = dt;
            }

        }

       
    }
}
