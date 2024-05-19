namespace EventsManagement.Models
{
    public class User
    {
        private int userId;
        private string? username;

        
        public User()
        {

        }
        public User(string? username)
        {
            this.Username = username;
        }
        public User(int userId, string? username)
        {
            this.UserId = userId;
            this.Username = username;
        }
        public int UserId { get => userId; set => userId = value; }
        public string? Username { get => username; set => username = value; }
    }
}
