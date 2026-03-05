using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerBussinessLogic
{
    public class clsSubscription
    {

        public int SubscriptionID { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public int WalletID { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public int CategoryID { get; set; }


        static public clsSubscription GetByID(int id)
        {
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    return _context.Subscriptions.FirstOrDefault(s => s.SubscriptionID == id);
                }
            }
            catch
            {
                return null;
            }
        }
        static public List<clsSubscription> GetAll()
        {
            using (var _context = new AppDbContext(DatabaseConfig.Options))
            {
                return _context.Subscriptions.ToList();
            }
        }

        public bool Save()
        {
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    if (SubscriptionID <= 0)
                    {
                        _context.Subscriptions.Add(this);
                    }
                    else
                    {
                        _context.Subscriptions.Update(this);
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
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    _context.Subscriptions.Remove(this);
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
