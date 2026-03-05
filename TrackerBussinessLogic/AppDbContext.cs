using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace TrackerBussinessLogic
{
    public class AppDbContext: DbContext
    {
       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext() { }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            if (!optionsBuilder.IsConfigured)
            {
                
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ExpenseTracker;Integrated Security=True;TrustServerCertificate=True");
            }
        }
        public DbSet<clsWallet> Wallets { get; set; }
        public DbSet<clsTransaction> Transactions { get; set; }
        public DbSet<clsCategory> Categories { get; set; }
        public DbSet<clsTransactionType> TransactionTypes { get; set; }
        public DbSet<clsCurrency> Currencies { get; set; }
        public DbSet<clsTransfer> Transfers { get; set; }
        public DbSet<clsSettings> Settings { get; set; }
        public DbSet<clsCategoryLimit> CategoryLimits { get; set; }
        public DbSet<clsSubscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<clsCurrency>()
                .HasKey(c => c.CurrencyID);
            modelBuilder.Entity<clsSettings>()
                .HasNoKey();

            modelBuilder.Entity<clsCategoryLimit>(
                entity =>
                {
                    entity.HasKey(cl => cl.CategoryLimitID);
                    entity.HasOne<clsCategory>()
                          .WithMany()
                          .HasForeignKey(cl => cl.CategoryID)
                          .OnDelete(DeleteBehavior.Restrict);


                }

                );
                


            modelBuilder.Entity<clsWallet>(entity =>
            {
                entity.HasKey(w => w.WalletID);
               entity.HasOne<clsCurrency>()
                     .WithMany()
                     .HasForeignKey(w => w.CurrencyID)
                     .OnDelete(DeleteBehavior.Restrict);
            });
                

            modelBuilder.Entity<clsTransfer>(entity =>
            {
                entity.HasKey(tr => tr.TransferID);
                entity.HasOne<clsWallet>()
                      .WithMany()
                      .HasForeignKey(tr => tr.SourceWalletID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne<clsWallet>()
                      .WithMany()
                      .HasForeignKey(tr => tr.DestinationWalletID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne<clsTransaction>().WithOne()
                      .HasForeignKey<clsTransfer>(tr => tr.TransactionID)
                      .OnDelete(DeleteBehavior.Restrict);
            });
                
                modelBuilder.Entity<clsSubscription>(entity =>
                {
                    entity.HasKey(s => s.SubscriptionID);
                  entity.HasOne<clsCategory>()
                        .WithMany()
                        .HasForeignKey(s => s.CategoryID)
                        .OnDelete(DeleteBehavior.Restrict);
                    entity.HasOne<clsWallet>().WithMany()
                          .HasForeignKey(s => s.WalletID)
                          .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity<clsTransaction>(entity =>
            {
                entity.HasKey(tra => tra.TransactionID);

                entity.HasOne<clsWallet>()
                      .WithMany()
                      .HasForeignKey(sa => sa.WalletID)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne<clsTransactionType>()
                     .WithMany()
                     .HasForeignKey(type => type.TransactionTypeID)
                     .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne<clsCategory>()
                     .WithMany()
                     .HasForeignKey(sa => sa.CategoryID)
                     .OnDelete(DeleteBehavior.Restrict);

                //entity.HasOne<clsSubscription>()
                //     .WithMany().HasForeignKey(sa => sa.SubscriptionID).OnDelete(DeleteBehavior.SetNull);





            });
            modelBuilder.Entity<clsCategory>()
                .HasKey(c => c.CategoryID); 
            modelBuilder.Entity<clsTransactionType>()
                .HasKey(t => t.TransactionTypeID);

            // 1. Configure the Settings table (No Key)
            //modelBuilder.Entity<clsSettings>().HasNoKey();

            //// 2. Explicitly define relationships (Optional if naming is standard, but safe to do)
            //modelBuilder.Entity<clsTransaction>()
            //    .HasOne(t => t.Wallet)
            //    .WithMany(w => w.Transactions)
            //    .HasForeignKey(t => t.WalletID);

            //modelBuilder.Entity<clsTransaction>()
            //    .HasOne(t => t.Category)
            //    .WithMany(c => c.Transactions)
            //    .HasForeignKey(t => t.CategoryID);
        }
    }
}
