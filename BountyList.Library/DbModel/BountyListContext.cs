using BountyList.Library.DbModel.Users;
using Microsoft.EntityFrameworkCore;

namespace BountyList.Library.DbModel
{
    public class BountyListContext : DbContext 
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserInfo> UsersInfos { get; set; }

        public BountyListContext(DbContextOptions options) : base(options)
        {

        }
    }
}
