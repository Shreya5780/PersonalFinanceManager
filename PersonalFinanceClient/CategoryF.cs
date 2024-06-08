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
    public partial class CategoryF : Form
    {
        private Account account;
        private int accountId;
        private Service1Client serviceClient = new Service1Client();
        private List<Category> categories = new List<Category>();
        /*private List<Category> categories;*/
        public CategoryF(int accountId)
        {
            InitializeComponent();
            this.accountId = accountId;
            LoadCategories(accountId);
            //show previous ac info
           /* ac_id.Text = account.ac_id.ToString();
            ac_name.Text = account.ac_name;
            ac_balance.Text = account.ac_balance.ToString();*/
/*
            accountId = account.ac_id;
            textBox1.Text = accountId.ToString();*/
        }
        private void LoadCategories(int accountId)
        {
            this.accountId = accountId;
            try
            {
                // Retrieve  categories
                Category[] categoryArray = serviceClient.GetCategoriesByAccountId(accountId);
                categories = new List<Category>(categoryArray);

              
                panel1.Controls.Clear();

                
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.Dock = DockStyle.Fill; 
                tableLayoutPanel.AutoSize = true; 
                tableLayoutPanel.ColumnCount = 3; 

                
                panel1.Controls.Add(tableLayoutPanel);

               
                foreach (Category category in categories)
                {
                    //  category name
                    Label label = new Label();
                    label.Text = category.c_name;

                    // update button
                    Button updateButton = new Button();
                    updateButton.Text = "Update";
                    updateButton.Tag = category;
                    updateButton.Click += UpdateButton_Click;

                    //  delete button
                    Button deleteButton = new Button();
                    deleteButton.Text = "Delete";
                    deleteButton.Tag = category;
                    deleteButton.Click += DeleteButton_Click;

                    
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    tableLayoutPanel.Controls.Add(label);
                    tableLayoutPanel.Controls.Add(updateButton);
                    tableLayoutPanel.Controls.Add(deleteButton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to retrieve categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            /*this.account = account;
            GetAccountF getAccount = new GetAccountF(account);
            getAccount.Show();
            this.Close();*/
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            AddCategoryF Category = new AddCategoryF(accountId);
            Category.Show();
            this.Close();
            /* AddCategoryF addCategoryForm = new AddCategoryF();
             if (addCategoryForm.ShowDialog() == DialogResult.OK)
             {
                 Category newCategory = addCategoryForm.GetCategory();
                 categories.Add(newCategory);
                 // You can do further processing here if needed
             }*/

        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
           
            Button updateButton = sender as Button;

            Category category = updateButton.Tag as Category;

            updateCategory updateForm = new updateCategory(category);

            updateForm.FormClosed += UpdateForm_FormClosed;

            updateForm.ShowDialog();
        }

        private void UpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadCategories(accountId);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Button deleteButton = sender as Button;
            Category category = deleteButton.Tag as Category;

            DialogResult result = MessageBox.Show($"Are you sure you want to delete category: {category.c_name}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    serviceClient.DeleteCategory(category.c_id);
                    LoadCategories(accountId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
