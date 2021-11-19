﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace фотостудия
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Login> logins = new List<Login>();
            Login log1 = new Login("Admin", "1111111");
            logins.Add(log1);
        }


      
        public class DataBase {  
            
            private SqlConnection connection;


            private void Form1_Load(object sender, EventArgs e)
            {

            }


            private void button1_Click(object sender, EventArgs e)
            {
                FindClientByName();
            }

            private void FindClientByName()
            {
               /*  foreach (Login log in login)
                {
                    if (log.name == textBox1.Text)
                    {
                        login.Text = "Вошел";
                        return;
                    }
                }
                login.Text = "Нет такого";*/
            }

            private void textBox1_KeyUp(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    FindClientByName();
                }
            }

            public void Connect(Form form)
            {
                form.FormClosing += Disconnect;
                connection = new SqlConnection("Data Sourse=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\фотостудия\\PhotoStudio.mdf;Integrated Security=True");
                if (IsAvailable())
                {
                    connection.Open();
                }
            }
            private bool IsAvailable()
            {
                try
                {
                    connection.Open();
                    connection.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }

            private void Disconnect(object sender, FormClosingEventArgs e)
            {
                connection.Close();
            }

        }


        public class Login
        {
            public string name;
            public string password;

            public Login(string clientName, string clientPassword)
            {
                name = clientName;
                password = clientPassword;
            }

            public static void Add(Login name)
            {

            }

        public void Account(string name,string password)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\фотостудия\\Accounts.mdf;Integrated Security=True";
                conn.Open();


            }

        public bool LoginUser(string name, string password)
            {
                if (name.Length < 1 || password.Length < 1)
                    return false;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\фотостудия\\Accounts.mdf;Integrated Security=True";
                
                conn.Open();
                conn.Close();
                return true;
            }
        }
    }
}
