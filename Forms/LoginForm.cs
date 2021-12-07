using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using фотостудия.Forms;
using System.Drawing;

namespace фотостудия
{   
    public partial class LoginForm : Form
    {
        public static LoginForm Login2 { get; set; } // свойство
        private readonly List<Login> logins;
        private readonly DataBase _db;

        public LoginForm()
        {
            InitializeComponent();
            logins = new List<Login>();
            Login log1 = new Login("Admin", "111111");

            logins.Add(log1);
            Login2 = this; // текущий класс
            _db = new DataBase();
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //_db.FindClientByName();
                textBox2.Focus(); //переход (типо как табуляции)
                //button1_Click(sender, e);
            }
        }

     /*   private void FindLogin()
        {
            foreach (Login c in logins)
            {
                if (c.name == textBox1.Text)
                {
                    label1.Text = "Найдено";
                    return;
                }
            }
            label1.Text = "Не найдено";
        }*/

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

            // изменение 
      /*  public void Account(string name,string password)
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
            }*/
        }

		private void button1_Click(object sender, EventArgs e)
		{
            MainForm mf = new MainForm();
            mf.Show();

            if (logins[0].name == "Admin" && logins[0].password == "111111")
            {
                mf.label1.Text = "Вошёл";
            }
            else
            {
                mf.label1.Text = "Не вошёл";
            }

            Hide();

            Console.WriteLine($"{logins[0].name} {logins[0].password}");
		}


        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void TextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _db.FindClientByName();
                button1_Click(sender, e);
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Blue;
        }
    }
}
