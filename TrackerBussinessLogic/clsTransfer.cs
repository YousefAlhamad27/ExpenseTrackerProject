using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerBussinessLogic
{
    public class clsTransfer
    {
        public int TransferID { get; set; }
        public int SourceWalletID { get; set; }
        public int DestinationWalletID { get; set; }
        public decimal FirstAmount { get; set; }
        public decimal SecondAmount { get; set; }
        public int TransactionID { get; set; }

        public clsTransfer()
        {
            TransferID = 0;
            SourceWalletID = 0;
            DestinationWalletID = 0;
            FirstAmount = 0;
            SecondAmount = 0;
        }

        static public clsTransfer getTransferByTransID(int transactionID)
        {

            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                     
                    return _context.Transfers.FirstOrDefault(t => t.TransactionID == transactionID)!;
                }

            }
            catch
            {
                               return null!;
            }
        }

        public clsTransfer(int transferID, int sourceWalletID, int destinationWalletID, decimal firstAmount, decimal secondAmount )
        {
            TransferID = transferID;
            SourceWalletID = sourceWalletID;
            DestinationWalletID = destinationWalletID;
            FirstAmount = firstAmount;
            SecondAmount = secondAmount;
        }

            public bool Save()
            {
                try
                {
                    using (var _context = new AppDbContext(DatabaseConfig.Options))
                    {
                        if (TransferID <= 0)
                        {
                            _context.Transfers.Add(this);
                        }
                        else
                        {
                            _context.Transfers.Update(this);
                        }
                        _context.SaveChanges();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine($"Error saving transfer: {ex.Message}");
                    return false;
                }
        }
        public bool DeleteTransfer()
        {
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    _context.Transfers.Remove(this);
                    _context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
               
                Console.WriteLine($"Error deleting transfer: {ex.Message}");
                return false;
            }
        }

        static public List<clsTransfer> GetAllTransfers()
        {
            using (var _context = new AppDbContext(DatabaseConfig.Options))
            {
                return _context.Transfers.ToList();
            }
        }

        static public clsTransfer GetTransferByID(int transferID)
        {
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    return _context.Transfers.FirstOrDefault(t => t.TransferID == transferID)!;
                }
            }
            catch (Exception ex)
            {
                return null!;
            }
        }
        }
}
