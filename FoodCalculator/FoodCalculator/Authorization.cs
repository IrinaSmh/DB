using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FoodCalculator
{
    public partial class Authorization : Form
    {
        public static int id;
        public static string name;
        public Authorization()
        {
            InitializeComponent();

            this.password_textBox.AutoSize = false;
            this.password_textBox.Size = new Size(this.login_textBox.Size.Width, this.login_textBox.Size.Height);
        }

        private void enter_button_MouseEnter(object sender, EventArgs e)
        {
            enter_button.BackColor = Color.FromArgb(46384);
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            String loginUser = login_textBox.Text;
            String passwordUser = password_textBox.Text;

            Database db = new Database();

            DataTable table = db.getUser(loginUser, passwordUser);

            if(table.Rows.Count > 0)
            {
                id = int.Parse(table.Rows[0].ItemArray[0].ToString());
                name = table.Rows[0].ItemArray[1].ToString();
                this.Hide();
                Main mainForm = new Main();
                mainForm.Show();
            } else MessageBox.Show("Такого пользователя нет");
        }

        private void reg_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void reg_label_MouseHover(object sender, EventArgs e)
        {
            reg_label.ForeColor = Color.White;
        }

        private void reg_label_MouseLeave(object sender, EventArgs e)
        {
            reg_label.ForeColor = Color.Black;
        }
    }
}
