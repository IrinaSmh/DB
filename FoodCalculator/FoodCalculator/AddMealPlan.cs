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
    public partial class AddMealPlan : Form
    {
        public AddMealPlan()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            MySqlCommand command = new MySqlCommand("INSERT INTO mealplans(createAt, valueOfWater, users_id) VALUES (NOW(), 1500, 1);", db.getConnection());
        }
    }
}
