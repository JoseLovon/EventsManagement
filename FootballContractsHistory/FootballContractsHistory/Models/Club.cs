using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballContractsHistory.Models
{
    public class Club
    {
        private int clubId;
        private int userId;
        private string? name;
        private string? description;

        public Club()
        {

        }
        public Club(int clubId, int userId, string? name, string? description)
        {
            ClubId = clubId;
            UserId = userId;
            Name = name;
            Description = description;
        }
        public Club(int userId, string? name, string? description)
        {
            UserId = userId;
            Name = name;
            Description = description;
        }
        public Club(string? name, string? description)
        {
            UserId = userId;
            Name = name;
            Description = description;
        }
        public int ClubId { get => clubId; set => clubId = value; }
        public int UserId { get => userId; set => userId = value; }
        public string? Name { get => name; set => name = value; }
        public string? Description { get => description; set => description = value; }
        public DataTable? GetClubs()
        {
            var getQuery = $"SELECT Club_ID, Userr_ID, Name, Description FROM " +
                $"Club ORDER BY Name";

            DataTable clubs = DataAccess.GetData(getQuery);

            return clubs;
        }
        public List<Club>? GetClubByName(string clubName)
        {
            var getQuery = $"SELECT Club_ID, Userr_ID, Name, Description FROM Club " +
                                    $"WHERE Name LIKE @ClubName ORDER BY Name";

            SqlParameter[] clubNameParam = [
                new SqlParameter("@ClubName", SqlDbType.NVarChar, 255){
                    Value = "%" + clubName + "%"
                }
                ];

            List<Club> clubs = DataAccess.GetClubs(getQuery, clubNameParam);

            if (clubs.Count > 0)
            {
                return clubs;
            }
            else
            {
                Console.WriteLine($"No club found with Name: {clubName}");
                return null;
            }
        }
        public bool CreateClub(Club newClub)
        {
            string insertQuery = "INSERT INTO Club (Userr_ID, Name, Description) " +
                "VALUES (@UserId, @ClubName, @Description)";

            SqlParameter[] insertParams = [
            new SqlParameter("@UserId", newClub.UserId),
            new SqlParameter("@ClubName", newClub.Name),
            new SqlParameter("@Description", newClub.Description)
            ];

            int rowsInserted = DataAccess.ManageData(insertQuery, insertParams);

            if (rowsInserted > 0)
            {
                Console.WriteLine("Club created successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Error: Failed to create club.");
                return false;
            }
        }
        public bool UpdateClub(Club clubToUpdate)
        {
            // Construct the SQL UPDATE statement
            string updateSql = "UPDATE Club SET Name = @ClubName, " +
                "Description = @Description WHERE Club_ID = @ClubId";

            // Create the SqlParameter array
            SqlParameter[] updateParams = [
            new SqlParameter("@ClubName", clubToUpdate.Name),
            new SqlParameter("@Description", clubToUpdate.Description),
            new SqlParameter("@ClubId", clubToUpdate.ClubId)
            ];

            // Call the UpdateData method
            int rowsUpdated = DataAccess.ManageData(updateSql, updateParams);

            // Check the number of rows updated
            if (rowsUpdated > 0)
            {
                Console.WriteLine("Club updated successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Failed to update club.");
                return false;
            }
        }
        public bool DeleteClub(int clubId)
        {
            string deleteQuery = "DELETE FROM Club WHERE Club_ID = @ClubId";

            SqlParameter[] deleteParams = [
            new SqlParameter("@ClubId", clubId)
            ];

            int rowsDeleted = DataAccess.ManageData(deleteQuery, deleteParams);

            if (rowsDeleted > 0)
            {
                Console.WriteLine("Club deleted successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Error: Failed to delete club.");
                return false;
            }
        }
    }
}
