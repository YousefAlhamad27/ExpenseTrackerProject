using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerBussinessLogic
{
    public class clsSettings
    {
        public byte SalaryDay { get; set; }
        public bool ThemeColor { get; set; }
        static public int GetSalaryDay()
        {
            try
            {
                using(AppDbContext context = new AppDbContext())
                {
                    return context.Settings.Select(s => s.SalaryDay).FirstOrDefault();
                }

            }
            catch
            {
                return 1;
            }
        }
        static public bool UpdateSalaryDay(byte day)
        {
            if(day < 1 || day > 31)
                return false;

            try
            {
                using(AppDbContext context = new AppDbContext())
                {
                     
                   
                    return context.Database.ExecuteSqlRaw($"Update settings set SalaryDay={day} ")>0 ;
                }
                
            }
            catch (Exception ex)
            {
                 
                
                return false;
            }
        }
    }
}
