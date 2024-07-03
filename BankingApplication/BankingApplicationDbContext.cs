using BankingApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class BankingApplicationDbContext : DbContext
    {
        //required to allow the services in the InteractionForm
        public BankingApplicationDbContext(DbContextOptions<BankingApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<BankUser> BankUsers { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                       .UseSqlServer(@"Data Source=.\HYDAELYN;Initial Catalog=BankingApplicationDb;Integrated Security=True;Encrypt=False;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Primary Key for BankUser table
            modelBuilder.Entity<BankUser>()
                .HasKey(b => b.UserId);

            //Primary Key for BankAccount table
            modelBuilder.Entity<BankAccount>()
                .HasKey(b => b.AccountNumber);

            //Primary Key for Transaction table
            modelBuilder.Entity<Transaction>()
                .HasKey(b => b.TransactionId);

            //defining the Foreign Key between BankUser and BankAccount
            modelBuilder.Entity<BankAccount>()
                .HasOne(b => b.BankUser)
                .WithMany(p => p.UserAccounts)
                .HasForeignKey(p => p.UserId);

            //defining the Foreing Key between BankAccount and Transaction
            modelBuilder.Entity<Transaction>()
                .HasOne(b => b.BankAccount)
                .WithMany(p => p.Transactions)
                .HasForeignKey(p => p.AccountNumber);
        }
    }
}
