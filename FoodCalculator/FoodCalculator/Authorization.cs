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
    public partial class Authorization : Form
    {
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


    }
}
