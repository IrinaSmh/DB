
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
            this.water = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.fat = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            this.cc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // water
            // 
            this.water.Location = new System.Drawing.Point(36, 110);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(100, 22);
            this.water.TabIndex = 0;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(142, 110);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 22);
            this.b.TabIndex = 1;
            // 
            // fat
            // 
            this.fat.Location = new System.Drawing.Point(248, 110);
            this.fat.Name = "fat";
            this.fat.Size = new System.Drawing.Size(100, 22);
            this.fat.TabIndex = 2;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(354, 110);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(100, 22);
            this.y.TabIndex = 3;
            // 
            // cc
            // 
            this.cc.Location = new System.Drawing.Point(461, 110);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(100, 22);
            this.cc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Белки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Жиры";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Углеводы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Калории";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(464, 164);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(125, 32);
            this.save.TabIndex = 10;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // AddMealPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 208);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.y);
            this.Controls.Add(this.fat);
            this.Controls.Add(this.b);
            this.Controls.Add(this.water);
            this.Name = "AddMealPlan";
            this.Text = "AddMealPlan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox water;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox fat;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.TextBox cc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save;
    }
}