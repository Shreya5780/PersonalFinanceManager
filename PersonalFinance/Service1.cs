using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PersonalFinance
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private string connectionString = "Data Source=DESKTOP-ALQPLAM\\SQLEXPRESS;Initial Catalog=Finance;User ID=smc;Password=12345678";
        public Account CreateAccount(Account account)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Accounts (ac_name, ac_type, ac_balance) VALUES (@Name, @Type, @Balance)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", account.ac_name);
                command.Parameters.AddWithValue("@Type", account.ac_type);
                command.Parameters.AddWithValue("@Balance", account.ac_balance);

                connection.Open();


                command.ExecuteNonQuery();
                return account;
            }
        }

        public Account GetAccount(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ac_id, ac_name, ac_type, ac_balance FROM Accounts WHERE ac_id = @ac_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ac_id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Account account = new Account
                    {
                        ac_id = Convert.ToInt32(reader["ac_id"]),
                        ac_name = reader["ac_name"].ToString(),
                        ac_type = reader["ac_type"].ToString(),
                        ac_balance = Convert.ToDecimal(reader["ac_balance"])
                    };
                    return account;
                }
                else
                {
                    return null;
                }
            }
        }

        public Account UpdateAccount(Account account)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Accounts SET ac_name = @Name, ac_type = @Type, ac_balance = @Balance WHERE ac_id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", account.ac_name);
                command.Parameters.AddWithValue("@Type", account.ac_type);
                command.Parameters.AddWithValue("@Balance", account.ac_balance);
                command.Parameters.AddWithValue("@Id", account.ac_id);

                connection.Open();
                command.ExecuteNonQuery();
                return account;
            }
        }

        public void DeleteAccount(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Accounts WHERE ac_id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        //now crud on category
        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT c_id, c_name, reqAmt, ac_id FROM Category";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Category category = new Category();
                    category.c_id = Convert.ToInt32(reader["c_id"]);
                    category.c_name = reader["c_name"].ToString();
                    category.reqAmt = reader["reqAmt"] != DBNull.Value ? Convert.ToDecimal(reader["reqAmt"]) : 0;
                    category.ac_id = reader["ac_id"] != DBNull.Value ? Convert.ToInt32(reader["ac_id"]) : 0;
                    categories.Add(category);
                }
            }

            return categories;
        }

        public List<Category> GetCategoriesByAccountId(int accountId)
        {
            List<Category> categories = new List<Category>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT c_id, c_name, reqAmt, ac_id FROM Category WHERE ac_id = @AccountId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountId", accountId);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Category category = new Category();
                    category.c_id = Convert.ToInt32(reader["c_id"]);
                    category.c_name = reader["c_name"].ToString();
                    category.reqAmt = reader["reqAmt"] != DBNull.Value ? Convert.ToDecimal(reader["reqAmt"]) : 0;
                    category.ac_id = reader["ac_id"] != DBNull.Value ? Convert.ToInt32(reader["ac_id"]) : 0;
                    categories.Add(category);
                }
            }

            return categories;
        }


        public Category AddCategory(Category category)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Category (c_name, reqAmt, ac_id) VALUES (@c_name, @reqAmt, @ac_id)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@c_name", category.c_name);
                command.Parameters.AddWithValue("@reqAmt", category.reqAmt);
                command.Parameters.AddWithValue("@ac_id", category.ac_id);
                connection.Open();
                command.ExecuteNonQuery();
                return category;
            }
        }

        public Category UpdateCategory(Category category)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Category SET c_name = @c_name, reqAmt = @reqAmt, ac_id = @ac_id WHERE c_id = @c_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@c_id", category.c_id);
                command.Parameters.AddWithValue("@c_name", category.c_name);
                command.Parameters.AddWithValue("@reqAmt", category.reqAmt);
                command.Parameters.AddWithValue("@ac_id", category.ac_id);
                connection.Open();
                command.ExecuteNonQuery();
                return category;
            }
        }

        public void DeleteCategory(int c_id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Category WHERE c_id = @c_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@c_id", c_id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        //now for transaction
        /*public void DeleteTransaction(int t_id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Transaction WHERE t_id = @t_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@t_id", t_id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }*/

        public Transaction AddTransaction(Transaction transaction, bool isExpense)
        {
            // Determine the sign for balance update
            int sign = isExpense ? -1 : 1;

            // Add the transaction to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [Transaction] (t_amt, ExpenceIncome, c_id, ac_id, t_date) VALUES (@t_amt, @ExpenceIncome, @c_id, @ac_id, @t_date)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@t_amt", transaction.t_amt);
                command.Parameters.AddWithValue("@ExpenceIncome", isExpense);
                command.Parameters.AddWithValue("@c_id", transaction.c_id);
                command.Parameters.AddWithValue("@ac_id", transaction.ac_id);
                command.Parameters.AddWithValue("@t_date", DateTime.Now); // Assuming current date/time
                connection.Open();
                command.ExecuteNonQuery();
            }

            // Update the account balance
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE Accounts SET ac_balance = ac_balance + @change WHERE ac_id = @ac_id";

                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@change", sign * transaction.t_amt);
                updateCommand.Parameters.AddWithValue("@ac_id", transaction.ac_id);
                connection.Open();
                updateCommand.ExecuteNonQuery();
            }
            // Update the category reqAmt based on the transaction type
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string updateCategoryQuery = "UPDATE Category SET reqAmt = reqAmt ";
                updateCategoryQuery += isExpense ? "- @change" : "+ @change";
                updateCategoryQuery += " WHERE c_id = @c_id";

                SqlCommand updateCategoryCommand = new SqlCommand(updateCategoryQuery, connection);
                updateCategoryCommand.Parameters.AddWithValue("@change", transaction.t_amt);
                updateCategoryCommand.Parameters.AddWithValue("@c_id", transaction.c_id);
                connection.Open();
                updateCategoryCommand.ExecuteNonQuery();
            }


            return transaction;
        }

        public List<Transaction> GetAllTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [Transaction]";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Transaction transaction = new Transaction
                        {
                            t_id = Convert.ToInt32(reader["t_id"]),
                            t_amt = (int)Convert.ToDecimal(reader["t_amt"]),
                            ExpenceIncome = Convert.ToBoolean(reader["ExpenceIncome"]),
                            c_id = Convert.ToInt32(reader["c_id"]),
                            ac_id = Convert.ToInt32(reader["ac_id"]),
                            t_date = Convert.ToDateTime(reader["t_date"])
                        };

                        transactions.Add(transaction);
                    }
                }
            }

            return transactions;
        }
        public List<Transaction> GetTransactionsByAccountId(int accountId)
        {
            List<Transaction> transactions = new List<Transaction>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [Transaction] WHERE ac_id = @AccountId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountId", accountId);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Transaction transaction = new Transaction
                        {
                            t_id = Convert.ToInt32(reader["t_id"]),
                            t_amt = (int)Convert.ToDecimal(reader["t_amt"]),
                            ExpenceIncome = Convert.ToBoolean(reader["ExpenceIncome"]),
                            c_id = Convert.ToInt32(reader["c_id"]),
                            ac_id = Convert.ToInt32(reader["ac_id"]),
                            t_date = Convert.ToDateTime(reader["t_date"])
                        };

                        transactions.Add(transaction);
                    }
                }
            }

            return transactions;
        }




    }
}
