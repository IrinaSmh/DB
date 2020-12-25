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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();

            comboBox1.Items.Add("возраст");
            comboBox1.Items.Add("рост");
            comboBox1.Items.Add("вес");
            comboBox1.Items.Add("имя");
        }

        private void save_Click(object sender, EventArgs e)
        {
            bool res = false;
            if (value.Text != "")
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Выберите, что нужно изменить");
                    return;
                }
                if (comboBox1.SelectedItem.ToString() == "возраст")
                {
                    Database db = new Database();
                    if (db.updateAge(value.Text, Authorization.id) == true) res = true;
                }
                if (comboBox1.SelectedItem.ToString() == "рост")
                {
                    Database db = new Database();
                    if (db.updateHeight(value.Text, Authorization.id) == true) res = true; ;
                }
                if (comboBox1.SelectedItem.ToString() == "вес")
                {
                    Database db = new Database();
                    if (db.updateWeight(value.Text, Authorization.id) == true) res = true; ;
                }
                if (comboBox1.SelectedItem.ToString() == "имя")
                {
                    Database db = new Database();
                    if (db.updateName(value.Text, Authorization.id) == true) res = true; ;
                }
                
            }
            else
            {
                MessageBox.Show("Напишите новое значение");
                return;
            }

            if (res) MessageBox.Show("Данные изменены");
            else MessageBox.Show("Что-то пошло не так, повторите попытку позже");
        }
    }


    
}
