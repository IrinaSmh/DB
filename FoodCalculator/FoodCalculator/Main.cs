using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FoodCalculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
            showMeals();
            showWaterNeed();
            showWaterRes();
            showMealPlan();
            name_label.Text = Authorization.name;

            waterPortion_comboBox.Visible = false;
            waterPortion_comboBox.Items.Add("100 мл");
            waterPortion_comboBox.Items.Add("150 мл");
            waterPortion_comboBox.Items.Add("200 мл");           
            waterPortion_comboBox.Items.Add("270 мл");
            waterPortion_comboBox.Items.Add("250 мл");
            waterPortion_comboBox.Items.Add("300 мл");
            waterPortion_comboBox.Items.Add("500 мл");
            waterPortion_comboBox.Items.Add("1000 мл");

            oftenProd_label.Text = "Наиболее часто потребляемый\n продукт: " + getOftenProduct();
        }

        private string generationNowDate()
        {
            string date = DateTime.Now.Date.ToShortDateString();
            return date.Substring(6, 4) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
        }

        private void showMeals()
        {
            string newDate = generationNowDate();
        
          
            Database db = new Database();

        
            DataTable table = db.getMeals(newDate, Authorization.id);
            if (table != null)
            {
                tableMealSettings();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (i < 15)
                    {
                        string o1 = table.Rows[i].ItemArray[0].ToString();
                        if (o1.Length == 18)
                            o1 = o1.Substring(10, 8);
                        if (o1.Length == 19)
                            o1 = o1.Substring(10, 9);
                        string o2 = table.Rows[i].ItemArray[1].ToString();

                        addlabelToMealTable(o1, 0, i + 1);
                        addlabelToMealTable(o2, 1, i + 1);
                    }
                }
            }
        }


        private void addlabelToMealTable(String text, int col, int row)
        {
            Label label = new Label();
            label.Text = text;
            label.TextAlign = ContentAlignment.MiddleCenter;
            tableLayoutPanel2.Controls.Add(label, col, row);
        }

        private void addlabelToPlanTable(String text, int col, int row)
        {
            Label label = new Label();
            label.Dock = DockStyle.Fill;
            label.Text = text;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.Fill;
            label.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.Controls.Add(label, col, row);
        }

        private void tableMealSettings()
        {
            this.tableLayoutPanel2.Controls.Clear();
            this.tableLayoutPanel2.RowStyles.Clear();
            this.tableLayoutPanel2.AutoSize = false;
            this.tableLayoutPanel2.BackColor = Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.Padding = new Padding(0);
            this.tableLayoutPanel2.RowCount = 16;
            this.tableLayoutPanel2.TabIndex = 0;

            addlabelToMealTable("время", 0, 0);
            addlabelToMealTable("название", 1, 0);
        }

        private void tablePlanSettings()
        {
            this.tableLayoutPanel1.Controls.Clear();
            this.tableLayoutPanel1.ColumnStyles.Clear();
            this.tableLayoutPanel1.AutoSize = false;
            this.tableLayoutPanel1.BackColor = Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.Size = new Size(534, 124);
            this.tableLayoutPanel1.TabIndex = 9;
 
            addlabelToPlanTable("ккал", 1, 0);
            addlabelToPlanTable("белки", 2, 0);
            addlabelToPlanTable("жиры", 3, 0);
            addlabelToPlanTable("угл", 4, 0);
            addlabelToPlanTable("план", 0, 1);
            addlabelToPlanTable("результат", 0, 2);
        }

        private void showWaterNeed()
        {
            Database db = new Database();

            DataTable table = db.getWaterNeed(Authorization.id);

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
            string date = generationNowDate();
          
            DataTable table = db.getWaterRes(Authorization.id, date);
            water_res.Text = "Выпитое количество воды: " + table.Rows[0].ItemArray[0].ToString();
        }

        public void showMealPlan()
        {
            tablePlanSettings();
            Database db = new Database();
            string date = generationNowDate();

            addlabelToPlanTable(db.getCharsUserMeal(Authorization.id, "калории", date).ToString(), 1, 2);
            addlabelToPlanTable(db.getCharsUserMeal(Authorization.id, "белки", date).ToString(), 2, 2);
            addlabelToPlanTable(db.getCharsUserMeal(Authorization.id, "жиры", date).ToString(), 3, 2);
            addlabelToPlanTable(db.getCharsUserMeal(Authorization.id, "углеводы", date).ToString(), 4, 2);

            DataTable table = db.getMealPlan(Authorization.id);

            if (table != null && table.Rows.Count == 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (table.Rows[i].ItemArray[1].ToString() == "калории")
                    {
                        addlabelToPlanTable(table.Rows[i].ItemArray[0].ToString(), 1, 1);
                    }
                        
                    

                    if (table.Rows[i].ItemArray[1].ToString() == "белки")
                    {
                        addlabelToPlanTable(table.Rows[i].ItemArray[0].ToString(), 2, 1);
                    }

                    if (table.Rows[i].ItemArray[1].ToString() == "жиры")
                    {
                        addlabelToPlanTable(table.Rows[i].ItemArray[0].ToString(), 3, 1);               
                    }

                    if (table.Rows[i].ItemArray[1].ToString() == "углеводы")
                    {
                        addlabelToPlanTable(table.Rows[i].ItemArray[0].ToString(), 4, 1);                      
                    }


                }
            }
               
        }

        private void addMeal_button_Click(object sender, EventArgs e)
        {
            AddMeal addMeal = new AddMeal();
            addMeal.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            showMeals();
            showWaterNeed();
            showWaterRes();
            showMealPlan();
            oftenProd_label.Text = "Наиболее часто потребляемый\n продукт: " + getOftenProduct();
        }

        private void addMealPlan_button_Click_1(object sender, EventArgs e)
        {
            AddMealPlan addMealPlan = new AddMealPlan();
            addMealPlan.Show();
        }

        private void addWater_button_Click(object sender, EventArgs e)
        {
            waterPortion_comboBox.Visible = true;
        }

        private void waterPortion_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database db = new Database();
            string date = generationNowDate();
            db.addWaterPortion(date, Authorization.id, waterPortion_comboBox.SelectedIndex + 1);
            waterPortion_comboBox.Visible = false;
            showWaterRes();
        }

        private string getOftenProduct()
        {
            Database db = new Database();
            return db.getOftenEatingProduct(Authorization.id);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.deleteLastMeal(Authorization.id))
            {
                showMeals();
                showMealPlan();
                oftenProd_label.Text = "Наиболее часто потребляемый\n продукт: " + getOftenProduct();
            }
            else MessageBox.Show("Не удалось удалить");
        }
    }
}
