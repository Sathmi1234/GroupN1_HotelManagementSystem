﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;
//using System.Data.SqlClient;

namespace HotelBooking
{
    public partial class Login : Form
    {
        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\UOV\Year 2\VP\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30;";
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabelGallery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelTandC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("    Reservation Confirmation:\r\n        " +
                "All bookings are subject to availability and confirmation by the hotel.\r\n        " +
                "A valid credit/debit card is required to secure and confirm a reservation.\r\n\r\n    " +
                "Cancellation Policy:\r\n        " +
                "Cancellations must be made within the specified time frame to avoid charges.\r\n        " +
                "Late cancellations or no-shows may result in charges equivalent to the first night's stay.\r\n\r\n   " +
                " Check-In/Check-Out:\r\n        " +
                "Check-in time is 7a.m., and check-out time is 10p.m..\r\n        " +
                "Early check-in and late check-out are subject to availability and may incur additional charges.\r\n\r\n    " +
                "Payment:\r\n        " +
                "Payment is due upon arrival, unless otherwise specified during the booking process.\r\n        " +
                "Additional charges for services or amenities may apply and will be settled at check-out.\r\n\r\n    " +
                "Guest Responsibility:\r\n        " +
                "Guests are responsible for any damage to hotel property during their stay.\r\n        " +
                "The hotel reserves the right to charge the guest for any such damages.\r\n\r\n    " +
                "Pets and Smoking:\r\n        " +
                "Check with the hotel for its policy on pets and smoking, as these may vary.\r\n\r\n    " +
                "Privacy Policy:\r\n        " +
                "Personal information provided during the booking process will be handled in accordance with the hotel's privacy policy.\r\n\r\n    " +
                "Force Majeure:\r\n        " +
                "The hotel is not responsible for circumstances beyond its control, such as natural disasters, acts of terrorism, or other unforeseen events.\r\n\r\n    " +
                "Discretionary Policies:\r\n       " +
                "The hotel reserves the right to refuse service to anyone for any reason.\r\n        " +
                "Any disputes or discrepancies will be resolved at the discretion of the hotel management.\r\n\r\n" +
                "By completing a booking, guests acknowledge and agree to these terms and conditions. " +
                "The hotel reserves the right to modify these terms without prior notice."
                , "Terms and Conditions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabelAboutUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Welcome to Our Hotel, your premier destination for seamless and delightful travel experiences. " +
                "At Our Hotel, we understand that a comfortable and memorable stay begins with the booking process, and that's where we excel.\r\n\r\n" +
                "With a passion for simplifying travel planning, our platform offers a user-friendly interface that allows you to effortlessly browse, select, and book accommodations tailored to your preferences. " +
                "Whether you seek a luxurious getaway or a cozy retreat, we provide a diverse range of options to suit every traveler's needs.\r\n\r\n" +
                "Why Choose Our Hotel?\r\n\r\n" +
                "1. Extensive Selection:" +
                "\r\n\r\nExplore a curated collection of hotels, resorts, and guesthouses worldwide, ensuring you find the perfect place for your stay.\r\n\r\n" +
                "2. Ease of Booking:" +
                "\r\n\r\nOur intuitive booking system makes the reservation process quick and hassle-free, putting you in control of your travel plans.\r\n\r\n" +
                "3. Best Price Guarantee:" +
                "\r\n\r\nEnjoy peace of mind knowing that you're getting the best value for your money. Our system ensures competitive prices and exclusive deals.\r\n\r\n" +
                "4. Secure and Reliable:" +
                "\r\n\r\nTrust in a secure booking platform that prioritizes the confidentiality of your personal information and guarantees the reliability of your reservations.\r\n\r\n" +
                "5. 24/7 Customer Support:" +
                "\r\n\r\nOur dedicated support team is available around the clock to assist you with any queries or concerns, ensuring a smooth and enjoyable travel experience.\r\n\r\n" +
                "\r\nAt Our Hotel, we are committed to transforming your travel dreams into reality. Join us on a journey of convenience, reliability, and exceptional hospitality. " +
                "Book with confidence, and let us be the bridge to your next remarkable getaway.", "About Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("For inquiries, assistance, or to make a reservation, please feel free to contact our dedicated team:\r\n\r\n" +
                "Phone: +94 123456789\r\n\r\n" +
                "Email: hotel@gmail.com\r\n\r\n" +
                "Address: No:20,\r\n" +
                "               Abc Road,\r\n" +
                "               Colombo.\r\n\r\n" +
                "Our team is available from 7 a.m. to 9 p.m. to ensure your queries are promptly addressed. " +
                "We look forward to welcoming you to our hotel and making your stay memorable.\r\n", "Contact Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxfb_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text.ToString();
            string password = textBoxPassword.Text.ToString();
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                DialogResult dialogResult = MessageBox.Show("No empty fields allowed", "You cannot continue", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM user_table WHERE username ='" + username + "' AND password= '" + password + "' ";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("User found for id:" + reader.GetInt32(0).ToString(), "", MessageBoxButtons.OK);
                    }
                    this.Hide();
                    Home h = new Home();
                    h.Show();

                }
                else
                {
                    MessageBox.Show("Username or Password incorrect!");
                }
                //MessageBox.Show("Connection Success!");
                conn.Close();



            }
        }

        private void linkLabelHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();

        }
    }
}
