namespace BountyList.MVC.Models
{
    public class SessionUserInfo
    {
        public Guid UserId { get; set; }

        public string Username { get; set; }

        public string NickName { get; set; }

        public SessionUserInfo(Guid userId, string username, string nickName)
        {
            UserId = userId;
            Username = username;
            NickName = nickName;
        }
    }
}
