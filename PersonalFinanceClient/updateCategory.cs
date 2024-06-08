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
    public partial class updateCategory : Form
    {
        private Service1Client serviceClient = new Service1Client();
        private Category category;
        public updateCategory(Category category)
        {
            this.category = category;
            InitializeComponent();
            //display already have info
            c_name.Text = category.c_name;
            req_amt.Text = category.reqAmt.ToString();
            
        }

        private void updateCat_Click(object sender, EventArgs e)
        {
            category.c_name = c_name.Text;
            category.reqAmt = Convert.ToDecimal(req_amt.Text);


            try
            {

                serviceClient.UpdateCategory(category);

                MessageBox.Show("category updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the update form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
