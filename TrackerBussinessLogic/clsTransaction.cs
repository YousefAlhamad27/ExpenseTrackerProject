using Microsoft.EntityFrameworkCore;
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
        public int? SubscriptionID { get; set; }



        public clsTransaction(int transactionID, DateTime date, decimal amount, int walletID, int categoryID, int transactionTypeID, string? description, int? subscriptionID)
        {
            TransactionID = transactionID;
            Date = date;
            Amount = amount;
            WalletID = walletID;
            CategoryID = categoryID;
            TransactionTypeID = transactionTypeID;
            Description = description;
            SubscriptionID = subscriptionID;
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
            SubscriptionID = null;
        }

        static public bool NullifySubscriptionID(int subscriptionID)
        {
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    _context.Transactions
                 .Where(t => t.SubscriptionID == subscriptionID)
                 .ExecuteUpdate(s => s.SetProperty(t => t.SubscriptionID, (int?)null));

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        static public bool DeleteBySubscriptionID(int subscriptionID)
        {
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                   clsTransaction lastTransaction =  _context.Transactions
                 .Where(t => t.SubscriptionID == subscriptionID).OrderByDescending(t=>t.Date)
                 .FirstOrDefault()!;

                    if (lastTransaction != null)
                    {
                        _context.Transactions.Remove(lastTransaction);
                        _context.SaveChanges();
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
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
   
        public static bool DeleteAllTransactionsByWalletID(int walletID)
        {
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    var transactions = _context.Transactions.Where(t => t.WalletID == walletID).ToList();
                    _context.Transactions.RemoveRange(transactions);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        static public clsTransaction GetTransaction(int transactionID)
        {

            try
            {
                using (AppDbContext _context = new AppDbContext())
                {

                    return _context.Transactions.FirstOrDefault(t=>t.TransactionID==transactionID)!;

                } 
                
            }
            catch
            {
                return null!;
            }



        }
        public static List<clsTransaction> GetAllTransactions()
        {
            using (var _context = new AppDbContext(DatabaseConfig.Options))
            {
                return _context.Transactions.OrderByDescending(t => t.Date).ToList();
            }
        }
        public static List<clsTransaction> GetAll30DaysCat(int categoryID,int typeID)
        {
            using (var _context = new AppDbContext(DatabaseConfig.Options))
            {
                return _context.Transactions.ToList().Where(t => t.Date >= DateTime.Now.AddDays(-30) &&t.CategoryID==categoryID&&t.TransactionTypeID==typeID).OrderByDescending(t => t.Date).ToList();
            }
        }

        public static List<clsTransaction> GetAll30Days(int walletID)
        {
            using (var _context = new AppDbContext(DatabaseConfig.Options))
            {
                return _context.Transactions.ToList().Where(t=>t.Date>= DateTime.Now.AddDays(-30)&&t.WalletID==walletID).OrderByDescending(t=>t.Date).ToList();
            }
        }
    }
}
