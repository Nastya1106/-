using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace фотостудия
{
    public class DataBase
    {
        private SqlConnection connection;


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            FindClientByName();
        }

        public void FindClientByName()
        {
            /* foreach (Login log in log)
              {
                  if (log.name == textBox1.Text)
                  {
                      login.Text = "Вошел";
                      return;
                  }
              }
              login.Text = "Нет такого";*/
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
}
