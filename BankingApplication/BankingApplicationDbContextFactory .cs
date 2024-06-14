using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class BankingApplicationDbContextFactory : IDesignTimeDbContextFactory<BankingApplicationDbContext>
    {
        public BankingApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BankingApplicationDbContext>();
            optionsBuilder.UseSqlServer(@"Data Source=.\HYDAELYN;Initial Catalog=BankingApplicationDb;Integrated Security=True;Encrypt=False;");

            return new BankingApplicationDbContext(optionsBuilder.Options);
        }
    }
}
