namespace BountyList.MVC.Controllers.Base
{
    public class SessionAccountInfo
    {
        public Guid AccountId { get; set; }
        public string Username { get; set; }

        private string? _nickname;
        public string? Nickname
        {
            get
            {
                return _nickname ?? Username;
            }
            set
            {
                _nickname = value;
            }
        }

        public SessionAccountInfo(Guid accountId, string username, string? nickname)
        {
            AccountId = accountId;
            Username = username;
            Nickname = nickname;
        }
    }
}
