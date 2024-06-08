namespace PersonalFinanceClient
{
    partial class TransactionF
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
            this.ac_id = new System.Windows.Forms.TextBox();
            this.c_id = new System.Windows.Forms.TextBox();
            this.ExpenceIncome = new System.Windows.Forms.TextBox();
            this.t_amt = new System.Windows.Forms.TextBox();
            this.addTr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AllTr = new System.Windows.Forms.Button();
            this.ac_idForGetTr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DarkCyan;
            this.Back.Location = new System.Drawing.Point(76, 52);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(92, 32);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ac_id
            // 
            this.ac_id.Location = new System.Drawing.Point(526, 167);
            this.ac_id.Name = "ac_id";
            this.ac_id.Size = new System.Drawing.Size(100, 26);
            this.ac_id.TabIndex = 12;
            // 
            // c_id
            // 
            this.c_id.Location = new System.Drawing.Point(526, 251);
            this.c_id.Name = "c_id";
            this.c_id.Size = new System.Drawing.Size(100, 26);
            this.c_id.TabIndex = 13;
            // 
            // ExpenceIncome
            // 
            this.ExpenceIncome.Location = new System.Drawing.Point(526, 323);
            this.ExpenceIncome.Name = "ExpenceIncome";
            this.ExpenceIncome.Size = new System.Drawing.Size(100, 26);
            this.ExpenceIncome.TabIndex = 14;
            // 
            // t_amt
            // 
            this.t_amt.Location = new System.Drawing.Point(526, 397);
            this.t_amt.Name = "t_amt";
            this.t_amt.Size = new System.Drawing.Size(100, 26);
            this.t_amt.TabIndex = 15;
            // 
            // addTr
            // 
            this.addTr.BackColor = System.Drawing.Color.DarkCyan;
            this.addTr.Location = new System.Drawing.Point(476, 503);
            this.addTr.Name = "addTr";
            this.addTr.Size = new System.Drawing.Size(91, 38);
            this.addTr.TabIndex = 17;
            this.addTr.Text = "Add";
            this.addTr.UseVisualStyleBackColor = false;
            this.addTr.Click += new System.EventHandler(this.addTr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Add transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "ac_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "c_id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "ExpenceIncome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Amount";
            // 
            // AllTr
            // 
            this.AllTr.BackColor = System.Drawing.Color.DarkCyan;
            this.AllTr.Location = new System.Drawing.Point(860, 198);
            this.AllTr.Name = "AllTr";
            this.AllTr.Size = new System.Drawing.Size(143, 57);
            this.AllTr.TabIndex = 24;
            this.AllTr.Text = "See All Transaction";
            this.AllTr.UseVisualStyleBackColor = false;
            this.AllTr.Click += new System.EventHandler(this.AllTr_Click);
            // 
            // ac_idForGetTr
            // 
            this.ac_idForGetTr.Location = new System.Drawing.Point(878, 141);
            this.ac_idForGetTr.Name = "ac_idForGetTr";
            this.ac_idForGetTr.Size = new System.Drawing.Size(100, 26);
            this.ac_idForGetTr.TabIndex = 25;
            // 
            // TransactionF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 686);
            this.Controls.Add(this.ac_idForGetTr);
            this.Controls.Add(this.AllTr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addTr);
            this.Controls.Add(this.t_amt);
            this.Controls.Add(this.ExpenceIncome);
            this.Controls.Add(this.c_id);
            this.Controls.Add(this.ac_id);
            this.Controls.Add(this.Back);
            this.Name = "TransactionF";
            this.Text = "TransactionF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox ac_id;
        private System.Windows.Forms.TextBox c_id;
        private System.Windows.Forms.TextBox ExpenceIncome;
        private System.Windows.Forms.TextBox t_amt;
        private System.Windows.Forms.Button addTr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AllTr;
        private System.Windows.Forms.TextBox ac_idForGetTr;
    }
}