using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerBussinessLogic
{
    public class clsUtil
    {
      static  public double ComputeConversionFromUSD(double amount, double exchangeRate)
        {
            return amount * exchangeRate;

        }
        
     static public double ComputeConversionToUSD(double amount, double exchangeRate)
        {
            return amount / exchangeRate;
        }

        public static DateTime GetLastSalaryDate(int salaryDay)
        {
            DateTime today = DateTime.Today;

            
            int monthOffset = (today.Day >= salaryDay) ? 0 : -1;

          
            DateTime targetMonth = today.AddMonths(monthOffset);

            
            
            int daysInTargetMonth = DateTime.DaysInMonth(targetMonth.Year, targetMonth.Month);
            int actualDay = Math.Min(salaryDay, daysInTargetMonth);

            return new DateTime(targetMonth.Year, targetMonth.Month, actualDay);
        }
        static public bool DoesTransactionExceedLimit(int categoryID, double Amount,int sourceWalletID)
        {
            clsCategoryLimit limit = clsCategoryLimit.GetCategoryLimitByCategoryID(categoryID);
            if(limit==null)
                return false;

            List<clsTransaction> transactions = clsTransaction.GetAll30DaysCat(categoryID,1);
            
            clsCurrency sourceCurrency = clsCurrency.GetCurrencyByID(clsWallet.GetWalletByID(sourceWalletID)!.CurrencyID);

            if (sourceCurrency.CurrencyID != 1)
            {
                Amount = ComputeConversionToUSD(Amount, sourceCurrency.ExchangeRateToUSD);
            }

            double totalExpense = 0;

            foreach(clsTransaction t in transactions)
            {
                clsCurrency currency = clsCurrency.GetCurrencyByID(clsWallet.GetWalletByID(t.WalletID)!.CurrencyID);
               
                    if (currency.CurrencyID != 1)
                    {
                        totalExpense += ComputeConversionFromUSD((double)t.Amount, currency.ExchangeRateToUSD);
                    }
                    else
                    {
                        totalExpense += (double)t.Amount;
                    }
                
               
               
            }
            return totalExpense+Amount > (double)limit.Amount;
        }
        static public int ComputeLimitProgressBar(int categoryID,double limit)
        {
            
            List<clsTransaction> transactions = clsTransaction.GetAll30DaysCat(categoryID,1);
            double totalExpense = 0;         

            foreach(clsTransaction t in transactions)
            {
                clsCurrency currency = clsCurrency.GetCurrencyByID(clsWallet.GetWalletByID(t.WalletID)!.CurrencyID);

                
                    if (currency.CurrencyID != 1)
                    {
                        totalExpense += ComputeConversionFromUSD((double)t.Amount, currency.ExchangeRateToUSD);
                    }
                    else
                    {
                        totalExpense += (double)t.Amount;
                    }
                
               

               
            }
            if(totalExpense==0)
                return 0;

            if ((int)((totalExpense / limit) * 100) > 100)
                return 100;
            else
                return (int)((totalExpense / limit) * 100);

            
        }
    }
}
