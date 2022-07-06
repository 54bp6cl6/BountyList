using BountyList.Library.DbModels.Accounts;
using Microsoft.EntityFrameworkCore;

namespace BountyList.Library.DbModels
{
    public class BountyListContext : DbContext 
    {
        public DbSet<Account> Accounts { get; set; } = null!;

        public BountyListContext(DbContextOptions options) : base(options)
        {

        }
    }
}
