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
        }

       private void showMeals()
        {
           // string date = DateTime.Now.Date.ToShortDateString();
          
            Database db = new Database();

            DataTable table = db.getMeals("2020-11-20", 1);

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
               }
        }


        private void addlabelToMealTable(String text, int col, int row)
        {
            Label label = new Label();
            label.Dock = DockStyle.Fill;
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
            tableLayoutPanel1.Controls.Add(label, col, row);
        }

        private void tableMealSettings()
        {
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel2.Padding = new Padding(3);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel2.Size = new Size(220, 95);
            this.tableLayoutPanel2.TabIndex = 0;
        }

        private void tablePlanSettings()
        {
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Padding = new Padding(3);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel1.Size = new Size(100, 95);
            this.tableLayoutPanel1.TabIndex = 0;
        }

        private void showWaterNeed()
        {
            Database db = new Database();

            //Authorization.id вместо 1
            DataTable table = db.getWaterNeed(1);

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

            //Authorization.id вместо 1
            DataTable table = db.getWaterRes(1);
            water_res.Text = "Выпитое количество воды: " + table.Rows[0].ItemArray[0].ToString();
        }

        public void showMealPlan()
        {
            tablePlanSettings();
            Database db = new Database();

            //Authorization.id вместо 1
            DataTable table = db.getMealPlan(1);


            for(int i = 0; i < 4; i++)
            {
                if (table.Rows[i].ItemArray[1].ToString() == "калории") addlabelToPlanTable(table.Rows[i].ItemArray[0].ToString(), 1, 1);

                if (table.Rows[i].ItemArray[1].ToString() == "белки") addlabelToPlanTable(table.Rows[i].ItemArray[0].ToString(), 2, 1);

                if (table.Rows[i].ItemArray[1].ToString() == "жиры") addlabelToPlanTable(table.Rows[i].ItemArray[0].ToString(), 3, 1);

                if (table.Rows[i].ItemArray[1].ToString() == "углеводы") addlabelToPlanTable(table.Rows[i].ItemArray[0].ToString(), 4, 1);
            }
               
        }

        private void addMealPlan_button_Click(object sender, EventArgs e)
        {
            AddMealPlan addMealPlan = new AddMealPlan();
            addMealPlan.Show();
        }

        private void addMeal_button_Click(object sender, EventArgs e)
        {
            AddMeal addMeal = new AddMeal();
            addMeal.Show();
        }
    }
}
