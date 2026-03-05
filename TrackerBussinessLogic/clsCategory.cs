using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerBussinessLogic
{
    public class clsCategory
    {

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }


        public clsCategory(int categoryID, string categoryName)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
        }
        public clsCategory()
        {
            CategoryID = 0;
            CategoryName = string.Empty;
        }
        static public clsCategory GetCategory(int categoryID)
        {
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    return _context.Categories.FirstOrDefault(c => c.CategoryID == categoryID);
                }

            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                return null;
            }
        }
        static  public List<clsCategory> GetAllCategories()
        {
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    return _context.Categories.ToList();
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                return new List<clsCategory>();
            }
        }
        public bool Save()
        {
            try
            {
                using (var _context = new AppDbContext(DatabaseConfig.Options))
                {
                    if (CategoryID <= 0)
                    {
                        _context.Categories.Add(this);
                        _context.SaveChanges();
                        return true;
                    }

                    return false;
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
