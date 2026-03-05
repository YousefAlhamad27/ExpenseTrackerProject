using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   

namespace TrackerBussinessLogic
{
    public class clsWallet
    {

        public int WalletID { get; set; }
        public string Name { get; set; }

        public decimal Balance { get; set; }

        public int CurrencyID { get; set; }

        public DateTime CreationDate { get; set; }

        public bool IsActive { get; set; } // New property to indicate if the wallet is deleted or not



        public clsWallet(int walletID, string name, decimal balance, int currencyID, DateTime creationDate,bool isactive)
        {
            WalletID = walletID;
            Name = name;
            Balance = balance;
            CurrencyID = currencyID;
            CreationDate = creationDate;
            IsActive = isactive;
        }
        static public int getCurrencyID(int walletID)
        {

            try
            {
                using (var context = new AppDbContext(DatabaseConfig.Options))
                {
                    return context.Wallets.FirstOrDefault(w => w.WalletID == walletID)!.CurrencyID;
                }

            }
            catch
            {
                return 1;
            }
        }
        public clsWallet()
        {
            WalletID = 0;
            Name = "";
            Balance = 0;
            CurrencyID = 0;
            CreationDate = DateTime.Now;
            IsActive = true;
        }
        public bool Save()
        {
            try
            {

                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    if (WalletID <= 0)
                    {
                        _context.Wallets.Add(this);

                    }
                    else
                    {
                        _context.Wallets.Update(this);
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
        static public List<clsWallet> GetAllWallets()
        {
            using (var _context = new AppDbContext(DatabaseConfig.Options))
            {
                return _context.Wallets.Where(w=>w.IsActive==true).ToList();
            }
        }
        static public clsWallet? GetWalletByID(int walletID)
        {
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    return _context.Wallets.Find(walletID);
                }
            }
            catch
            {
                return null;
            }
        }
        public bool DeleteWallet()
        {
                       try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    _context.Wallets.Remove(this);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveWallet()
        {
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    
                    clsWallet wallet = _context.Wallets.Find(this.WalletID)!;
                    if (wallet != null)
                    {
                        wallet.IsActive = false;
                        _context.Wallets.Update(wallet);
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

        static public double GetExpectedBalance(int walletID, DateTime targetDate)
        {
           
            double expectedBalance =0;
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    var transactions = _context.Transactions
                        .Where(t => t.WalletID == walletID && t.Date >= targetDate)
                        .ToList();
                    clsWallet wallet = _context.Wallets.Find(walletID)!;
                    expectedBalance = (double)wallet.Balance;

                    foreach (clsTransaction transaction in transactions)
                    {
                        if (transaction.TransactionTypeID == 1)
                        {

                           expectedBalance-= (double)transaction.Amount;
                        }
                        else if(transaction.TransactionTypeID == 2)
                        {
                            expectedBalance+= (double)transaction.Amount;
                        }
                        else
                        {
                       clsTransfer transfer=     clsTransfer.getTransferByTransID(transaction.TransactionID);
                             
                            if(transfer!=null)
                            {
                                if(transfer.SourceWalletID==walletID)
                                {
                                    expectedBalance+= (double)transfer.FirstAmount;
                                }
                                else if(transfer.DestinationWalletID==walletID)
                                {
                                    expectedBalance-= (double)transfer.SecondAmount;
                                }
                            }
                        }
                    }

                   

                     
                    return (double)expectedBalance;
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
