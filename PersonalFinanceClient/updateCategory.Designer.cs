namespace PersonalFinanceClient
{
    partial class updateCategory
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
            this.c_name = new System.Windows.Forms.TextBox();
            this.cnm = new System.Windows.Forms.Label();
            this.updateCat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.req_amt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // c_name
            // 
            this.c_name.Location = new System.Drawing.Point(400, 94);
            this.c_name.Name = "c_name";
            this.c_name.Size = new System.Drawing.Size(100, 26);
            this.c_name.TabIndex = 0;
            // 
            // cnm
            // 
            this.cnm.AutoSize = true;
            this.cnm.Location = new System.Drawing.Point(237, 94);
            this.cnm.Name = "cnm";
            this.cnm.Size = new System.Drawing.Size(119, 20);
            this.cnm.TabIndex = 1;
            this.cnm.Text = "Category Name";
            // 
            // updateCat
            // 
            this.updateCat.Location = new System.Drawing.Point(308, 235);
            this.updateCat.Name = "updateCat";
            this.updateCat.Size = new System.Drawing.Size(139, 32);
            this.updateCat.TabIndex = 2;
            this.updateCat.Text = "Update Category";
            this.updateCat.UseVisualStyleBackColor = true;
            this.updateCat.Click += new System.EventHandler(this.updateCat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Require Amount";
            // 
            // req_amt
            // 
            this.req_amt.Location = new System.Drawing.Point(400, 159);
            this.req_amt.Name = "req_amt";
            this.req_amt.Size = new System.Drawing.Size(100, 26);
            this.req_amt.TabIndex = 4;
            // 
            // updateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.req_amt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateCat);
            this.Controls.Add(this.cnm);
            this.Controls.Add(this.c_name);
            this.Name = "updateCategory";
            this.Text = "updateCat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox c_name;
        private System.Windows.Forms.Label cnm;
        private System.Windows.Forms.Button updateCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox req_amt;
    }
}