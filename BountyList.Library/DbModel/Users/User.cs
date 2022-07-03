using System.ComponentModel.DataAnnotations;

namespace BountyList.Library.DbModel.Users
{
    public class User
    {
        public Guid UserId { get; set; }

        [Required]
        [MinLength(1), MaxLength(50)]
        public string Username { get; set; }

        [MaxLength(50)]
        public string PasswordHash { get; set; }

        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }
    }
}
