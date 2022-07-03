using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BountyList.Library.DbModels.Users
{
    public class UserInfo
    {
        [Key]
        [ForeignKey("User")]
        public Guid UserId { get; set; }

        [MaxLength(30)]
        public string NickName { get; set; }
    }
}
