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
    public partial class UpdateAccountForm : Form
    {
        private Service1Client serviceClient = new Service1Client();
        private Account account;
        public UpdateAccountForm(Account account)
        {
            InitializeComponent();
            this.account = account;

            //show previous ac info
            ac_name.Text = account.ac_name;
            ac_type.Text = account.ac_type;
            ac_balance.Text = account.ac_balance.ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            account.ac_name = ac_name.Text;
            account.ac_type = ac_type.Text;
            account.ac_balance = Convert.ToDecimal(ac_balance.Text);

            
            try
            {
              
                serviceClient.UpdateAccount(account);

                MessageBox.Show("Account updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the update form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
