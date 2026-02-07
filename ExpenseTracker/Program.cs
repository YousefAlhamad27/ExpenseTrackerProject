using ExpenseTracker;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TrackerBussinessLogic;


namespace ExpenseTracker
{
    static class Program
    {
        [STAThread]

        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           
            var builder = new DbContextOptionsBuilder<AppDbContext>();

          
            builder.UseSqlServer(
                "Data Source=.;Initial Catalog=ExpenseTracker;Integrated Security=True;TrustServerCertificate=True",
                sqlOptions =>
                {
                   
                    sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 5,
                        maxRetryDelay: TimeSpan.FromSeconds(10),
                        errorNumbersToAdd: null);
                });

            
            DatabaseConfig.Options = builder.Options;

           
            Application.Run(new MainForm());
        }
    }
}