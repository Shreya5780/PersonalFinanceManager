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
    public partial class AddCategoryF : Form
    {
        private int accountId;
        private Service1Client serviceClient = new Service1Client();
        public AddCategoryF(int accountId)
        {
            InitializeComponent();
            this.accountId = accountId;
        }

        private void addCat_Click(object sender, EventArgs e)
        {
            Category category = new Category
            {
                c_name = cat_nm.Text,
                ac_id = Convert.ToInt32(accountId),
                reqAmt = Convert.ToDecimal(reqAmt.Text)
            };

            try
            {
                // service  to create account
                Category addCategory = serviceClient.AddCategory(category);

                //message
                MessageBox.Show("Account created successfully with ID: " + category.c_id.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                ClearForm();
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Failed to create account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ClearForm()
        {
            cat_nm.Clear();
            reqAmt.Clear();
            /*ac_idCat.Clear();*/
        }

        private void Back_Click(object sender, EventArgs e)
        {
            CategoryF form1 = new CategoryF(accountId);
            form1.Show();
            this.Close();
        }
    }
}
