using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerBussinessLogic
{
    public class clsTransaction
    {
        public enum TransactionType
        {
            Income = 1,
            Expense = 2,
            Transfer = 3
        }
        public int TransactionID { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int WalletID { get; set; }
        public int CategoryID { get; set; }
        public int TransactionTypeID { get; set; }
        public string? Description { get; set; }



        public clsTransaction(int transactionID, DateTime date, decimal amount, int walletID, int categoryID, int transactionTypeID, string? description )
        {
            TransactionID = transactionID;
            Date = date;
            Amount = amount;
            WalletID = walletID;
            CategoryID = categoryID;
            TransactionTypeID = transactionTypeID;
            Description = description;
        
        }
        public clsTransaction()
        {
            TransactionID = 0;
            Date = DateTime.Now;
            Amount = 0;
            WalletID = 0;
            CategoryID = 0;
            TransactionTypeID = 0;
            Description = "";
        }

        public bool Save()
        {

            try
            {
                using(var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    if (TransactionID <= 0)
                    {
                         _context.Transactions.Add(this);
                        
                    }
                    else
                    {
                        _context.Transactions.Update(this);  
                    }
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool Delete()
        {
            try
            {
                using (AppDbContext _context = new AppDbContext(DatabaseConfig.Options))
                {
                    clsTransaction transaction = _context.Transactions.Find(this.TransactionID)!;
                    if (transaction != null)
                    {
                        _context.Transactions.Remove(transaction);
                        _context.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public static List<clsTransaction> GetAllTransactions()
        {
            using (var _context = new AppDbContext(DatabaseConfig.Options))
            {
                return _context.Transactions.ToList();
            }
        }
        public static List<clsTransaction> GetAll30Days()
        {
            using (var _context = new AppDbContext(DatabaseConfig.Options))
            {
                return _context.Transactions.ToList().Where(t=>t.Date>= DateTime.Now.AddDays(-30)).ToList();
            }
        }

    }
}
