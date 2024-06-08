namespace PersonalFinanceClient
{
    partial class CategoryF
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
            this.Back = new System.Windows.Forms.Button();
            this.addCategory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DarkCyan;
            this.Back.Location = new System.Drawing.Point(12, 37);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(92, 32);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // addCategory
            // 
            this.addCategory.BackColor = System.Drawing.Color.DarkCyan;
            this.addCategory.Location = new System.Drawing.Point(756, 37);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(139, 32);
            this.addCategory.TabIndex = 7;
            this.addCategory.Text = "Add Category";
            this.addCategory.UseVisualStyleBackColor = false;
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(141, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 427);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "All Category";
            // 
            // CategoryF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addCategory);
            this.Controls.Add(this.Back);
            this.Name = "CategoryF";
            this.Text = "CategoryF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button addCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}