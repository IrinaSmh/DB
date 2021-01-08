using MySql.Data.MySqlClient;
using System;
using System.Data;

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

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`name`, `password`, `gender`, `weight`, `height`, `age`) VALUES (@name, @password, @age, @weigth, @height, @age)", this.getConnection());
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
     + "(SELECT res.createAt, products.name FROM products JOIN "
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

            command.Parameters.AddWithValue("@id", id);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable getWaterRes(int id, string date)
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT SUM(typesofwaterportion.value) FROM drinkingwater "
 + "JOIN typesofwaterportion ON typesofwaterportion.id = drinkingwater.typesOfWaterPortion_id "
   + "WHERE DATE(drinkingwater.createAt) = @d AND drinkingwater.users_id = @id;", this.getConnection());
            
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@d", date);

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

        public bool saveProductInMeal(int userId, string nameProduct, string quantity, string type)
        {
            int typeId = -1;
            if (type == "шт") typeId = 1;
            if (type == "г") typeId = 2;
            if (type == "ч.л.") typeId = 4;
            if (type == "ст.л.") typeId = 5;
            if (type == "стакан") typeId = 6;

            bool res_query;
            MySqlCommand command1 = new MySqlCommand("INSERT INTO meal(createAt, user_id) " +
                "VALUES (NOW(), @id);" + " select last_insert_id();", this.getConnection());
            command1.Parameters.AddWithValue("id", userId);

            this.openConnection();

            int mealId = Convert.ToInt32(command1.ExecuteScalar());

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM products WHERE name = @n;", this.getConnection());
            command2.Parameters.AddWithValue("n", nameProduct);
            int productId = (int)command2.ExecuteScalar();

            MySqlCommand command3 = new MySqlCommand("INSERT INTO meal_has_products(meal_id, products_id, quantity, measurementtype_id) " +
    "VALUES (@mI, @dI, @q, @mTI);", this.getConnection());
            command3.Parameters.AddWithValue("mI", mealId);
            command3.Parameters.AddWithValue("dI", productId);
            command3.Parameters.AddWithValue("q", quantity);
            command3.Parameters.AddWithValue("mTI", typeId);

            if (command3.ExecuteNonQuery() == 1) res_query = true;
            else res_query = false;

            this.closeConnection();
            return res_query;
        }


        public bool saveDishInMeal(int userId, string nameDish)
        {
            bool res_query;
            MySqlCommand command1 = new MySqlCommand("INSERT INTO meal(createAt, user_id) " +
                "VALUES (NOW(), @id);" + " select last_insert_id();", this.getConnection());
            command1.Parameters.AddWithValue("id", userId);

            this.openConnection();

            int mealId = Convert.ToInt32(command1.ExecuteScalar());

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM dishes WHERE name = @n;", this.getConnection());
            command2.Parameters.AddWithValue("n", nameDish);
            int dishId = (int)command2.ExecuteScalar();

            MySqlCommand command3 = new MySqlCommand("INSERT INTO meal_has_dishes(meal_id, dishes_id) " +
    "VALUES (@mI, @dI);", this.getConnection());
            command3.Parameters.AddWithValue("mI", mealId);
            command3.Parameters.AddWithValue("dI", dishId);

            if (command3.ExecuteNonQuery() == 1) res_query = true;
            else res_query = false;

            this.closeConnection();
            return res_query;
        }

        public int getCharsUserMeal(int userId, string charType, string date)
        {
            int charId = -1;
            if (charType == "белки") charId = 1;
            if (charType == "жиры") charId = 2;
            if (charType == "углеводы") charId = 3;
            if (charType == "калории") charId = 4;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT SUM(res.result) FROM" +
                "(SELECT SUM(res.result) AS result FROM " +
"(SELECT valuesofcharactericstic.value, dishes_has_products.quantity, dishes_has_products.measurementtype_id, " +
"CASE " +
    "WHEN dishes_has_products.measurementtype_id = 2 " +
    "THEN(dishes_has_products.quantity / 100) * (valuesofcharactericstic.value) " +
    "ELSE(dishes_has_products.quantity) * (valuesofcharactericstic.value) " +
"END AS result " +
 "FROM valuesofcharactericstic " +
"JOIN products_has_valuesofcharactericstic " +
"ON products_has_valuesofcharactericstic.valuesOfCharactericstic_id = valuesofcharactericstic.id " +
"JOIN dishes_has_products ON products_has_valuesofcharactericstic.products_id = dishes_has_products.products_id " +
"JOIN meal_has_dishes ON meal_has_dishes.dishes_id = dishes_has_products.dishes_id " +
"JOIN meal ON meal.id = meal_has_dishes.meal_id WHERE meal.user_id = @id AND " +
"DATE(meal.createAt) = @d AND valuesofcharactericstic.characteristics_id = @cI) res " +
"UNION " +
"SELECT SUM(res.result) AS result FROM" +
"(SELECT valuesofcharactericstic.value, meal_has_products.quantity, meal_has_products.measurementtype_id, " +
"CASE " +
   "WHEN meal_has_products.measurementtype_id = 2 " +
   "THEN(meal_has_products.quantity / 100) * (valuesofcharactericstic.value) " +
   "ELSE(meal_has_products.quantity) * (valuesofcharactericstic.value) " +
"END AS result " +
"FROM valuesofcharactericstic " +
"JOIN products_has_valuesofcharactericstic ON products_has_valuesofcharactericstic.valuesOfCharactericstic_id = valuesofcharactericstic.id " +
"JOIN meal_has_products ON meal_has_products.products_id = products_has_valuesofcharactericstic.products_id " +
"JOIN meal ON meal.id = meal_has_products.meal_id WHERE meal.user_id = @id AND DATE(meal.createAt) = @d " +
"AND valuesofcharactericstic.characteristics_id = @cI) res) res; "
, this.getConnection());

            command.Parameters.AddWithValue("@id", userId);
            command.Parameters.AddWithValue("@d", date);
            command.Parameters.AddWithValue("@cI", charId);

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows[0].ItemArray[0] == DBNull.Value) return 0;
            else
                return Convert.ToInt32(table.Rows[0].ItemArray[0]);
        }

        public bool addWaterPortion(string date, int userId, int typeOfPortion)
        {
            bool res_query;
            MySqlCommand command = new MySqlCommand("INSERT INTO drinkingwater(createAt, users_id, typesOfWaterPortion_id) " +
                "VALUES (@d, @i, @tOP);", this.getConnection());
            command.Parameters.AddWithValue("@d", date);
            command.Parameters.AddWithValue("@i", userId);
            command.Parameters.AddWithValue("@tOP", typeOfPortion);

            this.openConnection();
            if (command.ExecuteNonQuery() == 1) res_query = true;
            else res_query = false;

            this.closeConnection();
            return res_query;
        }

        public string getOftenEatingProduct(int userId)
        {
            string res_query;
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT name FROM "
+"(SELECT  name, MAX(count) AS max, username, user_id FROM "
+"( "
+"SELECT id AS meal_id, user_id, name, COUNT(name) AS count, username FROM "
+"(SELECT meal.id, products.name, users.name AS username, users.id AS user_id FROM products "
+"JOIN dishes_has_products ON dishes_has_products.products_id = products.id "
+"JOIN dishes ON dishes_has_products.dishes_id = dishes.id "
+"JOIN `measurement type` ON dishes_has_products.measurementtype_id = `measurement type`.id "
+"JOIN meal_has_dishes ON meal_has_dishes.dishes_id = dishes.id  "
+"JOIN meal ON meal_has_dishes.meal_id = meal.id "
+"JOIN users ON meal.user_id = users.id "
+    "UNION "
+"SELECT meal.id, products.name, users.name as username, users.id AS user_id FROM products "
+"JOIN meal_has_products ON meal_has_products.products_id = products.id "
+"JOIN meal ON meal_has_products.meal_id = meal.id "
+"JOIN users ON meal.user_id = users.id) as prod GROUP by name, username ORDER BY username, count DESC "
+") res GROUP BY username) res WHERE res.user_id = @id; ", this.getConnection());
            command.Parameters.AddWithValue("@id", userId);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table != null)
            {
                try { res_query = table.Rows[0].ItemArray[0].ToString(); }
                catch (System.IndexOutOfRangeException e)
                {
                    res_query = "такого продукта еще нет";
                    return res_query;
                }
               
            }
            else res_query = "такого продукта еще нет";
            return res_query;
        }

        public DataTable getCharOfDish(string name)
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT SUM(calories) ,SUM(proteins), SUM(fats), SUM(carbohydrates) FROM " +
"(SELECT valuesofcharactericstic.value, dishes_has_products.quantity, dishes_has_products.measurementtype_id, valuesofcharactericstic.characteristics_id, " +
"CASE " +
        "WHEN dishes_has_products.measurementtype_id = 2 AND valuesofcharactericstic.characteristics_id = 4 " +
        "THEN(dishes_has_products.quantity / 100) * (valuesofcharactericstic.value) " +
        "WHEN dishes_has_products.measurementtype_id = 1 AND valuesofcharactericstic.characteristics_id = 4 " +
        "THEN(dishes_has_products.quantity) * (valuesofcharactericstic.value) " +
        "ELSE 0 " +

    "END AS calories, " +
    "CASE " +

        "WHEN dishes_has_products.measurementtype_id = 2 AND valuesofcharactericstic.characteristics_id = 1 " +

        "THEN(dishes_has_products.quantity / 100) * (valuesofcharactericstic.value) " +
        "WHEN dishes_has_products.measurementtype_id = 1 AND valuesofcharactericstic.characteristics_id = 1 " +

        "THEN(dishes_has_products.quantity) * (valuesofcharactericstic.value) " +
        "ELSE 0 " +

    "END AS proteins, " +
    "CASE " +

        "WHEN dishes_has_products.measurementtype_id = 2 AND valuesofcharactericstic.characteristics_id = 2 " +

        "THEN(dishes_has_products.quantity / 100) * (valuesofcharactericstic.value) " +
        "WHEN dishes_has_products.measurementtype_id = 1 AND valuesofcharactericstic.characteristics_id = 2 " +

        "THEN(dishes_has_products.quantity) * (valuesofcharactericstic.value) " +
        "ELSE 0 " +

    "END AS fats, " +
    "CASE " +

        "WHEN dishes_has_products.measurementtype_id = 2 AND valuesofcharactericstic.characteristics_id = 3 " +

        "THEN(dishes_has_products.quantity / 100) * (valuesofcharactericstic.value) " +
        "WHEN dishes_has_products.measurementtype_id = 1 AND valuesofcharactericstic.characteristics_id = 3 " +

        "THEN(dishes_has_products.quantity) * (valuesofcharactericstic.value) " +
        "ELSE 0 " +

    "END AS carbohydrates " +
 "FROM valuesofcharactericstic " +
