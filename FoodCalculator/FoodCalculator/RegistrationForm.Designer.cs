
namespace FoodCalculator
{
    partial class RegistrationForm
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
            this.registration_button = new System.Windows.Forms.Button();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reg_label = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.man_radioButton = new System.Windows.Forms.RadioButton();
            this.woman = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registration_button
            // 
            this.registration_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
            this.registration_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registration_button.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_button.Location = new System.Drawing.Point(665, 347);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(268, 55);
            this.registration_button.TabIndex = 11;
            this.registration_button.Text = "Зарегистрироваться";
            this.registration_button.UseVisualStyleBackColor = true;
            this.registration_button.Click += new System.EventHandler(this.registration_button_Click);
            this.registration_button.MouseEnter += new System.EventHandler(this.registration_button_MouseEnter_1);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(665, 155);
            this.password_textBox.Multiline = true;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(339, 44);
            this.password_textBox.TabIndex = 10;
            this.password_textBox.Enter += new System.EventHandler(this.password_textBox_Enter_1);
            this.password_textBox.Leave += new System.EventHandler(this.password_textBox_Leave_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "FoodCalculator";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FoodCalculator.Properties.Resources.iconfinder_key_3090581;
            this.pictureBox2.Location = new System.Drawing.Point(570, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoodCalculator.Properties.Resources.iconfinder_Rounded_31_2024644;
            this.pictureBox1.Location = new System.Drawing.Point(40, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // reg_label
            // 
            this.reg_label.AutoSize = true;
            this.reg_label.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_label.Location = new System.Drawing.Point(424, 53);
            this.reg_label.Name = "reg_label";
            this.reg_label.Size = new System.Drawing.Size(197, 44);
            this.reg_label.TabIndex = 12;
            this.reg_label.Text = "Регистрация";
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(255, 347);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(100, 22);
            this.weight.TabIndex = 14;
            this.weight.Enter += new System.EventHandler(this.weight_Enter);
            this.weight.Leave += new System.EventHandler(this.weight_Leave);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(145, 347);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 22);
            this.height.TabIndex = 15;
            this.height.Enter += new System.EventHandler(this.height_Enter);
            this.height.Leave += new System.EventHandler(this.height_Leave);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(145, 390);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 22);
            this.age.TabIndex = 16;
            this.age.Enter += new System.EventHandler(this.age_Enter);
            this.age.Leave += new System.EventHandler(this.age_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Заполните все поля";
            // 
            // man_radioButton
            // 
            this.man_radioButton.AutoSize = true;
            this.man_radioButton.Location = new System.Drawing.Point(255, 297);
            this.man_radioButton.Name = "man_radioButton";
            this.man_radioButton.Size = new System.Drawing.Size(40, 21);
            this.man_radioButton.TabIndex = 18;
            this.man_radioButton.TabStop = true;
            this.man_radioButton.Text = "М";
            this.man_radioButton.UseVisualStyleBackColor = true;
            this.man_radioButton.Click += new System.EventHandler(this.man_radioButton_Click);
            // 
            // woman
            // 
            this.woman.AutoSize = true;
            this.woman.Location = new System.Drawing.Point(313, 297);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(42, 21);
            this.woman.TabIndex = 19;
            this.woman.TabStop = true;
            this.woman.Text = "Ж";
            this.woman.UseVisualStyleBackColor = true;
            this.woman.Click += new System.EventHandler(this.woman_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(151, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ваш пол:";
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(145, 155);
            this.login_textBox.Multiline = true;
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(339, 44);
            this.login_textBox.TabIndex = 21;
            this.login_textBox.Enter += new System.EventHandler(this.login_textBox_Enter);
            this.login_textBox.Leave += new System.EventHandler(this.login_textBox_Leave);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1084, 477);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.woman);
            this.Controls.Add(this.man_radioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.age);
            this.Controls.Add(this.height);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.reg_label);
            this.Controls.Add(this.registration_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registration_button;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reg_label;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton man_radioButton;
        private System.Windows.Forms.RadioButton woman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_textBox;
    }
}