using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballContractsHistory.Models
{
    public class Player
    {
        private int playerId;
        private string? name;
        private int? genreId;
        private string? genreName;

        public Player(int playerId, string? name, int? positionId, string? positionName)
        {
            PlayerId = playerId;
            Name = name;
            PositionId = positionId;
            PositionName = positionName;
        }
        public Player(string? name, int? playerId, string? playerName)
        {
            Name = name;
            PositionId = playerId;
            PositionName = playerName;
        }
        public Player(string? name, int? genreId)
        {
            Name = name;
            PositionId = genreId;
        }
        public int PlayerId { get => playerId; set => playerId = value; }
        public string? Name { get => name; set => name = value; }
        public int? PositionId { get => genreId; set => genreId = value; }
        public string? PositionName { get => genreName; set => genreName = value; }

        public Player? GetPlayerById(int playerId)
        {
            var getQuery = $"SELECT P.Player_ID, P.Name, PS.Position_ID, PS.Name AS " +
                $"Position FROM Player P INNER JOIN Position PS ON PS.Position_ID = P.Player_ID " +
                $"WHERE P.Player_ID = @PlayerId";

            SqlParameter[] playerIdParam = [
                new SqlParameter("@PlayerId", playerId)
                ];

            List<Player> players = DataAccess.GetPlayers(getQuery, playerIdParam);

            if (players.Count > 0)
            {
                return players[0];
            }
            else
            {
                Console.WriteLine($"No player found with ID: {playerId}");
                return null;
            }
        }
        public List<Player>? GetPlayerByName(string playerName)
        {
            var getQuery = $"SELECT P.Player_ID, P.Name, PS.Position_ID, PS.Name AS " +
                $"Position FROM Player P INNER JOIN Position PS ON PS.Position_ID = P.Player_ID " +
                $"WHERE P.Name LIKE %@PlayerName%";

            SqlParameter[] playerNameParam = [
                new SqlParameter("@PlayerName", playerName)
                ];

            List<Player> players = DataAccess.GetPlayers(getQuery, playerNameParam);

            if (players.Count > 0)
            {
                return players;
            }
            else
            {
                Console.WriteLine($"No players found");
                return null;
            }
        }
        public List<Player>? GetPlayersByPosition(string position)
        {
            var getQuery = $"SELECT P.Player_ID, P.Name, PS.Position_ID, PS.Name AS " +
                $"Position FROM Player P INNER JOIN Position PS ON PS.Position_ID = P.Player_ID " +
                $"WHERE PS.Name LIKE %@PositionName%";

            SqlParameter[] playersPositionParam = [
                new SqlParameter("@PositionName", position)
                ];

            List<Player> players = DataAccess.GetPlayers(getQuery, playersPositionParam);

            if (players.Count > 0)
            {
                return players;
            }
            else
            {
                Console.WriteLine($"No players found");
                return null;
            }
        }

        public bool CreatePlayer(Player newPlayer)
        {
            string insertQuery = "INSERT INTO Player (Name, Position_ID) " +
                "VALUES (@Name, @PositionId)";

            SqlParameter[] insertParams = [
            new SqlParameter("@Name", newPlayer.Name),
            new SqlParameter("@PositionId", newPlayer.PositionId)
            ];

            int rowsInserted = DataAccess.ManageData(insertQuery, insertParams);

            if (rowsInserted > 0)
            {
                Console.WriteLine("Player created successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Error: Failed to create player.");
                return false;
            }
        }
        public bool UpdatePlayer(Player playerToUpdate)
        {
            // Construct the SQL UPDATE statement
            string updateSql = "UPDATE Player SET Name = @Name, " +
                "Position_ID = @PositionId WHERE Player_ID = @PlayerId";

            // Create the SqlParameter array
            SqlParameter[] updateParams = [
            new SqlParameter("@PlayerId", playerToUpdate.PlayerId),
            new SqlParameter("@Name", playerToUpdate.Name),
            new SqlParameter("@PositionId", playerToUpdate.PositionId)
            ];

            // Call the UpdateData method
            int rowsUpdated = DataAccess.ManageData(updateSql, updateParams);

            // Check the number of rows updated
            if (rowsUpdated > 0)
            {
                Console.WriteLine("Player updated successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Failed to update player.");
                return false;
            }
        }
        public bool DeletePlayer(int playerId)
        {
            string deleteQuery = "DELETE FROM Player WHERE Player_ID = @PlayerId";

            SqlParameter[] deleteParams = [
            new SqlParameter("@PlayerId", playerId)
            ];

            int rowsDeleted = DataAccess.ManageData(deleteQuery, deleteParams);

            if (rowsDeleted > 0)
            {
                Console.WriteLine("Player deleted successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Error: Failed to delete player.");
                return false;
            }
        }
    }
}