"JOIN products_has_valuesofcharactericstic ON products_has_valuesofcharactericstic.valuesOfCharactericstic_id = valuesofcharactericstic.id " +
"JOIN dishes_has_products ON products_has_valuesofcharactericstic.products_id = dishes_has_products.products_id " +
"JOIN dishes ON dishes.id = dishes_has_products.dishes_id " +
"WHERE dishes.name = @name) res;", this.getConnection());
            command.Parameters.AddWithValue("@name", name);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable getStuctureOfDish(string name)
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT name AS meas_type_name, product_name, quantity FROM `measurement type` JOIN "
 +"(SELECT name AS product_name, quantity, measurementtype_id FROM products JOIN "
 +"(SELECT products_id, quantity, measurementtype_id FROM dishes_has_products JOIN "
 +"(SELECT id FROM dishes WHERE name = @n) "
 +"res ON id = dishes_id) "
 +"res ON id = products_id) "
 +"res ON measurementtype_id = id; ", this.getConnection());
            command.Parameters.AddWithValue("n", name);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable getCharOfProduct(string name)
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT characteristics.name AS char_name, "
   +"valuesofcharactericstic.value, `measurement type`.name AS mesurement_type_name "
    +"FROM valuesofcharactericstic "
   +" JOIN products_has_valuesofcharactericstic "
       +" ON valuesofcharactericstic.id = products_has_valuesofcharactericstic.valuesOfCharactericstic_id "
   +" JOIN products ON products.id = products_has_valuesofcharactericstic.products_id "
   +" JOIN characteristics ON valuesofcharactericstic.characteristics_id = characteristics.id "
    +"JOIN `measurement type` ON `measurement type`.id = valuesofcharactericstic.measurement_type_id WHERE products.name = @n; ", this.getConnection());
            command.Parameters.AddWithValue("n", name);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable getTypeOfProduct(string name)
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT typesofproduct.name FROM typesofproduct "
    +"JOIN products ON products.typesOfProduct_id = typesofproduct.id "
    +"WHERE products.name = @n; ", this.getConnection());
            command.Parameters.AddWithValue("n", name);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool updateName(string value, int userId)
        {
            bool res_query;
            MySqlCommand command = new MySqlCommand("UPDATE users SET name = @v WHERE id = @i; ", this.getConnection());
            command.Parameters.AddWithValue("v", value);
            command.Parameters.AddWithValue("i", userId);
            this.openConnection();
            if (command.ExecuteNonQuery() == 1) res_query = true;
            else res_query = false;
            this.closeConnection();
            return res_query;
        }

        public bool updateWeight(string value, int userId)
        {
            bool res_query;
            MySqlCommand command = new MySqlCommand("UPDATE users SET weight = @v WHERE id = @i; ", this.getConnection());
            command.Parameters.AddWithValue("v", value);
            command.Parameters.AddWithValue("i", userId);
            this.openConnection();
            if (command.ExecuteNonQuery() == 1) res_query = true;
            else res_query = false;
            this.closeConnection();
            return res_query;
        }

        public bool updateAge(string value, int userId)
        {
            bool res_query;
            MySqlCommand command = new MySqlCommand("UPDATE users SET age = @v WHERE id = @i; ", this.getConnection());
            command.Parameters.AddWithValue("v", value);
            command.Parameters.AddWithValue("i", userId);
            this.openConnection();
            if (command.ExecuteNonQuery() == 1) res_query = true;
            else res_query = false;
            this.closeConnection();
            return res_query;
        }

        public bool updateHeight(string value, int userId)
        {
            bool res_query;
            MySqlCommand command = new MySqlCommand("UPDATE users SET height = @v WHERE id = @i; ", this.getConnection());
            command.Parameters.AddWithValue("v", value);
            command.Parameters.AddWithValue("i", userId);
            this.openConnection();
            if (command.ExecuteNonQuery() == 1) res_query = true;
            else res_query = false;
            this.closeConnection();
            return res_query;
        } 

        public bool deleteLastMeal(int userId)
        {
            bool res_query;
            MySqlCommand command = new MySqlCommand("DELETE FROM meal WHERE user_id = @i ORDER BY id DESC LIMIT 1;", this.getConnection());
            command.Parameters.AddWithValue("i", userId);
            this.openConnection();
            if (command.ExecuteNonQuery() == 1) res_query = true;
            else res_query = false;
            this.closeConnection();
            return res_query;
        }
    }
}
