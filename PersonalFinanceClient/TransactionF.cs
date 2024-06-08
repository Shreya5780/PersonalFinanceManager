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
    public partial class TransactionF : Form
    {
        private Service1Client serviceClient = new Service1Client();
        private Account account;
        public TransactionF()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            /* this.account = account;
             GetAccountF getAccount = new GetAccountF(account);
             getAccount.Show();
             this.Close();*/
        }

        private void addTr_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction
            {
                c_id = Convert.ToInt32(c_id.Text),
                ac_id = Convert.ToInt32(ac_id.Text),
                t_amt = Convert.ToInt32(t_amt.Text),
                /*t_date = DateTime.Parse(t_date.Text),*/
               
               
            };

            try
            {
                bool isExpense = (ExpenceIncome.Text == "Expense");
                Transaction addedTransaction = serviceClient.AddTransaction(transaction, isExpense);

                MessageBox.Show("Transaction added successfully with ID: " + addedTransaction.t_id.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                // Display error message if transaction addition fails
                MessageBox.Show("Failed to add transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            ac_id.Clear();
            c_id.Clear();
            ExpenceIncome.Clear();
            t_amt.Clear();
            /*t_date.Clear();*/
            /*ac_idCat.Clear();*/
        }

        private void AllTr_Click(object sender, EventArgs e)
        {
            int accountId;
            /*= Convert.ToInt32(ac_idForGetTr.Text);*/
            if (!int.TryParse(ac_idForGetTr.Text, out accountId))
            {
                MessageBox.Show("Please enter a valid account ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GetAllTransactionF getAllTr = new GetAllTransactionF(accountId);
            getAllTr.Show();
            this.Close();
        }

       
    }
}
