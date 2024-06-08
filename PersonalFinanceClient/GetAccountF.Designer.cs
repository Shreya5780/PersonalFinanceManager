namespace PersonalFinanceClient
{
    partial class GetAccountF
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
            this.addTransaction = new System.Windows.Forms.Button();
            this.ac_id = new System.Windows.Forms.Label();
            this.ac_name = new System.Windows.Forms.Label();
            this.ac_type = new System.Windows.Forms.Label();
            this.ac_balance = new System.Windows.Forms.Label();
            this.delete_ac = new System.Windows.Forms.Button();
            this.updateAc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DarkCyan;
            this.Back.Location = new System.Drawing.Point(86, 53);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(92, 32);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // addCategory
            // 
            this.addCategory.BackColor = System.Drawing.Color.DarkCyan;
            this.addCategory.Location = new System.Drawing.Point(634, 52);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(148, 32);
            this.addCategory.TabIndex = 8;
            this.addCategory.Text = " Category";
            this.addCategory.UseVisualStyleBackColor = false;
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // addTransaction
            // 
            this.addTransaction.BackColor = System.Drawing.Color.DarkCyan;
            this.addTransaction.Location = new System.Drawing.Point(858, 52);
            this.addTransaction.Name = "addTransaction";
            this.addTransaction.Size = new System.Drawing.Size(149, 33);
            this.addTransaction.TabIndex = 9;
            this.addTransaction.Text = " Transaction";
            this.addTransaction.UseVisualStyleBackColor = false;
            this.addTransaction.Click += new System.EventHandler(this.addTransaction_Click);
            // 
            // ac_id
            // 
            this.ac_id.AutoSize = true;
            this.ac_id.Location = new System.Drawing.Point(493, 182);
            this.ac_id.Name = "ac_id";
            this.ac_id.Size = new System.Drawing.Size(47, 20);
            this.ac_id.TabIndex = 10;
            this.ac_id.Text = "ac_id";
            // 
            // ac_name
            // 
            this.ac_name.AutoSize = true;
            this.ac_name.Location = new System.Drawing.Point(493, 229);
            this.ac_name.Name = "ac_name";
            this.ac_name.Size = new System.Drawing.Size(75, 20);
            this.ac_name.TabIndex = 11;
            this.ac_name.Text = "ac_name";
            // 
            // ac_type
            // 
            this.ac_type.AutoSize = true;
            this.ac_type.Location = new System.Drawing.Point(493, 276);
            this.ac_type.Name = "ac_type";
            this.ac_type.Size = new System.Drawing.Size(65, 20);
            this.ac_type.TabIndex = 12;
            this.ac_type.Text = "ac_type";
            // 
            // ac_balance
            // 
            this.ac_balance.AutoSize = true;
            this.ac_balance.Location = new System.Drawing.Point(493, 330);
            this.ac_balance.Name = "ac_balance";
            this.ac_balance.Size = new System.Drawing.Size(91, 20);
            this.ac_balance.TabIndex = 13;
            this.ac_balance.Text = "ac_balance";
            // 
            // delete_ac
            // 
            this.delete_ac.BackColor = System.Drawing.Color.DarkCyan;
            this.delete_ac.Location = new System.Drawing.Point(474, 386);
            this.delete_ac.Name = "delete_ac";
            this.delete_ac.Size = new System.Drawing.Size(94, 37);
            this.delete_ac.TabIndex = 14;
            this.delete_ac.Text = "Delete";
            this.delete_ac.UseVisualStyleBackColor = false;
            this.delete_ac.Click += new System.EventHandler(this.delete_ac_Click);
            // 
            // updateAc
            // 
            this.updateAc.BackColor = System.Drawing.Color.DarkCyan;
            this.updateAc.Location = new System.Drawing.Point(474, 464);
            this.updateAc.Name = "updateAc";
            this.updateAc.Size = new System.Drawing.Size(151, 38);
            this.updateAc.TabIndex = 15;
            this.updateAc.Text = "Update Account";
            this.updateAc.UseVisualStyleBackColor = false;
            this.updateAc.Click += new System.EventHandler(this.updateAc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Your Account info.";
            // 
            // GetAccountF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 672);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateAc);
            this.Controls.Add(this.delete_ac);
            this.Controls.Add(this.ac_balance);
            this.Controls.Add(this.ac_type);
            this.Controls.Add(this.ac_name);
            this.Controls.Add(this.ac_id);
            this.Controls.Add(this.addTransaction);
            this.Controls.Add(this.addCategory);
            this.Controls.Add(this.Back);
            this.Name = "GetAccountF";
            this.Text = "GetAccountF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button addCategory;
        private System.Windows.Forms.Button addTransaction;
        private System.Windows.Forms.Label ac_id;
        private System.Windows.Forms.Label ac_name;
        private System.Windows.Forms.Label ac_type;
        private System.Windows.Forms.Label ac_balance;
        private System.Windows.Forms.Button delete_ac;
        private System.Windows.Forms.Button updateAc;
        private System.Windows.Forms.Label label1;
    }
}