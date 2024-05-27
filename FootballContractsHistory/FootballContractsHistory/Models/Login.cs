using System.Data.SqlClient;

namespace FootballContractsHistory.Models
{
    public class Login
    {
        private User? user;
        private DateTime loginTime;
        public User? User { get => user; set => user = value; }
        public DateTime LoginTime { get => loginTime; set => loginTime = value; }
        
        #region Singleton

        private static Login? instance;

        public static Login GetInstance()
        {
            if (instance == null)
                instance = new Login();

            return instance;
        }
        #endregion

        public Login()
        {
            instance = this;
        }
        public User? RegisterLogin(User userLogged)
        {
            string insertQuery = "INSERT INTO Login (Userr_ID, Login_Date) " +
                "VALUES (@UserId, @LoginDate)";

            SqlParameter[] insertParams = [
            new SqlParameter("@UserId", userLogged.UserId),
            new SqlParameter("@LoginDate", DateTime.Now)
            ];

            int rowsInserted = DataAccess.ManageData(insertQuery, insertParams);

            if (rowsInserted > 0)
            {
                Console.WriteLine($"Login of user {userLogged.UserId} registered successfully.");
                return userLogged;
            }
            else
            {
                Console.WriteLine("Error: Failed to create event.");
                return null;
            }
        }
        public User? VerifyUser(string username, string password)
        {
            var getQuery = $"SELECT TOP(1) Userr_ID, Username FROM Userr WHERE Username = @Username AND " +
                $"Passwordd = @Password";

            SqlParameter[] userParam = [
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password),
                ];

            List<User> users = DataAccess.GetUsers(getQuery, userParam);

            if (users.Count > 0)
            {
                Console.WriteLine($"User verified with Username: {username}");
                return RegisterLogin(users[0]);
            }
            else
            {
                Console.WriteLine($"No user found with Username: {username}");
                return null;
            }
        }
    }
}
