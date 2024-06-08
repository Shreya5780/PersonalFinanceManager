namespace PersonalFinanceClient
{
    partial class AddCategoryF
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
            this.cat_nm = new System.Windows.Forms.TextBox();
            this.reqAmt = new System.Windows.Forms.TextBox();
            this.addCat = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Category";
            // 
            // cat_nm
            // 
            this.cat_nm.Location = new System.Drawing.Point(484, 177);
            this.cat_nm.Name = "cat_nm";
            this.cat_nm.Size = new System.Drawing.Size(100, 26);
            this.cat_nm.TabIndex = 1;
            // 
            // reqAmt
            // 
            this.reqAmt.Location = new System.Drawing.Point(484, 262);
            this.reqAmt.Name = "reqAmt";
            this.reqAmt.Size = new System.Drawing.Size(100, 26);
            this.reqAmt.TabIndex = 2;
            // 
            // addCat
            // 
            this.addCat.BackColor = System.Drawing.Color.DarkCyan;
            this.addCat.Location = new System.Drawing.Point(410, 359);
            this.addCat.Name = "addCat";
            this.addCat.Size = new System.Drawing.Size(138, 31);
            this.addCat.TabIndex = 4;
            this.addCat.Text = "Add Category";
            this.addCat.UseVisualStyleBackColor = false;
            this.addCat.Click += new System.EventHandler(this.addCat_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DarkCyan;
            this.Back.Location = new System.Drawing.Point(86, 37);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(92, 32);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Req. Amt";
            // 
            // AddCategoryF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 624);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.addCat);
            this.Controls.Add(this.reqAmt);
            this.Controls.Add(this.cat_nm);
            this.Controls.Add(this.label1);
            this.Name = "AddCategoryF";
            this.Text = "AddCategoryF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cat_nm;
        private System.Windows.Forms.TextBox reqAmt;
        private System.Windows.Forms.Button addCat;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}