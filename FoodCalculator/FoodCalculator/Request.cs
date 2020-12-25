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
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();

            textBox1.Text = "Напишите рецепт";
            textBox1.ForeColor = Color.Gray;
        }

        private void dish_radioButton_Click(object sender, EventArgs e)
        {
            product_radioButton.Checked = false;
            textBox1.Text = "Напишите рецепт";
            textBox1.ForeColor = Color.Gray;
        }

        private void product_radioButton_Click(object sender, EventArgs e)
        {
            dish_radioButton.Checked = false;
            textBox1.Text = "Напишите название";
            textBox1.ForeColor = Color.Gray;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Напишите рецепт" || textBox1.Text == "Напишите название")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                if (product_radioButton.Checked == true)
                {
                    textBox1.Text = "Напишите название";
                    textBox1.ForeColor = Color.Gray;
                }
                else if (dish_radioButton.Checked == true)
                {
                    textBox1.Text = "Напишите рецепт";
                    textBox1.ForeColor = Color.Gray;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox1.Text == "Напишите название" || textBox1.Text == "Напишите рецепт")
            {
                MessageBox.Show("Ошибка, заявка пустая");
            } else
            {
                MessageBox.Show("Заявка отправлена");
                dish_radioButton.Checked = true;
                textBox1.Text = "Напишите рецепт";
                textBox1.ForeColor = Color.Gray;
            }
        }
    }
}
