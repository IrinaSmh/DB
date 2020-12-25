
namespace FoodCalculator
{
    partial class Request
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.product_radioButton = new System.Windows.Forms.RadioButton();
            this.dish_radioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // product_radioButton
            // 
            this.product_radioButton.AutoSize = true;
            this.product_radioButton.Location = new System.Drawing.Point(138, 41);
            this.product_radioButton.Name = "product_radioButton";
            this.product_radioButton.Size = new System.Drawing.Size(82, 21);
            this.product_radioButton.TabIndex = 0;
            this.product_radioButton.Text = "продукт";
            this.product_radioButton.UseVisualStyleBackColor = true;
            this.product_radioButton.Click += new System.EventHandler(this.product_radioButton_Click);
            // 
            // dish_radioButton
            // 
            this.dish_radioButton.AutoSize = true;
            this.dish_radioButton.Checked = true;
            this.dish_radioButton.Location = new System.Drawing.Point(320, 41);
            this.dish_radioButton.Name = "dish_radioButton";
            this.dish_radioButton.Size = new System.Drawing.Size(71, 21);
            this.dish_radioButton.TabIndex = 1;
            this.dish_radioButton.TabStop = true;
            this.dish_radioButton.Text = "блюдо";
            this.dish_radioButton.UseVisualStyleBackColor = true;
            this.dish_radioButton.Click += new System.EventHandler(this.dish_radioButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(483, 235);
            this.textBox1.TabIndex = 2;
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dish_radioButton);
            this.Controls.Add(this.product_radioButton);
            this.Name = "Request";
            this.Text = "Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton product_radioButton;
        private System.Windows.Forms.RadioButton dish_radioButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}