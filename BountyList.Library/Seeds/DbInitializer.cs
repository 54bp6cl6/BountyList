using BountyList.Library.DbModels;
using BountyList.Library.DbModels.Users;
using System.Security.Cryptography;
using System.Text;

namespace BountyList.Library.Seeds
{
    public class DbInitializer : IDbInitializer
    {
        private BountyListContext Db { get; set; }
        private readonly List<Task> tasks;

        public DbInitializer(BountyListContext db)
        {
            Db = db;
            tasks = new List<Task>();
        }

        public async Task InitializeAsync()
        {
            tasks.Add(AddUser());
            await Task.WhenAll(tasks);
            await Db.SaveChangesAsync();
        }

        private async Task AddUser()
        {
            if (!Db.Users.Any())
            {
                using var hash = SHA256.Create();
                var byteArray = hash.ComputeHash(Encoding.UTF8.GetBytes("!Qaz2wsx"));
                var passwordHash = Convert.ToHexString(byteArray).ToLower();
                var userId = Guid.NewGuid();

                await Db.AddAsync(new User()
                {
                    UserId = userId,
                    Username = "testman007",
                    Email = "54bp6cl6@gmail.com",
                    PasswordHash = passwordHash
                });
                await AddUserInfo(userId);
            }
        }

        private async Task AddUserInfo(Guid userId)
        {
            if (!Db.UserInfos.Any())
            {
                await Db.UserInfos.AddAsync(new UserInfo
                {
                    UserId = userId,
                    NickName = "TestMan-007"
                });
            }
        }
    }
}
