using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FoodCalculator
{
    public partial class AddMeal : Form
    {
        public AddMeal()
        {
            InitializeComponent();
            fillDishesList();
            quantity_textBox.Visible = false;
            quantity_textBox.Text = "кол-во";
            quantity_textBox.ForeColor = Color.Gray;
            type_comboBox.Visible = false;
            type_comboBox.Text = "тип кол-ва";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dish_Button2.Checked == true)
            {
                Database db = new Database();
                if (comboBox.SelectedItem == null)
                {
                    MessageBox.Show("Выберите блюдо");
                    return;
                }
                    
               
                if (db.saveDishInMeal(Authorization.id, comboBox.SelectedItem.ToString()))
                {
                    MessageBox.Show("Сохранено");
                }
                else MessageBox.Show("Произошла ошибка, повторите позже");
            }
            else if(product_radioButton.Checked == true)
            {
                Database db = new Database();
                if (comboBox.SelectedItem == null)
                {
                    MessageBox.Show("Выберите продукт");
                    return;
                }
                if(type_comboBox.SelectedItem == null)
                {
                    MessageBox.Show("Выберите тип измерения количества продукта");
                    return;
                }
                
                if (db.saveProductInMeal(Authorization.id, comboBox.SelectedItem.ToString(), quantity_textBox.Text, type_comboBox.SelectedItem.ToString()))
                {
                    MessageBox.Show("Сохранено");
                }
                else MessageBox.Show("Произошла ошибка, повторите позже");
            }
        }

        private void fillDishesList()
        {
            comboBox.Items.Clear();
            comboBox.Text = "блюда";
            Database db = new Database();
            DataTable list = db.getAllDishes();

            if(list.Rows.Count > 0)
            {
                for(int i = 0; i < list.Rows.Count; i++)
                {
                    comboBox.Items.Add(list.Rows[i].ItemArray[0].ToString());
                }
            }
        }

        private void fillProductsList()
        {
            comboBox.Items.Clear();
            comboBox.Text = "продукты";
            Database db = new Database();
            DataTable list = db.getAllProducts();

            if (list.Rows.Count > 0)
            {
                for (int i = 0; i < list.Rows.Count; i++)
                {
                    comboBox.Items.Add(list.Rows[i].ItemArray[0].ToString());
                }
            }
        }

        private void dish_Button_Click(object sender, EventArgs e)
        {
            structure_label.Text = "";
            char_label.Text = "";
            product_radioButton.Checked = false;
            type_comboBox.Visible = false;
            quantity_textBox.Visible = false;
            fillDishesList();
        }

        private void product_radioButton_Click(object sender, EventArgs e)
        {
            structure_label.Visible = false;
            char_label.Visible = false;
            dish_Button2.Checked = false;
            fillProductsList();
            quantity_textBox.Visible = true;
            type_comboBox.Items.Add("шт");
            type_comboBox.Items.Add("г");
            type_comboBox.Items.Add("ч.л.");
            type_comboBox.Items.Add("ст.л.");
            type_comboBox.Items.Add("стакан");
            type_comboBox.Visible = true;
        }

        private void quantity_textBox_MouseEnter(object sender, EventArgs e)
        {
            Drawing.textBoxEnter("кол-во", quantity_textBox);
        }

        private void quantity_textBox_MouseLeave(object sender, EventArgs e)
        {
            Drawing.textBoxLeave("кол-во", quantity_textBox);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if(dish_Button2.Checked == true)
            {
                structure_label.Text = "";
                char_label.Text = "";
                Database db = new Database();
                DataTable ch = db.getCharOfDish(comboBox.SelectedItem.ToString());
                if(ch != null)
                {
                        char_label.Text += "Калории: " + ch.Rows[0].ItemArray[0].ToString();
                        char_label.Text += "\nБелки: " + ch.Rows[0].ItemArray[1].ToString();      
                        char_label.Text += "\nЖиры: " + ch.Rows[0].ItemArray[2].ToString();            
                        char_label.Text += "\nУглеводы: " + ch.Rows[0].ItemArray[3].ToString();

                    char_label.Visible = true;                    
                }
                
                DataTable structure = db.getStuctureOfDish(comboBox.SelectedItem.ToString());
                if (structure != null)
                {
                    for(int i = 0; i < structure.Rows.Count; i++)
                    {
                        structure_label.Text += structure.Rows[i].ItemArray[1].ToString();
                        structure_label.Text += " " + structure.Rows[i].ItemArray[2].ToString();
                        structure_label.Text += " " +structure.Rows[i].ItemArray[0].ToString() + "\n";
                    }
                    structure_label.Visible = true;
                }
            } else if(product_radioButton.Checked == true)
            {
                structure_label.Text = "";
                Database db = new Database();
                DataTable ch = db.getCharOfProduct(comboBox.SelectedItem.ToString());
                if (ch != null)
                {
                    for (int i = 0; i < ch.Rows.Count; i++)
                    {
                        structure_label.Text += ch.Rows[i].ItemArray[0].ToString();
                        structure_label.Text += " " + ch.Rows[i].ItemArray[1].ToString();
                        structure_label.Text += " " + ch.Rows[i].ItemArray[2].ToString() + "\n";
                    }
                    structure_label.Visible = true;
                }
                char_label.Text = "";
                DataTable type = db.getTypeOfProduct(comboBox.SelectedItem.ToString());
                if(type != null)
                {
                    char_label.Text = type.Rows[0].ItemArray[0].ToString();
                }
                char_label.Visible = true;
            }
            
        }

        private void addNew_label_MouseHover(object sender, EventArgs e)
        {
            addNew_label.ForeColor = Color.Gray;
        }

        private void addNew_label_MouseLeave(object sender, EventArgs e)
        {
            addNew_label.ForeColor = Color.Black;
        }

        private void addNew_label_Click(object sender, EventArgs e)
        {
            Request request = new Request();
            request.Show();
        }
    }
}
