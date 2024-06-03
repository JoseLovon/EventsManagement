using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballContractsHistory.Models
{
    public class Player
    {
        private int playerId;
        private string? playerName;
        private int? positionId;
        private string? positionName;
        public Player()
        {

        }
        public Player(int playerId, string? name, int? positionId, string? positionName)
        {
            PlayerId = playerId;
            PlayerName = name;
            PositionId = positionId;
            PositionName = positionName;
        }
        public Player(string? name, int? playerId, string? playerName)
        {
            PlayerName = name;
            PositionId = playerId;
            PositionName = playerName;
        }
        public Player(int playerId, string? name, int? positionId)
        {
            PlayerId = playerId;
            PlayerName = name;
            PositionId = positionId;
        }
        public Player(string? name, int? positionId)
        {
            PlayerName = name;
            PositionId = positionId;
        }
        public int PlayerId { get => playerId; set => playerId = value; }
        public string? PlayerName { get => playerName; set => playerName = value; }
        public int? PositionId { get => positionId; set => positionId = value; }
        public string? PositionName { get => positionName; set => positionName = value; }
        public static DataTable? GetPlayersToLoad()
        {
            string sql =
                $@"SELECT 
	                Player_ID
	                , Name
                    , Position_ID
                    , Position
                    , Creation_Date
	                , NextPlayerID
	                , PreviousPlayerID
	                , RowNumber
	                , (SELECT TOP(1) Player_ID FROM Player ORDER BY Name) AS FirstPlayerID
	                , (SELECT TOP(1) Player_ID FROM Player ORDER BY Name DESC) AS LastPlayerID
                FROM
                (
	                SELECT 
		                P.Player_ID
		                , P.Name
                        , PS.Position_ID
                        , PS.Name as Position
                        , P.Creation_Date
		                , LEAD(P.Player_ID) OVER(ORDER BY P.Name) AS NextPlayerID 
		                , LAG(P.Player_ID) OVER(ORDER BY P.Name) AS PreviousPlayerID
		                , ROW_NUMBER() OVER(ORDER BY P.Name) AS RowNumber
	                FROM Player P INNER JOIN Position PS ON 
                PS.Position_ID = P.Position_ID
                ) AS Players;";

            DataTable Players = DataAccess.GetData(sql);

            return Players;
        }
        public static DataSet? GetPlayersToLoadById(int PlayerId)
        {
            string sqlDetails = @"SELECT P.Player_ID, P.Name, PS.Position_ID, PS.Name as Position, 
                P.Creation_Date FROM Player P INNER JOIN Position PS ON 
                PS.Position_ID = P.Position_ID WHERE Player_ID = @PlayerId ORDER BY P.Name;";

            string sqlPlayerPosition = $@"
                SELECT 
	                Player_ID
		            , Name
                    , Position_ID 
                    , Position
                    , Creation_Date
	                , NextPlayerID
	                , PreviousPlayerID
	                , RowNumber
	                , (SELECT TOP(1) Player_ID FROM Player ORDER BY Name) AS FirstPlayerID
	                , (SELECT TOP(1) Player_ID FROM Player ORDER BY Name DESC) AS LastPlayerID
                FROM
                (
	                SELECT 
		                P.Player_ID
		                , P.Name
                        , PS.Position_ID
                        , PS.Name as Position
                        , P.Creation_Date
		                , LEAD(P.Player_ID) OVER(ORDER BY P.Name) AS NextPlayerID 
		                , LAG(P.Player_ID) OVER(ORDER BY P.Name) AS PreviousPlayerID
		                , ROW_NUMBER() OVER(ORDER BY P.Name) AS RowNumber
	                FROM Player P INNER JOIN Position PS ON 
                PS.Position_ID = P.Position_ID
                ) AS Players
                WHERE Player_ID = @PlayerId;";

            SqlParameter[] PlayerIdParam = [
                new SqlParameter("@PlayerId", PlayerId)
                ];

            string[] sqlQueries = new string[] { sqlDetails, sqlPlayerPosition };

            DataSet dsPlayerInfo = DataAccess.GetData(PlayerIdParam, sqlQueries);

            return dsPlayerInfo;
        }
        public static int GetFirstPlayer()
        {
            var sql = "SELECT TOP 1 Player_ID FROM Player ORDER BY Name";

            int player = Convert.ToInt32(DataAccess.ExecuteScalar(sql));

            if (player > 0)
            {
                return player;
            }
            else
            {
                return 0;
            }
        }
        public static int VerifyPlayerContract(int playerId, DateTime startDate, DateTime endDate)
        {
            var sql = @"SELECT COUNT(*) FROM Player P INNER JOIN Contract C ON C.Player_ID = P.Player_ID
            WHERE ((C.Start_Date <= @StartDate AND C.End_Date >= @StartDate)
            OR (C.Start_Date <= @EndDate AND C.End_Date >= @EndDate))
            AND P.Player_ID = @PlayerId;";

            SqlParameter[] playerParam = [
                new SqlParameter("@PlayerId", playerId),
                new SqlParameter("@StartDate", startDate.Date),
                new SqlParameter("@EndDate", endDate.Date)
            ];

            int contractPlayer = Convert.ToInt32(DataAccess.ExecuteScalar(sql, playerParam));

            return contractPlayer;
        }
        public static int VerifyPlayerToDelete(int playerId)
        {
            var sql = @"SELECT COUNT(*) FROM Player P INNER JOIN Contract C ON 
            P.Player_ID = C.Player_ID WHERE P.Player_ID = @PlayerId";

            SqlParameter[] playerParam = [
                new SqlParameter("@PlayerId", playerId)
            ];

            int player = Convert.ToInt32(DataAccess.ExecuteScalar(sql, playerParam));

            return player;
        }
        public static DataTable GetPlayers()
        {
            var getQuery = $"SELECT Player_ID, Name AS Player FROM Player ORDER BY Name";

            DataTable dtPlayers = DataAccess.GetData(getQuery);

            return dtPlayers;
        }
        public Player? GetPlayerById(int playerId)
        {
            var getQuery = @$"SELECT P.Player_ID, P.Name, PS.Position_ID, PS.Name AS 
            Position FROM Player P INNER JOIN Position PS ON PS.Position_ID = P.Player_ID
            WHERE P.Player_ID = @PlayerId";

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
            var getQuery = @"SELECT P.Player_ID, P.Name AS Player, PS.Position_ID, PS.Name AS
            Position FROM Player P INNER JOIN Position PS ON PS.Position_ID = P.Position_ID 
            WHERE P.Name LIKE @PlayerName";

            SqlParameter[] playerNameParam = [
                new SqlParameter("@PlayerName", SqlDbType.NVarChar, 255){
                    Value = "%" + playerName + "%"
                }
                ];

            List<Player>? players = DataAccess.GetPlayers(getQuery, playerNameParam);

            if (players.Count > 0)
            {
                return players;
            }
            else
            {
                Console.WriteLine($"No player found with Full PlayerName: {playerName}");
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
                Console.WriteLine($"No contracts found");
                return null;
            }
        }

        public static bool CreatePlayer(Player newPlayer)
        {
            string insertQuery = "INSERT INTO Player (Name, Position_ID) " +
                "VALUES (@PlayerName, @PositionId)";

            SqlParameter[] insertParams = [
            new SqlParameter("@PlayerName", newPlayer.PlayerName),
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
        public static bool UpdatePlayer(Player playerToUpdate)
        {
            string updateSql = "UPDATE Player SET Name = @PlayerName, " +
                "Position_ID = @PositionId WHERE Player_ID = @PlayerId";

            SqlParameter[] updateParams = [
                new SqlParameter("@PlayerName", playerToUpdate.PlayerName),
                new SqlParameter("@PositionId", playerToUpdate.PositionId),
                new SqlParameter("@PlayerId", playerToUpdate.PlayerId)
            ];

            int rowsUpdated = DataAccess.ManageData(updateSql, updateParams);

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
        public static bool DeletePlayer(int playerId)
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
