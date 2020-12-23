using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCalculator
{
    class Database
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=food");

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public bool registration(string name, string password, int gender, float weight, float height, int age)
        {
            bool res_query;

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`name`, `password`, `gender`, `weight`, `height`) VALUES (@name, @password, @age, @weigth, @height)", this.getConnection());
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@gender", gender);     
            command.Parameters.AddWithValue("@weigth", weight);
            command.Parameters.AddWithValue("@height", height);
            command.Parameters.AddWithValue("@age", age);

            this.openConnection();
            
            if (command.ExecuteNonQuery() == 1) res_query = true;
            else res_query = false;

            this.closeConnection();
            return res_query;
        }

        public bool checkLoginExist(string login, string password)
        {
            bool result;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `name` = @lU", this.getConnection());
            command.Parameters.AddWithValue("pU", login);
            command.Parameters.AddWithValue("lU", password);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) result = true;
            else result = false;

            return result;
        }
    }
}
