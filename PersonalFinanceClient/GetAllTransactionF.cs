using PersonalFinanceClient.FinanceService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceClient
{
    public partial class GetAllTransactionF : Form
    {
        private int accountId;
        private Service1Client serviceClient = new Service1Client();
        public GetAllTransactionF(int accountId)
        {
            this.accountId = accountId;
            InitializeComponent();
            LoadTransactions(accountId);
        }


        private void LoadTransactions(int accountId)
        {
            this.accountId = accountId;
            try
            {
               // all transactions
                Transaction[] transactionArray = serviceClient.GetTransactionsByAccountId(accountId);
                List<Transaction> transactions = new List<Transaction>(transactionArray);

               
                panel2.Controls.Clear();

                
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.Dock = DockStyle.Fill; 
                tableLayoutPanel.AutoSize = true; 
                tableLayoutPanel.ColumnCount = 4; // Four columns 

              
                panel2.Controls.Add(tableLayoutPanel);

              
                foreach (Transaction transaction in transactions)
                {
                   
                    Label expenceIncomeLabel = new Label();
                    expenceIncomeLabel.Text = transaction.ExpenceIncome ? "Income" : "Expense";

                    Label amountLabel = new Label();
                    amountLabel.Text = transaction.t_amt.ToString("C"); // Format amount as currency

                    Label dateLabel = new Label();
                    dateLabel.Text = transaction.t_date.ToShortDateString(); // Format date

                    Label categoryLabel = new Label();
                    categoryLabel.Text = transaction.t_id.ToString();

                    // Create action buttons (example buttons, replace with actual functionality)
                    /*  Button editButton = new Button();
                      editButton.Text = "Edit";
                      editButton.Tag = transaction;
                      editButton.Click += EditButton_Click;*/

                   /* Button deleteButton = new Button();
                    deleteButton.Text = "Delete";
                    deleteButton.Tag = transaction;
                    deleteButton.Click += DeleteButton_Click;*/

                  
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    tableLayoutPanel.Controls.Add(expenceIncomeLabel);
                    tableLayoutPanel.Controls.Add(amountLabel);
                    tableLayoutPanel.Controls.Add(dateLabel);
                    tableLayoutPanel.Controls.Add(categoryLabel);
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to retrieve transactions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       /* private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Handle delete button click event here
            Button deleteButton = sender as Button;
            Transaction transaction = deleteButton.Tag as Transaction;

            // Example: Confirm deletion and call service method to delete category
            DialogResult result = MessageBox.Show($"Are you sure you want to delete transaction: {transaction.t_id}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Call service method to delete category
                    serviceClient.DeleteTransaction(transaction.t_id);
                    // Reload categories after deletion
                    LoadTransactions(accountId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
*/

            private void GetAllTransactionF_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            
            TransactionF form1 = new TransactionF();
            form1.Show();
            this.Close();
        }
    }


}
