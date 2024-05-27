using System;
using System.Collections.Generic;
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
        private DateTime startTime;
        private DateTime endTime;

        public Contract(int contractId, int clubId, string? clubName, int playerId, string? playerName, DateTime startDate, DateTime endDate)
        {
            ContractId = contractId;
            ClubId = clubId;
            ClubName = clubName;
            PlayerId = playerId;
            PlayerName = playerName;
            StartDate = startDate;
            EndDate = endDate;
        }
        public Contract(int clubId, string? clubName, int playerId, string? playerName, DateTime startDate, DateTime endDate)
        {
            ClubId = clubId;
            ClubName = clubName;
            PlayerId = playerId;
            PlayerName = playerName;
            StartDate = startDate;
            EndDate = endDate;
        }
        public int ContractId { get => contractId; set => contractId = value; }
        public int ClubId { get => clubId; set => clubId = value; }
        public string? ClubName { get => clubName; set => clubName = value; }
        public int PlayerId { get => playerId; set => playerId = value; }
        public string? PlayerName { get => playerName; set => playerName = value; }
        public DateTime StartDate { get => startTime; set => startTime = value; }
        public DateTime EndDate { get => endTime; set => endTime = value; }

        private static Contract? GetContractById(int contractId)
        {
            var getQuery = $"SELECT C.Contract_ID, C.Club_ID, CL.Name AS Club, " +
                $"P.Player_ID, P.Name AS Player, CL.Start_Date, CL.End_Date " +
                $"FROM Contract C INNER JOIN Club CL ON CL.Club_ID = C.Club_ID " +
                $"INNER JOIN Player P ON P.Player_ID = C.Player_ID " +
                $"WHERE C.Contract_ID = @ContractId";

            SqlParameter[] contractIdParam = [
                new SqlParameter("@ContractId", contractId)
                ];

            List<Contract> contracts = DataAccess.GetContracts(getQuery, contractIdParam);

            if (contracts.Count > 0)
            {
                return contracts[0];
            }
            else
            {
                Console.WriteLine($"No contract found with ID: {contractId}");
                return null;
            }
        }
        private static List<Contract>? GetContractsByPlayer(int playerName)
        {
            var getQuery = $"SELECT C.Contract_ID, C.Club_ID, CL.Name AS Club, " +
                $"P.Player_ID, P.Name AS Player, CL.Start_Date, CL.End_Date " +
                $"FROM Contract C INNER JOIN Club CL ON CL.Club_ID = C.Club_ID " +
                $"INNER JOIN Player P ON P.Player_ID = C.Player_ID " +
                $"WHERE P.Name LIKE %@PlayerName%";

            SqlParameter[] playerNameParam = [
                new SqlParameter("@PlayerName", playerName)
                ];

            List<Contract> contracts = DataAccess.GetContracts(getQuery, playerNameParam);

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
        //Most likely to use for search
        private static List<Contract>? GetContractsByClub(string clubName)
        {
            var getQuery = $"SELECT C.Contract_ID, C.Club_ID, CL.Name AS Club, " +
                $"P.Player_ID, P.Name AS Player, CL.Start_Date, CL.End_Date " +
                $"FROM Contract C INNER JOIN Club CL ON CL.Club_ID = C.Club_ID " +
                $"INNER JOIN Player P ON P.Player_ID = C.Player_ID " +
                $"WHERE CL.Name LIKE %@ClubName%";

            SqlParameter[] clubNameParam = [
                new SqlParameter("@ClubName", clubName)
                ];

            List<Contract> contracts = DataAccess.GetContracts(getQuery, clubNameParam);

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
        private static bool CreateContract(Contract newContract)
        {
            string insertQuery = "INSERT INTO Contract (Club_ID, Player_ID, Start_Date, End_Date) " +
                "VALUES (@ClubId, @PlayerId, @StartDate, @EndDate)";

            SqlParameter[] insertParams = [
            new SqlParameter("@ClubId", newContract.ClubId),
            new SqlParameter("@PlayerId", newContract.playerId),
            new SqlParameter("@StartDate", newContract.StartDate.ToString("HH:mm:ss")),
            new SqlParameter("@EndDate", newContract.EndDate.ToString("HH:mm:ss"))
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
        private static bool UpdateContract(Contract contractToUpdate)
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
            new SqlParameter("@StartDate", contractToUpdate.StartDate.ToString("HH:mm:ss")),
            new SqlParameter("@EndDate", contractToUpdate.EndDate.ToString("HH:mm:ss"))
            ];

            // Call the UpdateData method
            int rowsUpdated = DataAccess.ManageData(updateSql, updateParams);

            // Check the number of rows updated
            if (rowsUpdated > 0)
            {
                Console.WriteLine("Presentation updated successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Failed to update presentation.");
                return false;
            }
        }
        private static bool DeleteContract(int contractId)
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
