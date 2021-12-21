using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace фотостудия.Forms
{
    public partial class MainForm : Form
    {
        public Form form { get; set; }

        public MainForm()
        {
            InitializeComponent();
            form = this;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm.Login2.Close();

        }


        private void button1_Click(object sender, EventArgs e)
		{
         
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

		private void button1_Click_1(object sender, EventArgs e)
		{
           LoginForm lg = new LoginForm();
           lg.Show();
           Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}



		// private void MainForm_Login();

	}
}
