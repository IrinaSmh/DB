using System;
using System.Drawing;
using System.Windows.Forms;

namespace FoodCalculator
{
    public partial class AddMealPlan : Form
    {
        public AddMealPlan()
        {
            InitializeComponent();

            setStartSettings();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if(protein.Text == "белки" || fat.Text == "жиры" || carb.Text == "углеводы" || calories.Text == "калории")
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }
               
            Database db = new Database();
            if (db.saveMealPlan(Authorization.id, int.Parse(protein.Text),
                int.Parse(fat.Text), int.Parse(carb.Text), int.Parse(calories.Text)) == false)
                MessageBox.Show("Не удалось сохранить план питания. Попробуйте позже");
            else
            {
                setStartSettings();
                MessageBox.Show("План питания сохранен");
            }
        }

        private void protein_Enter(object sender, EventArgs e)
        {
            Drawing.textBoxEnter("белки", protein);
        }

        private void fat_Enter(object sender, EventArgs e)
        {
            Drawing.textBoxEnter("жиры", fat);
        }

        private void carb_Enter(object sender, EventArgs e)
        {
            Drawing.textBoxEnter("углеводы", carb);
        }

        private void calories_Enter(object sender, EventArgs e)
        {
            Drawing.textBoxEnter("калории", calories);
        }

        private void protein_Leave(object sender, EventArgs e)
        {
            Drawing.textBoxLeave("белки", protein);
        }

        private void fat_Leave(object sender, EventArgs e)
        {
            Drawing.textBoxLeave("жиры", fat);
        }

        private void carb_Leave(object sender, EventArgs e)
        {
            Drawing.textBoxLeave("углеводы", carb);
        }

        private void calories_Leave(object sender, EventArgs e)
        {
            Drawing.textBoxLeave("калории", calories);
        }

        private void setStartSettings()
        {
            protein.Text = "белки";
            protein.ForeColor = Color.Gray;
            fat.Text = "жиры";
            fat.ForeColor = Color.Gray;
            carb.Text = "углеводы";
            carb.ForeColor = Color.Gray;
            calories.Text = "калории";
            calories.ForeColor = Color.Gray;
        }
    }
}
