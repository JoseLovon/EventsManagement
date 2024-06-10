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
        private string? name;
        private string? description;
        private string? creationDate;

        public Club()
        {

        }
        public Club(int clubId, string? name, string? description)
        {
            ClubId = clubId;
            Name = name;
            Description = description;
        }
        public Club(int clubId, string? name, string? description, string? creationDate)
        {
            ClubId = clubId;
            Name = name;
            Description = description;
            CreationDate = creationDate;
        }

        public Club(string? name, string? description)
        {
            Name = name;
            Description = description;
        }
        public int ClubId { get => clubId; set => clubId = value; }
        public string? Name { get => name; set => name = value; }
        public string? Description { get => description; set => description = value; }
        public string? CreationDate { get => creationDate; set => creationDate = value; }
        public static DataTable? GetClubsToLoad()
        {
            string sql =
                $@"SELECT 
	                Club_ID
	                , Name
                    , Description
                    , Creation_Date
	                , NextClubID
	                , PreviousClubID
	                , RowNumber
	                , (SELECT TOP(1) Club_ID FROM Club ORDER BY Name) AS FirstClubID
	                , (SELECT TOP(1) Club_ID FROM Club ORDER BY Name DESC) AS LastClubID
                FROM
                (
	                SELECT 
		                Club_ID
		                , Name
                        , Description
                        , Creation_Date
		                , LEAD(Club_ID) OVER(ORDER BY Name) AS NextClubID 
		                , LAG(Club_ID) OVER(ORDER BY Name) AS PreviousClubID
		                , ROW_NUMBER() OVER(ORDER BY Name) AS RowNumber
	                FROM Club
                ) AS Clubs;";

            DataTable clubs = DataAccess.GetData(sql);

            return clubs;
        }
        public static DataSet? GetClubsToLoadById(int clubId)
        {
            string sqlDetails = @"SELECT Club_ID, Name, Description, Creation_Date
                FROM Club WHERE Club_ID = @ClubId ORDER BY Name;";

            string sqlClubPosition = $@"
                SELECT 
	                Club_ID
	                , Name
                    , Description
                    , Creation_Date
	                , NextClubID
	                , PreviousClubID
	                , RowNumber
	                , (SELECT TOP(1) Club_ID FROM Club ORDER BY Name) AS FirstClubID
	                , (SELECT TOP(1) Club_ID FROM Club ORDER BY Name DESC) AS LastClubID
                FROM
                (
	                SELECT 
		                Club_ID
		                , Name
                        , Description
                        , Creation_Date
		                , LEAD(Club_ID) OVER(ORDER BY Name) AS NextClubID 
		                , LAG(Club_ID) OVER(ORDER BY Name) AS PreviousClubID
		                , ROW_NUMBER() OVER(ORDER BY Name) AS RowNumber
	                FROM Club
                ) AS clubs
                WHERE Club_ID = @ClubId;";

            SqlParameter[] clubIdParam = [
                new SqlParameter("@ClubId", clubId)
                ];

            string[] sqlQueries = new string[] { sqlDetails, sqlClubPosition };

            DataSet dsClubInfo = DataAccess.GetData(clubIdParam, sqlQueries);

            return dsClubInfo;
        }
        public static List<Club>? GetClubByName(string clubName)
        {
            var getQuery = $"SELECT Club_ID, Name, Description, Creation_Date " +
                $"FROM Club WHERE Name LIKE @ClubName ORDER BY Name";

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
        public static int GetFirstClub()
        {
            var sql = "SELECT TOP 1 Club_ID FROM Club ORDER BY Name";

            int club = Convert.ToInt32(DataAccess.ExecuteScalar(sql));

            if (club > 0)
            {
                return club;
            }
            else
            {
                return 0;
            }
        }
        public static int VerifyClubToDelete(int clubId)
        {
            var sql = @"SELECT COUNT(*) FROM Club CL INNER JOIN Contract C ON 
            CL.Club_ID = C.Club_ID WHERE CL.Club_ID = @ClubId";

            SqlParameter[] playerParam = [
                new SqlParameter("@ClubId", clubId)
            ];

            int club = Convert.ToInt32(DataAccess.ExecuteScalar(sql, playerParam));

            return club;
        }
        public static DataTable GetClubs()
        {
            var getQuery = $"SELECT Club_ID, Name AS Club FROM Club ORDER BY Name";

            DataTable dtClubs = DataAccess.GetData(getQuery);

            return dtClubs;
        }
        public static bool CreateClub(Club newClub)
        {
            string insertQuery = "INSERT INTO Club (Name, Description) " +
                "VALUES (@ClubName, @Description)";

            SqlParameter[] insertParams = [
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
        public static bool UpdateClub(Club clubToUpdate)
        {
            string updateSql = "UPDATE Club SET Name = @ClubName, " +
                "Description = @Description WHERE Club_ID = @ClubId";

            SqlParameter[] updateParams = [
            new SqlParameter("@ClubName", clubToUpdate.Name),
            new SqlParameter("@Description", clubToUpdate.Description),
            new SqlParameter("@ClubId", clubToUpdate.ClubId)
            ];

            int rowsUpdated = DataAccess.ManageData(updateSql, updateParams);

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
        public static bool DeleteClub(int clubId)
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
