namespace PersonalFinanceClient
{
    partial class GetAllTransactionF
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(169, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 539);
            this.panel2.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DarkCyan;
            this.Back.Location = new System.Drawing.Point(36, 35);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(92, 32);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "All transaction";
            // 
            // GetAllTransactionF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 656);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.panel2);
            this.Name = "GetAllTransactionF";
            this.Text = "GetAllTransactionF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
    }
}