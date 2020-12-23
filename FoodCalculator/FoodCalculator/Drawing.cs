using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodCalculator
{
    static class Drawing
    {
        public static void textBoxEnter(string str, TextBox obj)
        {
            if (obj.Text == str)
            {
                obj.Text = "";
                obj.ForeColor = Color.Black;
            }
        }

        public static void textBoxLeave(string str, TextBox obj)
        {
            if (obj.Text == "")
            {
                obj.Text = str;
                obj.ForeColor = Color.Gray;
            }
        }
    }
}
