
namespace FoodCalculator
{
    partial class Authorization
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
            this.label1 = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.enter_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "FoodCalculator";
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(142, 108);
            this.login_textBox.Multiline = true;
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(339, 44);
            this.login_textBox.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FoodCalculator.Properties.Resources.iconfinder_key_3090581;
            this.pictureBox2.Location = new System.Drawing.Point(48, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoodCalculator.Properties.Resources.iconfinder_Rounded_31_2024644;
            this.pictureBox1.Location = new System.Drawing.Point(48, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(142, 191);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(339, 22);
            this.password_textBox.TabIndex = 4;
            this.password_textBox.UseSystemPasswordChar = true;
            // 
            // enter_button
            // 
            this.enter_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
            this.enter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter_button.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_button.Location = new System.Drawing.Point(225, 281);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(169, 55);
            this.enter_button.TabIndex = 5;
            this.enter_button.Text = "Войти";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.MouseEnter += new System.EventHandler(this.enter_button_MouseEnter);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(582, 401);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Authorization";
            this.Text = "Authorization";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button enter_button;
    }
}