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

        private Club? GetClubById(int clubId)
        {
            var getQuery = $"SELECT Club_ID, User_ID, Name, Description FROM Club " +
                                    $"WHERE Club_ID = @ClubId ORDER BY Name";
            
            SqlParameter[] eventIdParam = [
                new SqlParameter("@ClubId", clubId)
                ];

            List<Club> events = DataAccess.GetClubs(getQuery, eventIdParam);

            if (events.Count > 0)
            {
                return events[0];
            }
            else
            {
                Console.WriteLine($"No club found with ID: {clubId}");
                return null;
            }
        }
        private List<Club>? GetClubByName(string clubName)
        {
            var getQuery = $"SELECT Club_ID, User_ID, Name, Description FROM Club " +
                                    $"WHERE Name = @ClubName ORDER BY Name";

            SqlParameter[] eventIdParam = [
                new SqlParameter("@ClubName", clubName)
                ];

            List<Club> events = DataAccess.GetClubs(getQuery, eventIdParam);

            if (events.Count > 0)
            {
                return events;
            }
            else
            {
                Console.WriteLine($"No event found with Name: {clubName}");
                return null;
            }
        }
        //private List<Club>? GetEventByDate(DateTime selectedDate)
        //{
        //    var getQuery = $"SELECT ClubId, UserId, Name, Description, Event_Date FROM ClubId " +
        //                            $"WHERE EventDate = @EventDate ORDER BY Name";

        //    SqlParameter[] eventIdParam = [
        //        new SqlParameter("@EventDate", selectedDate)
        //        ];

        //    List<Club> events = DataAccess.GetClubs(getQuery, eventIdParam);

        //    if (events.Count > 0)
        //    {
        //        return events;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"No events found with EventDate: {clubId}");
        //        return null;
        //    }
        //}

        private bool CreateClub(Club newEvent)
        {
            string insertQuery = "INSERT INTO Club (Name, Description) " +
                "VALUES (@Name, @Description)";

            SqlParameter[] insertParams = [
            new SqlParameter("@Name", newEvent.Name),
            new SqlParameter("@Description", newEvent.Description)
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
        private bool UpdateCreate(Club clubToUpdate)
        {
            // Construct the SQL UPDATE statement
            string updateSql = "UPDATE Club SET Name = @Name, " +
                "Description = @Description WHERE Club_ID = @ClubId";

            // Create the SqlParameter array
            SqlParameter[] updateParams = [
            new SqlParameter("@Name", clubToUpdate.Name),
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
        private bool DeleteClub(int clubId)
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
