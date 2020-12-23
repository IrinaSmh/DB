
namespace FoodCalculator
{
    partial class AddMealPlan
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
            this.protein = new System.Windows.Forms.TextBox();
            this.fat = new System.Windows.Forms.TextBox();
            this.carb = new System.Windows.Forms.TextBox();
            this.calories = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // protein
            // 
            this.protein.Location = new System.Drawing.Point(51, 110);
            this.protein.Name = "protein";
            this.protein.Size = new System.Drawing.Size(100, 22);
            this.protein.TabIndex = 1;
            this.protein.Enter += new System.EventHandler(this.protein_Enter);
            this.protein.Leave += new System.EventHandler(this.protein_Leave);
            // 
            // fat
            // 
            this.fat.Location = new System.Drawing.Point(167, 110);
            this.fat.Name = "fat";
            this.fat.Size = new System.Drawing.Size(100, 22);
            this.fat.TabIndex = 2;
            this.fat.Enter += new System.EventHandler(this.fat_Enter);
            this.fat.Leave += new System.EventHandler(this.fat_Leave);
            // 
            // carb
            // 
            this.carb.Location = new System.Drawing.Point(282, 110);
            this.carb.Name = "carb";
            this.carb.Size = new System.Drawing.Size(100, 22);
            this.carb.TabIndex = 3;
            this.carb.Enter += new System.EventHandler(this.carb_Enter);
            this.carb.Leave += new System.EventHandler(this.carb_Leave);
            // 
            // calories
            // 
            this.calories.Location = new System.Drawing.Point(399, 110);
            this.calories.Name = "calories";
            this.calories.Size = new System.Drawing.Size(100, 22);
            this.calories.TabIndex = 4;
            this.calories.Enter += new System.EventHandler(this.calories_Enter);
            this.calories.Leave += new System.EventHandler(this.calories_Leave);
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Default;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Location = new System.Drawing.Point(436, 170);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(125, 32);
            this.save.TabIndex = 10;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(31, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введите данные плана питания";
            // 
            // AddMealPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 229);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.save);
            this.Controls.Add(this.calories);
            this.Controls.Add(this.carb);
            this.Controls.Add(this.fat);
            this.Controls.Add(this.protein);
            this.Name = "AddMealPlan";
            this.Text = "AddMealPlan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox protein;
        private System.Windows.Forms.TextBox fat;
        private System.Windows.Forms.TextBox carb;
        private System.Windows.Forms.TextBox calories;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label6;
    }
}