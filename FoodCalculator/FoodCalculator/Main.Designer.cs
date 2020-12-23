
namespace FoodCalculator
{
    partial class Main
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
            this.name_label = new System.Windows.Forms.Label();
            this.meal_label = new System.Windows.Forms.Label();
            this.water_label = new System.Windows.Forms.Label();
            this.water_res = new System.Windows.Forms.Label();
            this.addWater_button = new System.Windows.Forms.Button();
            this.mealPlan_label = new System.Windows.Forms.Label();
            this.addMealPlan_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.result_label_inTable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addMeal_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(18, 20);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(56, 32);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Имя";
            // 
            // meal_label
            // 
            this.meal_label.AutoSize = true;
            this.meal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.meal_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.meal_label.Location = new System.Drawing.Point(19, 72);
            this.meal_label.Name = "meal_label";
            this.meal_label.Size = new System.Drawing.Size(230, 25);
            this.meal_label.TabIndex = 1;
            this.meal_label.Text = "Приемы пищи сегодня:";
            // 
            // water_label
            // 
            this.water_label.AutoSize = true;
            this.water_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.water_label.Location = new System.Drawing.Point(534, 59);
            this.water_label.Name = "water_label";
            this.water_label.Size = new System.Drawing.Size(256, 25);
            this.water_label.TabIndex = 3;
            this.water_label.Text = "Нужное количество воды:";
            // 
            // water_res
            // 
            this.water_res.AutoSize = true;
            this.water_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.water_res.Location = new System.Drawing.Point(534, 103);
            this.water_res.Name = "water_res";
            this.water_res.Size = new System.Drawing.Size(266, 25);
            this.water_res.TabIndex = 4;
            this.water_res.Text = "Выпитое количество воды:";
            // 
            // addWater_button
            // 
            this.addWater_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addWater_button.Location = new System.Drawing.Point(917, 105);
            this.addWater_button.Name = "addWater_button";
            this.addWater_button.Size = new System.Drawing.Size(92, 23);
            this.addWater_button.TabIndex = 5;
            this.addWater_button.Text = "Добавить";
            this.addWater_button.UseVisualStyleBackColor = true;
            // 
            // mealPlan_label
            // 
            this.mealPlan_label.AutoSize = true;
            this.mealPlan_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mealPlan_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mealPlan_label.Location = new System.Drawing.Point(484, 387);
            this.mealPlan_label.Name = "mealPlan_label";
            this.mealPlan_label.Size = new System.Drawing.Size(147, 25);
            this.mealPlan_label.TabIndex = 6;
            this.mealPlan_label.Text = "План питания:";
            // 
            // addMealPlan_button
            // 
            this.addMealPlan_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMealPlan_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addMealPlan_button.Location = new System.Drawing.Point(3, 3);
            this.addMealPlan_button.Name = "addMealPlan_button";
            this.addMealPlan_button.Size = new System.Drawing.Size(143, 36);
            this.addMealPlan_button.TabIndex = 7;
            this.addMealPlan_button.Text = "Новый";
            this.addMealPlan_button.UseVisualStyleBackColor = true;
            this.addMealPlan_button.Click += new System.EventHandler(this.addMealPlan_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.9372F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.0628F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.result_label_inTable, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addMealPlan_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(468, 432);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 124);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 42);
            this.label2.TabIndex = 10;
            this.label2.Text = "План";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result_label_inTable
            // 
            this.result_label_inTable.AutoSize = true;
            this.result_label_inTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_label_inTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result_label_inTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_label_inTable.Location = new System.Drawing.Point(3, 84);
            this.result_label_inTable.Name = "result_label_inTable";
            this.result_label_inTable.Size = new System.Drawing.Size(143, 40);
            this.result_label_inTable.TabIndex = 11;
            this.result_label_inTable.Text = "Результат";
            this.result_label_inTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(152, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 42);
            this.label3.TabIndex = 12;
            this.label3.Text = "ккал";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(255, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 42);
            this.label4.TabIndex = 13;
            this.label4.Text = "белки";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(354, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(89, 42);
            this.label5.TabIndex = 14;
            this.label5.Text = "жиры";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(449, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 42);
            this.label6.TabIndex = 15;
            this.label6.Text = "угл";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addMeal_button
            // 
            this.addMeal_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addMeal_button.Location = new System.Drawing.Point(35, 582);
            this.addMeal_button.Name = "addMeal_button";
            this.addMeal_button.Size = new System.Drawing.Size(91, 23);
            this.addMeal_button.TabIndex = 20;
            this.addMeal_button.Text = "Добавить";
            this.addMeal_button.UseVisualStyleBackColor = true;
            this.addMeal_button.Click += new System.EventHandler(this.addMeal_button_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.7191F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.2809F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 131);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(445, 425);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 425);
            this.label8.TabIndex = 0;
            this.label8.Text = "время";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(201, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 425);
            this.label9.TabIndex = 1;
            this.label9.Text = "название еды";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Update
            // 
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update.Location = new System.Drawing.Point(954, 577);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(117, 32);
            this.Update.TabIndex = 22;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1122, 621);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.addMeal_button);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mealPlan_label);
            this.Controls.Add(this.addWater_button);
            this.Controls.Add(this.water_res);
            this.Controls.Add(this.water_label);
            this.Controls.Add(this.meal_label);
            this.Controls.Add(this.name_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Main";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label meal_label;
        private System.Windows.Forms.Label water_label;
        private System.Windows.Forms.Label water_res;
        private System.Windows.Forms.Button addWater_button;
        private System.Windows.Forms.Label mealPlan_label;
        private System.Windows.Forms.Button addMealPlan_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label result_label_inTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addMeal_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Update;
    }
}