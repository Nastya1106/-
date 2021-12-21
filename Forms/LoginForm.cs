using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using фотостудия.Forms;
using System.Drawing;
using System.Threading;
using фотостудия.DataBase;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace фотостудия
{   
    public partial class LoginForm : Form
    {
        public static LoginForm Login2 { get; set; } // свойство
        

        public LoginForm()
        {
            InitializeComponent();
            
            Login2 = this; // текущий класс

        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus(); //переход (типо как табуляции)

            }
        }
    
		private void button1_Click(object sender, EventArgs e)
		{

#if !DEBUG // игнорирование конфигурации во время debuga
            if(!Login())
                return;
#endif
			MainForm mf = new MainForm();
            mf.Show();
            Hide();

        }

  //      private bool Login()
		//{
		//	фотостудия.DataBase.DB db = new фотостудия.DataBase.DB();
  //          if (!db.Connect("photostudio"))
  //              return false;

  //          MySqlCommand c = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @username AND `password` = @password");
  //          c.Parameters.Add("@username", MySqlDbType.VarChar).Value=Encode(textBox1.Text);
  //          c.Parameters.Add("@password", MySqlDbType.VarChar).Value = Encode(textBox2.Text);
  //          var table = db.Select(c);

  //          if (table.Rows.Count > 0)
  //              return true;
  //          else
		//	{
  //              MessageBox.Show("Вы ввели неправильный логин или пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
  //              return false;
		//	}
  //      }

  ////      private string Encode(string original)
		//{
  //          using (SHA256 hash = SHA256.Create())
		//	{
  //              byte[] bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(original));
  //              StringBuilder sb = new StringBuilder();
  //              for (int i = 0; i < bytes.Length; i++)
  //                  sb.Append(bytes[i].ToString("x2"));
  //              return sb.ToString();
		//	} 
		//}

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void TextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
