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

namespace FoodCalculator
{
    public partial class Main : Form
    {
        int rowCount = 1;
        public Main()
        {
            InitializeComponent();
            
            showMeals();
            showWaterNeed();
            showWaterRes();
            showMealPlan();
        }

       private void showMeals()
        {
           // string date = DateTime.Now.Date.ToShortDateString();
          
            Database db = new Database();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string query = "(SELECT res.createAt, dishes.name FROM dishes JOIN "
 + "(SELECT meal_has_dishes.dishes_id, res.createAt, res.id FROM meal_has_dishes JOIN "
 +"(SELECT meal.createAt, meal.id FROM meal WHERE meal.user_id = 1  AND "
       + "DATE(meal.createAt) = '2020-11-20') res ON res.id = meal_has_dishes.meal_id) res "
       + "ON dishes.id = res.dishes_id) "
   + "UNION "
     +"(SELECT products.name, res.createAt FROM products JOIN "
   + "(SELECT meal_has_products.products_id, res.createAt FROM meal_has_products JOIN "
+  "(SELECT meal.createAt, meal.id FROM meal WHERE meal.user_id = 1  AND "
      +  "DATE(meal.createAt) = '2020-11-20') res ON meal_has_products.meal_id = res.id) res "
      +  "ON res.products_id = products.id) "
      + "ORDER BY createAt; ";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            //command.Parameters.AddWithValue("pU", passwordUser);
            //command.Parameters.AddWithValue("lU", loginUser);

            adapter.SelectCommand = command;
            adapter.Fill(table);
            tableMealSettings();
            for (int i = 0; i < table.Rows.Count; i++)             
                {
                    if(i < 15)
                    {
                  
                        string o1 = table.Rows[i].ItemArray[0].ToString();
                        o1 = o1.Substring(10, 9);
                        string o2 = table.Rows[i].ItemArray[1].ToString();

                    addlabelToMealTable(o1, 0, i+1);
                    addlabelToMealTable(o2, 1, i + 1);
                }                  
                  //if you want to get the string
                    //string s = o = dt.Rows[i].ItemArray[j].ToString();
                }
        }


        private void addlabelToMealTable(String text, int col, int row)
        {
            Label label = new Label();
            label.Dock = DockStyle.Fill;
            label.Text = text;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            tableLayoutPanel2.Controls.Add(label, col, row);
            rowCount++;
        }

        private void addlabelToPlanTable(String text, int col, int row)
        {
            Label label = new Label();
            label.Dock = DockStyle.Fill;
            label.Text = text;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            tableLayoutPanel1.Controls.Add(label, col, row);
        }

        private void tableMealSettings()
        {
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(220, 95);
            this.tableLayoutPanel2.TabIndex = 0;
        }

        private void tablePlanSettings()
        {
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(100, 95);
            this.tableLayoutPanel1.TabIndex = 0;
        }

        private void showWaterNeed()
        {
            Database db = new Database();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `gender`, `weight` FROM `users` WHERE `id` = @id", db.getConnection());
            //Authorization.id.ToString() вместо 1
            command.Parameters.AddWithValue("@id",1);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            int result;
            if(table.Rows[0].ItemArray[0].ToString() == "1")
            {
                result = int.Parse(table.Rows[0].ItemArray[1].ToString())*35;
            } else result = int.Parse(table.Rows[0].ItemArray[1].ToString()) * 31;

            water_label.Text = "Нужное количество воды: " + result;
        }

        public void showWaterRes()
        {
            Database db = new Database();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT SUM(typesofwaterportion.value) FROM drinkingwater "
 + "JOIN typesofwaterportion ON typesofwaterportion.id = drinkingwater.typesOfWaterPortion_id "
   + "WHERE DATE(drinkingwater.createAt) = '2020-11-20' AND drinkingwater.users_id = @id;", db.getConnection());
            //Authorization.id.ToString() вместо 1
            command.Parameters.AddWithValue("@id", 1);

            adapter.SelectCommand = command;
            adapter.Fill(table);
            water_res.Text = "Выпитое количество воды: " + table.Rows[0].ItemArray[0].ToString();
        }

        public void showMealPlan()
        {
            tablePlanSettings();
            Database db = new Database();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT valuesofcharactericstic.value, characteristics.name FROM mealplans "
 + "JOIN mealplans_has_valuesofcharactericstic ON mealplans_has_valuesofcharactericstic.mealPlans_id = mealplans.id "
 + "JOIN valuesofcharactericstic ON mealplans_has_valuesofcharactericstic.valuesOfCharactericstic_id = valuesofcharactericstic.id "
 + "JOIN characteristics ON characteristics.id = valuesofcharactericstic.characteristics_id "
 + "WHERE mealplans.users_id = @id AND createAt = (select MAX(createAt) from mealplans);", db.getConnection());
            //Authorization.id.ToString() вместо 1
            command.Parameters.AddWithValue("@id", 1);

            adapter.SelectCommand = command;
            adapter.Fill(table);
                    string o1 = table.Rows[0].ItemArray[0].ToString();
            Console.WriteLine(o1);
            string o2 = table.Rows[0].ItemArray[1].ToString();
                Console.WriteLine(o2);

                if (o2 == "калории")
                {
                    addlabelToPlanTable(o1, 1,1);
                 
                }
                if (o2 == "белки")
                {
                    addlabelToPlanTable(o1, 2,1);
                   
                }
                if (o2 == "жиры")
                {
                    addlabelToPlanTable(o1, 3,1);
                   
                }
                if (o2 == "углеводы")
                {
                    addlabelToPlanTable(o1, 4,1);                
                }

        }

        private void addMealPlan_button_Click(object sender, EventArgs e)
        {
            AddMealPlan addMealPlan = new AddMealPlan();
            addMealPlan.Show();
        }
    }
}
