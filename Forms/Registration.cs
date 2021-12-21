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
using фотостудия.DataBase;

namespace фотостудия.Forms
{
	public partial class Registration : Form
	{
		public Registration()
		{
			InitializeComponent();
		}
		DB db = new DB();
		private MySqlConnection connection;

		private bool Register(string login, string password, string email)
		{
			bool flag = false;
			//фотостудия.DataBase.DB db = new фотостудия.DataBase.DB();
			//if (!db.Connect("photostudio"))
			//	return false;

			MySqlCommand c = new MySqlCommand("INSERT INTO users (Login, Password, Email) VALUE (@Login, @Password, @Email)", connection);
			c.Parameters.AddWithValue("@Login", login);
			c.Parameters.AddWithValue("@Password", password);
			c.Parameters.AddWithValue("@Email", email);
			connection.Open();

			if(c.ExecuteNonQuery() == 1)
			{
				flag = true;
			}
			connection.Close();
			return flag;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Register(textBox3.Text, textBox2.Text, textBox1.Text);

		}
	}
}
