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
    public partial class AddMeal : Form
    {
        public AddMeal()
        {
            InitializeComponent();
            fillDishesList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            product_radioButton.Checked = false;
    
            fillDishesList();
        }

        private void product_radioButton_Click(object sender, EventArgs e)
        {
            dish_Button2.Checked = false;
            fillProductsList();
        }
    }
}
