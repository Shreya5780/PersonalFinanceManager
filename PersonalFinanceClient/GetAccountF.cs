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
    public partial class GetAccountF : Form
    {
        private Service1Client serviceClient = new Service1Client();
        private Account account;
        public int AccountId { get; set; }
        public GetAccountF(Account account)
        {
            InitializeComponent();
            this.account = account;
            ac_id.Text = "Account ID: " + /*AccountId*/   account.ac_id.ToString();
            ac_name.Text = "Name: " + account.ac_name;
            ac_type.Text = "Type: " + account.ac_type;
            ac_balance.Text = "Balance: " + account.ac_balance.ToString();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Form1 form1 = new Form1();
            form1.Close(); // Close Form1
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            CategoryF Category = new CategoryF(AccountId);
            Category.Show();
            this.Close();
        }

        private void addTransaction_Click(object sender, EventArgs e)
        {
            TransactionF Transaction = new TransactionF();
            Transaction.Show();
            this.Close();
        }

        private void delete_ac_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {

                    serviceClient.DeleteAccount(account.ac_id);

                    MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close(); // Close the form

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void updateAc_Click(object sender, EventArgs e)
        {
            UpdateAccountForm updateForm = new UpdateAccountForm(account);
            updateForm.ShowDialog();

            // Refresh the displayed account information after update
            ac_name.Text = "Name: " + account.ac_name;
            ac_type.Text = "Type: " + account.ac_type;
            ac_balance.Text = "Balance: " + account.ac_balance.ToString();
        }
    }
}
