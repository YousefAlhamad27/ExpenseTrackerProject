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

        

        public clsWallet(int walletID, string name, decimal balance, int currencyID, DateTime creationDate)
        {
            WalletID = walletID;
            Name = name;
            Balance = balance;
            CurrencyID = currencyID;
            CreationDate = creationDate;
        }

        public clsWallet()
        {
            WalletID = 0;
            Name="";
            Balance=0;
            CurrencyID = 0;
            CreationDate=DateTime.Now;
        }
        public bool Save()
        {
            try
            {

                using(var _context = new AppDbContext(DatabaseConfig.Options))
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
            using(var _context = new AppDbContext(DatabaseConfig.Options))
            {
                return _context.Wallets.ToList();
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
        public bool RemoveWallet()
        {
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    var wallet = _context.Wallets.Find(WalletID);
                    _context.Wallets.Remove(wallet!);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }
    }
}
