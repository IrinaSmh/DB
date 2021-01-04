using System;
using System.Drawing;
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
            Drawing.textBoxEnter("Введите имя", login_textBox);
        }

        private void login_textBox_Leave(object sender, EventArgs e)
        {
            Drawing.textBoxLeave("Введите имя", login_textBox);
        }

        private void password_textBox_Enter_1(object sender, EventArgs e)
        {
            Drawing.textBoxEnter("Введите пароль", password_textBox);
        }

        private void password_textBox_Leave_1(object sender, EventArgs e)
        {
            Drawing.textBoxLeave("Введите пароль", password_textBox);
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
            age.Text == "Возраст" || (man_radioButton.Checked == false && woman.Checked == false)) MessageBox.Show("Заполните все поля");
            else
            {
                if (isLoginExists()) return;
                int gender = -1;
                    Database db = new Database();
                   
                if (man_radioButton.Checked == true) gender = 1;
                if (woman.Checked == true) gender = 0;

                    if (db.registration(login_textBox.Text, password_textBox.Text, gender, float.Parse(weight.Text),
                        float.Parse(height.Text), int.Parse(age.Text))) MessageBox.Show("Аккаунт создан");
                    else MessageBox.Show("Аккаунт не создан");                 
                }          
        }

        private bool isLoginExists()
        {
            Database db = new Database();

            if (db.checkLoginExist(login_textBox.Text, password_textBox.Text))
            {
                MessageBox.Show("Такой логин уже существует");
                return true;
            }
            else return false;
        }

        private void height_Enter(object sender, EventArgs e)
        {
            Drawing.textBoxEnter("Рост", height);
        }

        private void age_Enter(object sender, EventArgs e)
        {
            Drawing.textBoxEnter("Возраст", age);
        }

        private void weight_Enter(object sender, EventArgs e)
        {
            Drawing.textBoxEnter("Вес", weight);
        }

        private void height_Leave(object sender, EventArgs e)
        {
            Drawing.textBoxLeave("Рост", height);
        }

        private void weight_Leave(object sender, EventArgs e)
        {
            Drawing.textBoxLeave("Вес", weight);
        }

        private void age_Leave(object sender, EventArgs e)
        {
            Drawing.textBoxLeave("Возраст", age);
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
