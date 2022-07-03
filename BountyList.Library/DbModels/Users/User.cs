using System.ComponentModel.DataAnnotations;

namespace BountyList.Library.DbModels.Users
{
    public class User
    {
        public Guid UserId { get; set; }

        [Required]
        [MinLength(1), MaxLength(50)]
        public string Username { get; set; } = null!;

        [MaxLength(256)]
        public string? PasswordHash { get; set; }

        [EmailAddress]
        [MaxLength(50)]
        public string? Email { get; set; }
    }
}
