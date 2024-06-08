namespace PersonalFinanceClient
{
    partial class Form1
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
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtAccountType = new System.Windows.Forms.TextBox();
            this.txtAccountBalance = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GetAccount = new System.Windows.Forms.Button();
            this.ac_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(440, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(502, 145);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(100, 26);
            this.txtAccountName.TabIndex = 1;
            // 
            // txtAccountType
            // 
            this.txtAccountType.Location = new System.Drawing.Point(502, 208);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Size = new System.Drawing.Size(100, 26);
            this.txtAccountType.TabIndex = 2;
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Location = new System.Drawing.Point(502, 276);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.Size = new System.Drawing.Size(100, 26);
            this.txtAccountBalance.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(492, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(345, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Account name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(345, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Account type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(345, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Account balance";
            // 
            // GetAccount
            // 
            this.GetAccount.BackColor = System.Drawing.Color.DarkCyan;
            this.GetAccount.ForeColor = System.Drawing.SystemColors.Info;
            this.GetAccount.Location = new System.Drawing.Point(492, 534);
            this.GetAccount.Name = "GetAccount";
            this.GetAccount.Size = new System.Drawing.Size(96, 34);
            this.GetAccount.TabIndex = 8;
            this.GetAccount.Text = "Click here!!";
            this.GetAccount.UseVisualStyleBackColor = false;
            this.GetAccount.Click += new System.EventHandler(this.GetAccount_Click);
            // 
            // ac_id
            // 
            this.ac_id.Location = new System.Drawing.Point(488, 475);
            this.ac_id.Name = "ac_id";
            this.ac_id.Size = new System.Drawing.Size(100, 26);
            this.ac_id.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(332, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Already Have Account??Enter account id and click below.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 657);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ac_id);
            this.Controls.Add(this.GetAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAccountBalance);
            this.Controls.Add(this.txtAccountType);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtAccountType;
        private System.Windows.Forms.TextBox txtAccountBalance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GetAccount;
        private System.Windows.Forms.TextBox ac_id;
        private System.Windows.Forms.Label label5;
    }
}

