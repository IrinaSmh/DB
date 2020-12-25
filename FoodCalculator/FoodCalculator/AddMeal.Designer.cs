
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
            this.quantity_textBox = new System.Windows.Forms.TextBox();
            this.type_comboBox = new System.Windows.Forms.ComboBox();
            this.structure_label = new System.Windows.Forms.Label();
            this.char_label = new System.Windows.Forms.Label();
            this.addNew_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(243, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите еду";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(160, 106);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(327, 24);
            this.comboBox.TabIndex = 1;
            this.comboBox.Text = "блюдо";
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
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
            this.dish_Button2.Name = "dish_Button2";
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
            // quantity_textBox
            // 
            this.quantity_textBox.Location = new System.Drawing.Point(510, 106);
            this.quantity_textBox.Name = "quantity_textBox";
            this.quantity_textBox.Size = new System.Drawing.Size(100, 22);
            this.quantity_textBox.TabIndex = 5;
            this.quantity_textBox.MouseEnter += new System.EventHandler(this.quantity_textBox_MouseEnter);
            this.quantity_textBox.MouseLeave += new System.EventHandler(this.quantity_textBox_MouseLeave);
            // 
            // type_comboBox
            // 
            this.type_comboBox.FormattingEnabled = true;
            this.type_comboBox.Location = new System.Drawing.Point(616, 106);
            this.type_comboBox.Name = "type_comboBox";
            this.type_comboBox.Size = new System.Drawing.Size(89, 24);
            this.type_comboBox.TabIndex = 6;
            // 
            // structure_label
            // 
            this.structure_label.AutoSize = true;
            this.structure_label.Location = new System.Drawing.Point(157, 154);
            this.structure_label.Name = "structure_label";
            this.structure_label.Size = new System.Drawing.Size(0, 17);
            this.structure_label.TabIndex = 7;
            // 
            // char_label
            // 
            this.char_label.AutoSize = true;
            this.char_label.Location = new System.Drawing.Point(514, 154);
            this.char_label.Name = "char_label";
            this.char_label.Size = new System.Drawing.Size(0, 17);
            this.char_label.TabIndex = 8;
            // 
            // addNew_label
            // 
            this.addNew_label.AutoSize = true;
            this.addNew_label.Location = new System.Drawing.Point(12, 398);
            this.addNew_label.Name = "addNew_label";
            this.addNew_label.Size = new System.Drawing.Size(220, 17);
            this.addNew_label.TabIndex = 9;
            this.addNew_label.Text = "Добавить новый продукт/блюдо";
            this.addNew_label.Click += new System.EventHandler(this.addNew_label_Click);
            this.addNew_label.MouseLeave += new System.EventHandler(this.addNew_label_MouseLeave);
            this.addNew_label.MouseHover += new System.EventHandler(this.addNew_label_MouseHover);
            // 
            // AddMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(732, 439);
            this.Controls.Add(this.addNew_label);
            this.Controls.Add(this.char_label);
            this.Controls.Add(this.structure_label);
            this.Controls.Add(this.type_comboBox);
            this.Controls.Add(this.quantity_textBox);
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
        private System.Windows.Forms.TextBox quantity_textBox;
        private System.Windows.Forms.ComboBox type_comboBox;
        private System.Windows.Forms.Label structure_label;
        private System.Windows.Forms.Label char_label;
        private System.Windows.Forms.Label addNew_label;
    }
}