using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerBussinessLogic
{
    public class clsCategoryLimit
    {
        public int CategoryLimitID { get; set; }
        public int CategoryID { get; set; }
        public decimal Amount { get; set; }
        static public List<clsCategoryLimit> GetAllCategoryLimits()
        {
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    return _context.CategoryLimits.ToList();
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                return new List<clsCategoryLimit>();
            }
        }
        static public clsCategoryLimit GetCategoryLimit(int id)
        {
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    return _context.CategoryLimits.FirstOrDefault(c=>c.CategoryLimitID==id)!;
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                return null;
            }
        }
        static public double GetRemainingAmount(int categoryLimitId)
        {
            double remaininAmount=0;

            try
            {
                using (AppDbContext _context = new AppDbContext(DatabaseConfig.Options))
                {
                    clsCategoryLimit limit = _context.CategoryLimits.FirstOrDefault(l => l.CategoryLimitID == categoryLimitId)!;
                    remaininAmount = (double)limit.Amount;
                    List<clsTransaction> transactions = clsTransaction.GetAll30DaysCat(limit.CategoryID,1);
                    foreach (clsTransaction transaction in transactions)
                    {
                        
                        clsCurrency currency = clsCurrency.GetCurrencyByID(clsWallet.getCurrencyID(transaction.WalletID));

                        if (currency.CurrencyID != 1)
                        {
                            remaininAmount -= clsUtil.ComputeConversionFromUSD((double)transaction.Amount, currency.ExchangeRateToUSD);

                        }

                        else
                            remaininAmount -= (double)transaction.Amount;
                    }

                }
            }

            catch (Exception ex)
            {
                return remaininAmount;
            }

            return remaininAmount;
            }

        
        static public clsCategoryLimit GetCategoryLimitByCategoryID(int categoryID)
        {
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    return _context.CategoryLimits.FirstOrDefault(c => c.CategoryID == categoryID)!;
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                return null;
            }
        }
        public bool Delete()
        {
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    _context.CategoryLimits.Remove(this);
                    _context.SaveChanges();
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
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    clsCategoryLimit categoryLimit = _context.CategoryLimits.FirstOrDefault(c => c.CategoryID == CategoryID)!;
                    if (categoryLimit!=null)
                    {
                        categoryLimit.Amount = Amount;
                        _context.CategoryLimits.Update(categoryLimit);
                    }
                    else
                        _context.CategoryLimits.Add(this);

                    _context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                return false;
            }
        }
    }
}
