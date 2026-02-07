using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerBussinessLogic
{
    public class clsCurrency
    {
        public int CurrencyID { get; set; }
        public string Code { get; set; }
        public double ExchangeRateToUSD { get; set; }

        public clsCurrency()
        {
            CurrencyID = 0;
            Code = "";
            ExchangeRateToUSD = 1.0;
        }

        public clsCurrency(int currencyID, string code, double exchangeRateToUSD)
        {
            CurrencyID = currencyID;
            Code = code;
            ExchangeRateToUSD = exchangeRateToUSD;
        }

        static public List<clsCurrency> GetAllCurrencies()
        {
            using (var _context = new AppDbContext(DatabaseConfig.Options))
            {
                return _context.Currencies.ToList();
            }
        }
        static public string GetCurrencyCodeByID(int currencyID)
        {
            using (var _context = new AppDbContext(DatabaseConfig.Options))
            {
                var currency = _context.Currencies.FirstOrDefault(c => c.CurrencyID == currencyID);
                return currency != null ? currency.Code : "USD";
            }
        }
        static public clsCurrency GetCurrencyByID(int currencyID)
        {
            using (var _context = new AppDbContext(DatabaseConfig.Options))
            {
                return _context.Currencies.FirstOrDefault(c => c.CurrencyID == currencyID)!;
            }
        }
    }
}
