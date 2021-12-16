using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace фотостудия.DataBase
{
	public class DB
	{
		private MySqlConnection _connection;

		public bool Connect(string database)
		{
			_connection = new MySqlConnection($"server=localhost;port=3306;username=root;password=root;database={database}");

			if(_connection.State == ConnectionState.Closed)
			{
				try 
				{
					_connection.Open();
				}
				catch (MySqlException)
				{
					MessageBox.Show("Невозможно подключиться к базе данных, так как произошло отключение сервера", "Ошибка - отключился сервер", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
					return false;
				}
			}
			return true;
		}
		public void Disconnect()
		{
			if (_connection.State == ConnectionState.Open)
				_connection.Close();
		}

		public void Execute(MySqlCommand c)
		{
			c.Connection = _connection;
			c.ExecuteNonQuery();
		}

		public DataTable Select(MySqlCommand c)
		{
			c.Connection = _connection;
			DataTable dt = new DataTable();
			MySqlDataAdapter msda = new MySqlDataAdapter();
			msda.SelectCommand = c;
			msda.Fill(dt);
			return dt;

		}
	}
}
