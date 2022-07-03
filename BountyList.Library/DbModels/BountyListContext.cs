using BountyList.Library.DbModels.Users;
using Microsoft.EntityFrameworkCore;

namespace BountyList.Library.DbModels
{
    public class BountyListContext : DbContext 
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<UserInfo> UserInfos { get; set; } = null!;

        public BountyListContext(DbContextOptions options) : base(options)
        {

        }
    }
}
