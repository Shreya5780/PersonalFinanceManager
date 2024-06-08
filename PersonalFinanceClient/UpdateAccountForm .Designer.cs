namespace PersonalFinanceClient
{
    partial class UpdateAccountForm
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
            this.ac_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ac_type = new System.Windows.Forms.TextBox();
            this.ac_balance = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ac_name
            // 
            this.ac_name.Location = new System.Drawing.Point(423, 131);
            this.ac_name.Name = "ac_name";
            this.ac_name.Size = new System.Drawing.Size(100, 26);
            this.ac_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Account name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Account type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Account Balance";
            // 
            // ac_type
            // 
            this.ac_type.Location = new System.Drawing.Point(423, 209);
            this.ac_type.Name = "ac_type";
            this.ac_type.Size = new System.Drawing.Size(100, 26);
            this.ac_type.TabIndex = 9;
            // 
            // ac_balance
            // 
            this.ac_balance.Location = new System.Drawing.Point(423, 280);
            this.ac_balance.Name = "ac_balance";
            this.ac_balance.Size = new System.Drawing.Size(100, 26);
            this.ac_balance.TabIndex = 10;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.DarkCyan;
            this.update.Location = new System.Drawing.Point(423, 372);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(88, 35);
            this.update.TabIndex = 11;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DarkCyan;
            this.Back.Location = new System.Drawing.Point(88, 57);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(92, 32);
            this.Back.TabIndex = 12;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Update Account";
            // 
            // UpdateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.update);
            this.Controls.Add(this.ac_balance);
            this.Controls.Add(this.ac_type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ac_name);
            this.Name = "UpdateAccountForm";
            this.Text = "Update Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ac_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ac_type;
        private System.Windows.Forms.TextBox ac_balance;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
    }
}