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
    public partial class Form1 : Form
    {
        private Service1Client serviceClient = new Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Account account = new Account
            {
                ac_name = txtAccountName.Text,
                ac_type = txtAccountType.Text,
                ac_balance = Convert.ToDecimal(txtAccountBalance.Text)
            };

            try
            {
                Account createdAccount = serviceClient.CreateAccount(account);

                MessageBox.Show("Account created successfully with ID: " + account.ac_id.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ClearForm()
        {
            txtAccountName.Clear();
            txtAccountType.Clear();
            txtAccountBalance.Clear();
        }

        private void GetAccount_Click(object sender, EventArgs e)
        {
            int accountId = Convert.ToInt32(ac_id.Text); //for ac_id field

            try
            {
                
                Account retrievedAccount = serviceClient.GetAccount(accountId);

                if (retrievedAccount != null)
                {

                   //dislay ac info
                    MessageBox.Show($"Account ID: {retrievedAccount.ac_id}\nName: {retrievedAccount.ac_name}\nType: {retrievedAccount.ac_type}\nBalance: {retrievedAccount.ac_balance}", "Account Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetAccountF getAccount = new GetAccountF(retrievedAccount);
                    getAccount.AccountId = accountId;
                    getAccount.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Display error message if retrieval fails
                MessageBox.Show("Failed to retrieve account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
