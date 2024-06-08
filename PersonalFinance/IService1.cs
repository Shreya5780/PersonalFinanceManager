using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PersonalFinance
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Account CreateAccount(Account account);

        [OperationContract]
        Account GetAccount(int id);

        [OperationContract]
        Account UpdateAccount(Account account);

        [OperationContract]
        void DeleteAccount(int id);

        //category crud
        [OperationContract]
        List<Category> GetAllCategories();

        [OperationContract]
        List<Category> GetCategoriesByAccountId(int accountId);

        [OperationContract]
        Category AddCategory(Category category);

        [OperationContract]
        Category UpdateCategory(Category category);

        [OperationContract]
        void DeleteCategory(int c_id);

        // CRUD operations for transactions
        [OperationContract]
       Transaction AddTransaction(Transaction transaction, bool isExpence);
        [OperationContract]

        List<Transaction> GetAllTransactions();

        [OperationContract]

        List<Transaction> GetTransactionsByAccountId(int accountId);

       /* [OperationContract]
        void DeleteTransaction(int t_id);*/
        // TODO: Add your service operations here
    }
    [DataContract]
    public class Account
    {
        [DataMember]
        public int ac_id { get; set; }
        [DataMember]
        public string ac_name { get; set; }
        [DataMember]

        public string ac_type { get; set; }
        [DataMember]

        public decimal ac_balance { get; set; }
    }

    [DataContract]
    public class Category
    {
        [DataMember]
        public int c_id { get; set; }
        [DataMember]
        public string c_name { get; set; }
        [DataMember]
        public decimal reqAmt { get; set; }
        [DataMember]
        public int ac_id { get; set; }
    }

    [DataContract]
    public class Transaction
    {
        [DataMember]
        public int t_id { get; set; }
        [DataMember]
        public int t_amt { get; set; }
        [DataMember]
        public bool ExpenceIncome { get; set; }
        [DataMember]
        public int c_id { get; set; } // Foreign key referencing finaceCategory table
        [DataMember]
        public int ac_id { get; set; } // Foreign key referencing accounts table
        [DataMember]
        public DateTime t_date { get; set; }
        
       
    }

}
