using System.Data.SqlClient;

namespace FootballContractsHistory.Models
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

    public class DataUser
    {
        public int userId;
        public string username;

        #region Singleton

        private static DataUser? instance;

        public static DataUser GetInstance()
        {
            if (instance == null)
                instance = new DataUser();

            return instance;
        }
        public static void ResetInstance()
        {
            instance = null;
        }
        #endregion

        public DataUser()
        {
            instance = this;
        }
    }
}
