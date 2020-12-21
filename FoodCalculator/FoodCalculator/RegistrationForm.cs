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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            login_textBox.Text = "Введите имя";
            login_textBox.ForeColor = Color.Gray;
            password_textBox.Text = "Введите пароль";
            password_textBox.ForeColor = Color.Gray;
            weight.ForeColor = Color.Gray;
            height.ForeColor = Color.Gray;
            age.ForeColor = Color.Gray;           
            weight.Text = "Вес";
            height.Text = "Рост";
            age.Text = "Возраст";
        }

        private void login_textBox_Enter(object sender, EventArgs e)
        {
            if(login_textBox.Text == "Введите имя")
            {
                login_textBox.Text = "";
                login_textBox.ForeColor = Color.Black;
            }
               
        }

        private void login_textBox_Leave(object sender, EventArgs e)
        {
            if (login_textBox.Text == "")
            {
                login_textBox.Text = "Введите имя";
                login_textBox.ForeColor = Color.Gray;
            }
                
        }

        private void password_textBox_Enter_1(object sender, EventArgs e)
        {
            if (password_textBox.Text == "Введите пароль")
            {
                password_textBox.Text = "";
                password_textBox.ForeColor = Color.Black;
            }

        }

        private void password_textBox_Leave_1(object sender, EventArgs e)
        {
            if (password_textBox.Text == "")
            {
                password_textBox.Text = "Введите пароль";
                password_textBox.ForeColor = Color.Gray;
            }
        }

        private void registration_button_MouseEnter_1(object sender, EventArgs e)
        {
            registration_button.BackColor = Color.FromArgb(46384);
        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            if (login_textBox.Text == "Введите имя" ||
            password_textBox.Text == "Введите пароль" ||
            weight.Text == "Вес" ||
            height.Text == "Рост" ||
            age.Text == "Возраст") MessageBox.Show("Заполните все поля");
            else
            {
                if (isLoginExists()) return;
              
                    Database db = new Database();
                    MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`name`, `password`, `gender`, `weight`, `height`) VALUES (@name, @password, @age, @weigth, @height)", db.getConnection());
                    command.Parameters.AddWithValue("@name", login_textBox.Text);
                    command.Parameters.AddWithValue("@password", password_textBox.Text);
                    if (man_radioButton.Checked == true) command.Parameters.AddWithValue("@gender", 1);
                    if (woman.Checked == true) command.Parameters.AddWithValue("@gender", 0);
                    command.Parameters.AddWithValue("@weigth", float.Parse(weight.Text));
                    command.Parameters.AddWithValue("@height", float.Parse(height.Text));
                    command.Parameters.AddWithValue("@age", int.Parse(age.Text));
                    db.openConnection();
                    if (command.ExecuteNonQuery() == 1) MessageBox.Show("Аккаунт создан");
                    else MessageBox.Show("Аккаунт не создан");
                    db.closeConnection();
                }
            
        }

        private bool isLoginExists()
        {
            Database db = new Database();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `name` = @lU", db.getConnection());
            command.Parameters.AddWithValue("pU", password_textBox.Text);
            command.Parameters.AddWithValue("lU", login_textBox.Text);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует");
                return true;
            }
            else return false;
        }

        private void height_Enter(object sender, EventArgs e)
        {
            if (height.Text == "Рост")
            {
                height.Text = "";
                height.ForeColor = Color.Black;
            }
        }

        private void age_Enter(object sender, EventArgs e)
        {
            if (age.Text == "Возраст")
            {
                age.Text = "";
                age.ForeColor = Color.Black;
            }
        }

        private void weight_Enter(object sender, EventArgs e)
        {
            if (weight.Text == "Вес")
            {
                weight.Text = "";
                weight.ForeColor = Color.Black;
            }
        }

        private void height_Leave(object sender, EventArgs e)
        {
            if (height.Text == "")
            {
                height.Text = "Рост";
                height.ForeColor = Color.Gray;
            }
        }

        private void weight_Leave(object sender, EventArgs e)
        {
            if (weight.Text == "")
            {
                weight.Text = "Вес";
                weight.ForeColor = Color.Gray;
            }
        }

        private void age_Leave(object sender, EventArgs e)
        {
            if (age.Text == "")
            {
                age.Text = "Возраст";
                age.ForeColor = Color.Gray;
            }
        }

        private void man_radioButton_Click(object sender, EventArgs e)
        {
            woman.Checked = false;
        }

        private void woman_Click(object sender, EventArgs e)
        {
            man_radioButton.Checked = false;
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.auth.Show();
        }
    }
}
