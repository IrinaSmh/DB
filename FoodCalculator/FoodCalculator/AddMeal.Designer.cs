
namespace FoodCalculator
{
    partial class AddMeal
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.product_radioButton = new System.Windows.Forms.RadioButton();
            this.dish_Button2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(165, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавьте съеденную пищу";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(160, 106);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(327, 24);
            this.comboBox.TabIndex = 1;
            this.comboBox.Text = "блюдо";
            // 
            // product_radioButton
            // 
            this.product_radioButton.AutoSize = true;
            this.product_radioButton.Location = new System.Drawing.Point(222, 65);
            this.product_radioButton.Name = "product_radioButton";
            this.product_radioButton.Size = new System.Drawing.Size(82, 21);
            this.product_radioButton.TabIndex = 2;
            this.product_radioButton.Text = "продукт";
            this.product_radioButton.UseVisualStyleBackColor = true;
            this.product_radioButton.Click += new System.EventHandler(this.product_radioButton_Click);
            // 
            // dish_Button2
            // 
            this.dish_Button2.AutoSize = true;
            this.dish_Button2.Checked = true;
            this.dish_Button2.Location = new System.Drawing.Point(346, 65);
            this.dish_Button2.Name = "dish_Button";
            this.dish_Button2.Size = new System.Drawing.Size(71, 21);
            this.dish_Button2.TabIndex = 3;
            this.dish_Button2.TabStop = true;
            this.dish_Button2.Text = "блюдо";
            this.dish_Button2.UseVisualStyleBackColor = true;
            this.dish_Button2.Click += new System.EventHandler(this.dish_Button_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(589, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(732, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dish_Button2);
            this.Controls.Add(this.product_radioButton);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label1);
            this.Name = "AddMeal";
            this.Text = "AddMeal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.RadioButton product_radioButton;
        private System.Windows.Forms.RadioButton dish_Button2;
        private System.Windows.Forms.Button button1;
    }
}