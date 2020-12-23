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
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
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

        public DataTable getMeals(string date, int id)
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string query = "(SELECT res.createAt, dishes.name FROM dishes JOIN "
 + "(SELECT meal_has_dishes.dishes_id, res.createAt, res.id FROM meal_has_dishes JOIN "
 + "(SELECT meal.createAt, meal.id FROM meal WHERE meal.user_id = @id  AND "
       + "DATE(meal.createAt) = @d) res ON res.id = meal_has_dishes.meal_id) res "
       + "ON dishes.id = res.dishes_id) "
   + "UNION "
     + "(SELECT products.name, res.createAt FROM products JOIN "
   + "(SELECT meal_has_products.products_id, res.createAt FROM meal_has_products JOIN "
+ "(SELECT meal.createAt, meal.id FROM meal WHERE meal.user_id = @id  AND "
      + "DATE(meal.createAt) = @d) res ON meal_has_products.meal_id = res.id) res "
      + "ON res.products_id = products.id) "
      + "ORDER BY createAt; ";
            MySqlCommand command = new MySqlCommand(query, this.getConnection());
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("d", date);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable getWaterNeed(int id)
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `gender`, `weight` FROM `users` WHERE `id` = @id", this.getConnection());
            //Authorization.id.ToString() вместо 1
            command.Parameters.AddWithValue("@id", id);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable getWaterRes(int id)
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT SUM(typesofwaterportion.value) FROM drinkingwater "
 + "JOIN typesofwaterportion ON typesofwaterportion.id = drinkingwater.typesOfWaterPortion_id "
   + "WHERE DATE(drinkingwater.createAt) = '2020-11-20' AND drinkingwater.users_id = @id;", this.getConnection());
            
            command.Parameters.AddWithValue("@id", id);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable getMealPlan(int id)
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT valuesofcharactericstic.value, characteristics.name FROM mealplans "
 + "JOIN mealplans_has_valuesofcharactericstic ON mealplans_has_valuesofcharactericstic.mealPlans_id = mealplans.id "
 + "JOIN valuesofcharactericstic ON mealplans_has_valuesofcharactericstic.valuesOfCharactericstic_id = valuesofcharactericstic.id "
 + "JOIN characteristics ON characteristics.id = valuesofcharactericstic.characteristics_id "
 + "WHERE mealplans.users_id = @id AND createAt = (select MAX(createAt) from mealplans);", this.getConnection());
            //Authorization.id.ToString() вместо 1
            command.Parameters.AddWithValue("@id", id);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable getUser(string login, string password)
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `name` = @lU AND `password` = @pU", this.getConnection());
            command.Parameters.AddWithValue("pU", password);
            command.Parameters.AddWithValue("lU", login);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool saveMealPlan(int userId, int proteins, int fats, int carbs, int calories)
        {
            bool res_query;

            MySqlCommand command = new MySqlCommand("INSERT INTO mealplans(createAt, users_id) " +
                "VALUES (NOW(), @id);", this.getConnection());
            command.Parameters.AddWithValue("id", userId);

            this.openConnection();

            if (command.ExecuteNonQuery() == 1) res_query = true;
            else return false;

            if(proteins != 0)
            {
                MySqlCommand command_p1 = new MySqlCommand("INSERT INTO valuesofcharactericstic(value, characteristics_id, measurement_type_id) " +
                    "VALUES (@proteins, 1, 3);", this.getConnection());
                command_p1.Parameters.AddWithValue("proteins", proteins);
                if (command_p1.ExecuteNonQuery() != 1) return false;

                MySqlCommand command_p2 = new MySqlCommand("INSERT INTO mealplans_has_valuesofcharactericstic(mealPlans_id, valuesOfCharactericstic_id) " 
  + "VALUES((select MAX(id) from mealplans), (SELECT MAX(id) FROM valuesofcharactericstic));", this.getConnection());
                if (command_p2.ExecuteNonQuery() != 1) return false;
            }

            if(fats != 0)
            {
                MySqlCommand command_f1 = new MySqlCommand("INSERT INTO valuesofcharactericstic(value, characteristics_id, measurement_type_id) " +
                   "VALUES (@fats, 2, 3);", this.getConnection());
                command_f1.Parameters.AddWithValue("fats", fats);
                if (command_f1.ExecuteNonQuery() != 1) return false;

                MySqlCommand command_f2 = new MySqlCommand("INSERT INTO mealplans_has_valuesofcharactericstic(mealPlans_id, valuesOfCharactericstic_id) "
  + "VALUES((select MAX(id) from mealplans), (SELECT MAX(id) FROM valuesofcharactericstic));", this.getConnection());
                if (command_f2.ExecuteNonQuery() != 1) return false;
            }

            if (carbs != 0)
            {
                MySqlCommand command_c1 = new MySqlCommand("INSERT INTO valuesofcharactericstic(value, characteristics_id, measurement_type_id) " +
                   "VALUES (@carbs, 3, 3);", this.getConnection());
                command_c1.Parameters.AddWithValue("carbs", carbs);
                if (command_c1.ExecuteNonQuery() != 1) return false;

                MySqlCommand command_c2 = new MySqlCommand("INSERT INTO mealplans_has_valuesofcharactericstic(mealPlans_id, valuesOfCharactericstic_id) "
  + "VALUES((select MAX(id) from mealplans), (SELECT MAX(id) FROM valuesofcharactericstic));", this.getConnection());
                if (command_c2.ExecuteNonQuery() != 1) return false;
            }

            if (calories != 0)
            {
                MySqlCommand command_c1 = new MySqlCommand("INSERT INTO valuesofcharactericstic(value, characteristics_id, measurement_type_id) " +
                   "VALUES (@calories, 4, 3);", this.getConnection());
                command_c1.Parameters.AddWithValue("calories", calories);
                if (command_c1.ExecuteNonQuery() != 1) return false;

                MySqlCommand command_c2 = new MySqlCommand("INSERT INTO mealplans_has_valuesofcharactericstic(mealPlans_id, valuesOfCharactericstic_id) "
  + "VALUES((select MAX(id) from mealplans), (SELECT MAX(id) FROM valuesofcharactericstic));", this.getConnection());
                if (command_c2.ExecuteNonQuery() != 1) return false;
            }

            this.closeConnection();
            return res_query;
        }

        public DataTable getAllDishes()
        {
           DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT name FROM dishes;", this.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable getAllProducts()
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT name FROM products;", this.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }
}
