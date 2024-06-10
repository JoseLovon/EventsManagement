using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballContractsHistory.Models
{
    public class Contract
    {
        private int contractId;
        private int clubId;
        private string? clubName;
        private int playerId;
        private string? playerName;
        private string? positionName;
        private DateTime startTime;
        private DateTime endTime;
        private string creationDate;
        public Contract(int contractId, int clubId, string? clubName, int playerId, string? playerName, string? positionName, DateTime startDate, DateTime endDate)
        {
            ContractId = contractId;
            ClubId = clubId;
            ClubName = clubName;
            PlayerId = playerId;
            PlayerName = playerName;
            PositionName = positionName;
            StartDate = startDate;
            EndDate = endDate;
        }
        public Contract(int contractId, int clubId, string? clubName, int playerId, string? playerName, string? positionName, DateTime startDate, DateTime endDate, string creationDate)
        {
            ContractId = contractId;
            ClubId = clubId;
            ClubName = clubName;
            PlayerId = playerId;
            PlayerName = playerName;
            PositionName = positionName;
            StartDate = startDate;
            EndDate = endDate;
            CreationDate = creationDate;
        }
        public Contract(int contractId, int clubId, string? clubName, string? positionName, DateTime startDate, DateTime endDate, string creationDate)
        {
            ContractId = contractId;
            ClubId = clubId;
            ClubName = clubName;
            PositionName = positionName;
            StartDate = startDate;
            EndDate = endDate;
            CreationDate = creationDate;
        }
        public Contract(int contractId, int playerId, string? playerName, string? positionName, DateTime startDate, DateTime endDate, string creationDate, string? clubName = null)
        {
            ContractId = contractId;
            PlayerId = playerId;
            PlayerName = playerName;
            PositionName = positionName;
            StartDate = startDate;
            EndDate = endDate;
            CreationDate = creationDate;
        }
        public Contract(int contractId, int clubId, int playerId, DateTime startDate, DateTime endDate)
        {
            ContractId = contractId;
            ClubId = clubId;
            PlayerId = playerId;
            StartDate = startDate;
            EndDate = endDate;
        }
        public Contract(int clubId, int playerId, DateTime startDate, DateTime endDate)
        {
            ClubId = clubId;
            PlayerId = playerId;
            StartDate = startDate;
            EndDate = endDate;
        }
        public int ContractId { get => contractId; set => contractId = value; }
        public int ClubId { get => clubId; set => clubId = value; }
        public string? ClubName { get => clubName; set => clubName = value; }
        public int PlayerId { get => playerId; set => playerId = value; }
        public string? PlayerName { get => playerName; set => playerName = value; }
        public string? PositionName { get => positionName; set => positionName = value; }
        public DateTime StartDate { get => startTime; set => startTime = value; }
        public DateTime EndDate { get => endTime; set => endTime = value; }
        public string CreationDate { get => creationDate; set => creationDate = value; }
        public static DataTable? GetContractsToLoad()
        {
            string sql =
                $@"SELECT 
	                Contract_ID
	                , Name
                    , Club
                    , Player
                    , Position
                    , Start_Date
                    , End_Date
                    , Creation_Date
	                , NextContractID
	                , PreviousContractID
	                , RowNumber
	                , (SELECT TOP(1) Contract_ID FROM Contract ORDER BY Contract_ID) AS FirstContractID
	                , (SELECT TOP(1) Contract_ID FROM Contract ORDER BY Contract_ID DESC) AS LastContractID
                FROM
                (
	                SELECT 
		                C.Contract_ID
		                , (CL.Name + ' - ' + P.Name) AS Name
                        , CL.Club_ID
                        , CL.Name AS Club
                        , P.Player_ID
                        , P.Name AS Player
                        , PS.Position_ID
                        , PS.Name AS Position
                        , C.Start_Date
                        , C.End_Date
                        , C.Creation_Date
		                , LEAD(C.Contract_ID) OVER(ORDER BY C.Contract_ID) AS NextContractID 
		                , LAG(C.Contract_ID) OVER(ORDER BY C.Contract_ID) AS PreviousContractID
		                , ROW_NUMBER() OVER(ORDER BY C.Contract_ID) AS RowNumber
	                FROM Contract C INNER JOIN Club CL ON CL.Club_ID = C.Club_ID 
                    INNER JOIN Player P ON P.Player_ID = C.Player_ID
                    INNER JOIN Position PS ON PS.Position_ID = P.Position_ID
                ) AS Contracts;";

            DataTable Players = DataAccess.GetData(sql);

            return Players;
        }
        public static DataSet? GetContractsToLoadById(int contractId)
        {
            string sqlDetails = @"SELECT C.Contract_ID, (CL.Name + ' - ' + P.Name) AS Name, 
                CL.Club_ID, CL.Name AS Club, P.Player_ID, P.Name AS Player, C.Start_Date, 
                C.End_Date, C.Creation_Date FROM Contract C INNER JOIN Club CL 
                ON CL.Club_ID = C.Club_ID INNER JOIN Player P ON P.Player_ID = C.Player_ID 
                WHERE C.Contract_ID = @ContractId ORDER BY C.Contract_ID;";

            string sqlContract = $@"
                SELECT 
	                Contract_ID
	                , Name
                    , Club_ID
                    , Club
                    , Player_ID
                    , Player
                    , Start_Date
                    , End_Date
                    , Creation_Date
	                , NextContractID
	                , PreviousContractID
	                , RowNumber
	                , (SELECT TOP(1) Contract_ID FROM Contract ORDER BY Contract_ID) AS FirstContractID
	                , (SELECT TOP(1) Contract_ID FROM Contract ORDER BY Contract_ID DESC) AS LastContractID
                FROM
                (
	                SELECT 
		                C.Contract_ID
		                , (CL.Name + ' - ' + P.Name) AS Name
                        , CL.Club_ID
                        , CL.Name AS Club
                        , P.Player_ID
                        , P.Name AS Player
                        , C.Start_Date
                        , C.End_Date
                        , C.Creation_Date
		                , LEAD(C.Contract_ID) OVER(ORDER BY C.Contract_ID) AS NextContractID 
		                , LAG(C.Contract_ID) OVER(ORDER BY C.Contract_ID) AS PreviousContractID
		                , ROW_NUMBER() OVER(ORDER BY C.Contract_ID) AS RowNumber
	                FROM Contract C INNER JOIN Club CL ON CL.Club_ID = C.Club_ID 
                INNER JOIN Player P ON P.Player_ID = C.Player_ID
                ) AS Contracts
                WHERE Contract_ID = @ContractId;";

            SqlParameter[] contractIdParam = [
                new SqlParameter("@ContractId", contractId)
                ];

            string[] sqlQueries = new string[] { sqlDetails, sqlContract };

            DataSet dsPlayerInfo = DataAccess.GetData(contractIdParam, sqlQueries);

            return dsPlayerInfo;
        }
        public static int GetFirstContract()
        {
            var sql = "SELECT TOP 1 Contract_ID FROM Contract ORDER BY Contract_ID";

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
        public static DataTable GetContracts()
        {
            var getQuery = @"SELECT Contract_ID, (CL.Name + ' - ' + P.Name) AS Name
                FROM Contract C INNER JOIN Club CL ON CL.Club_ID = C.Club_ID
                INNER JOIN Player P ON P.Player_ID = C.Player_ID";

            DataTable dtPlayers = DataAccess.GetData(getQuery);

            return dtPlayers;
        }
        public static List<Contract>? GetContractsByClub_Player(string clubName, string playerName)
        {
            var getQuery = String.Empty;
            if (clubName != null && playerName != null)
            {
                getQuery = @"SELECT C.Contract_ID, P.Player_ID, P.Name AS 
                Player, PS.Name AS Position, C.Start_Date, C.End_Date,
                C.Creation_Date FROM Contract C INNER JOIN Club CL ON CL.Club_ID = C.Club_ID 
                INNER JOIN Player P ON P.Player_ID = C.Player_ID
                INNER JOIN Position PS ON PS.Position_ID = P.Position_ID
                WHERE CL.Name LIKE @ClubName";
            } else if (playerName == null || clubName == null)
            {
                getQuery = @"SELECT C.Contract_ID, C.Club_ID, CL.Name AS Club, 
                PS.Name AS Position, C.Start_Date, C.End_Date,
                C.Creation_Date FROM Contract C INNER JOIN Club CL ON CL.Club_ID = C.Club_ID 
                INNER JOIN Player P ON P.Player_ID = C.Player_ID
                INNER JOIN Position PS ON PS.Position_ID = P.Position_ID
                WHERE P.Name LIKE @PlayerName";
            } 
            SqlParameter[] contractParam = [
                new SqlParameter("@ClubName", SqlDbType.NVarChar, 255){
                Value = (clubName == null) ? DBNull.Value : "%" + clubName + "%"
                },
                new SqlParameter("@PlayerName", SqlDbType.NVarChar, 255){
                Value = (playerName == null) ? DBNull.Value : "%" + playerName + "%"
                }
                ];

            List<Contract> contracts = DataAccess.GetContracts(getQuery, contractParam);

            if (contracts.Count > 0)
            {
                return contracts;
            }
            else
            {
                Console.WriteLine($"No contracts found");
                return null;
            }
        }
        public static List<Contract>? GetPlayersByClub(string clubName)
        {

            string getQuery = @"SELECT C.Contract_ID, P.Player_ID, P.Name AS 
            Player, PS.Name AS Position, C.Start_Date, C.End_Date, C.Creation_Date 
            FROM Contract C INNER JOIN Club CL ON CL.Club_ID = C.Club_ID 
            INNER JOIN Player P ON P.Player_ID = C.Player_ID
            INNER JOIN Position PS ON PS.Position_ID = P.Position_ID
            WHERE CL.Name LIKE @ClubName";

            SqlParameter[] contractParam = [
                new SqlParameter("@ClubName", SqlDbType.NVarChar, 255){
                Value = "%" + clubName + "%"
                }
                ];

            List<Contract> contracts = DataAccess.GetPlayersByClub(getQuery, contractParam);

            if (contracts.Count > 0)
            {
                return contracts;
            }
            else
            {
                Console.WriteLine($"No contracts found");
                return null;
            }
        }
        public static List<Contract>? GetClubsByPlayer(string playerName)
        {
            string getQuery = @"SELECT C.Contract_ID, C.Club_ID, CL.Name AS 
            Club, PS.Name AS Position, C.Start_Date, C.End_Date, C.Creation_Date 
            FROM Contract C INNER JOIN Club CL ON CL.Club_ID = C.Club_ID 
            INNER JOIN Player P ON P.Player_ID = C.Player_ID
            INNER JOIN Position PS ON PS.Position_ID = P.Position_ID
            WHERE P.Name LIKE @PlayerName";

            SqlParameter[] contractParam = [
                new SqlParameter("@PlayerName", SqlDbType.NVarChar, 255){
                Value = "%" + playerName + "%"
                }
                ];

            List<Contract> contracts = DataAccess.GetClubsByPlayer(getQuery, contractParam);

            if (contracts.Count > 0)
            {
                return contracts;
            }
            else
            {
                Console.WriteLine($"No contracts found");
                return null;
            }
        }
        public static bool CreateContract(Contract newContract)
        {
            string insertQuery = "INSERT INTO Contract (Club_ID, Player_ID, Start_Date, End_Date) " +
                "VALUES (@ClubId, @PlayerId, @StartDate, @EndDate)";

            SqlParameter[] insertParams = [
            new SqlParameter("@ClubId", newContract.ClubId),
            new SqlParameter("@PlayerId", newContract.playerId),
            new SqlParameter("@StartDate", newContract.StartDate.Date),
            new SqlParameter("@EndDate", newContract.EndDate.Date)
            ];

            int rowsInserted = DataAccess.ManageData(insertQuery, insertParams);

            if (rowsInserted > 0)
            {
                Console.WriteLine("Contract created successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Error: Failed to create contract.");
                return false;
            }
        }
        public static bool UpdateContract(Contract contractToUpdate)
        {
            // Construct the SQL UPDATE statement
            string updateSql = "UPDATE Contract SET Club_ID = @ClubId, " +
                "Player_ID = @PlayerId, Start_Date = @StartDate, End_Date = @EndDate " +
                "WHERE Contract_ID = @ContractId";

            // Create the SqlParameter array
            SqlParameter[] updateParams = [
            new SqlParameter("@ContractId", contractToUpdate.ContractId),
            new SqlParameter("@ClubId", contractToUpdate.ClubId),
            new SqlParameter("@PlayerId", contractToUpdate.PlayerId),
            new SqlParameter("@StartDate", contractToUpdate.StartDate.Date),
            new SqlParameter("@EndDate", contractToUpdate.EndDate.Date)
            ];

            // Call the UpdateData method
            int rowsUpdated = DataAccess.ManageData(updateSql, updateParams);

            // Check the number of rows updated
            if (rowsUpdated > 0)
            {
                Console.WriteLine("Contract updated successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Failed to update contract.");
                return false;
            }
        }
        public static bool DeleteContract(int contractId)
        {
            string deleteQuery = "DELETE FROM Contract WHERE Contract_ID = @ContractId";

            SqlParameter[] deleteParams = [
            new SqlParameter("@ContractId", contractId)
            ];

            int rowsDeleted = DataAccess.ManageData(deleteQuery, deleteParams);

            if (rowsDeleted > 0)
            {
                Console.WriteLine("Contract deleted successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Error: Failed to delete contract.");
                return false;
            }
        }
    }
}
