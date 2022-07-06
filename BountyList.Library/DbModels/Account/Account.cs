using System.ComponentModel.DataAnnotations;

namespace BountyList.Library.DbModels.Accounts
{
    public class Account
    {
        public Guid AccountId { get; set; }

        [Required]
        [MinLength(1), MaxLength(50)]
        public string Username { get; set; } = null!;

        [MaxLength(256)]
        public string? PasswordHash { get; set; }

        [EmailAddress]
        [MaxLength(50)]
        public string? Email { get; set; }

        [MaxLength(30)]
        public string? Nickname { get; set; }
    }
}
