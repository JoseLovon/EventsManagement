using FootballContractsHistory.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballContractsHistory
{
    public static class DataAccess
    {
        public static DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public static DataSet GetData(params string[] sqlQueries)
        {
            string sqlQuery = string.Join(",", sqlQueries);

            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                }
            }
            return ds;
        }
        public static object ExecuteScalar(string sqlQuery)
        {
            using (SqlConnection connection = new SqlConnection(getConnectionString()))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();

                    return command.ExecuteScalar();
                }
            }
        }
        #region User
        public static List<User> GetUsers(string sql, SqlParameter[]? parameters = null)
        {
            List<User> users = new List<User>();
            using (SqlConnection conn = new SqlConnection(getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userId = reader.GetInt32(reader.GetOrdinal("Userr_ID"));
                            string username = reader.GetString(reader.GetOrdinal("Username"));

                            User us = new User(userId, username);
                            users.Add(us);
                        }
                    }
                }
            }
            return users;
        }
        #endregion
        #region Club
        public static List<Club> GetClubs(string sql, SqlParameter[]? parameters = null)
        {
            List<Club> clubs = new List<Club>();
            using (SqlConnection conn = new SqlConnection(getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int clubId = reader.GetInt32(reader.GetOrdinal("Club_ID"));
                            int userId = reader.GetInt32(reader.GetOrdinal("Userr_ID"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string description = reader.GetString(reader.GetOrdinal("Description"));

                            Club ev = new Club(clubId, userId, name, description);
                            clubs.Add(ev);
                        }
                    }
                }
            }
            return clubs;
        }
        #endregion
        #region Position
        public static List<Position> GetPositions(string sql, SqlParameter[]? parameters = null)
        {
            List<Position> positions = new List<Position>();
            using (SqlConnection conn = new SqlConnection(getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int positionId = reader.GetInt32(reader.GetOrdinal("Position_ID"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));

                            Position gr = new Position(positionId, name);
                            positions.Add(gr);
                        }
                    }
                }
            }
            return positions;
        }
        #endregion
        #region Player
        public static List<Player> GetPlayers(string sql, SqlParameter[]? parameters = null)
        {
            List<Player> players = new List<Player>();
            using (SqlConnection conn = new SqlConnection(getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int bandId = reader.GetInt32(reader.GetOrdinal("Player_ID"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            int positionId = reader.GetInt32(reader.GetOrdinal("Position_ID"));
                            string position = reader.GetString(reader.GetOrdinal("Position"));

                            Player at = new Player(bandId, name, positionId, position);
                            players.Add(at);
                        }
                    }
                }
            }
            return players;
        }
        #endregion
        #region Contract
        public static List<Contract> GetContracts(string sql, SqlParameter[]? parameters = null)
        {
            List<Contract> contracts = new List<Contract>();
            using (SqlConnection conn = new SqlConnection(getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int presentationId = reader.GetInt32(reader.GetOrdinal("Contract_ID"));
                            int clubId = reader.GetInt32(reader.GetOrdinal("Club_ID"));
                            string clubName = reader.GetString(reader.GetOrdinal("Club"));
                            int playerId = reader.GetInt32(reader.GetOrdinal("Player_ID"));
                            string playerName = reader.GetString(reader.GetOrdinal("Player"));
                            DateTime startTime = reader.GetDateTime(reader.GetOrdinal("Start_Time"));
                            DateTime endTime = reader.GetDateTime(reader.GetOrdinal("End_Time"));

                            Contract p = new Contract(presentationId, clubId, clubName, 
                                playerId, playerName, startTime, endTime);
                            contracts.Add(p);
                        }
                    }
                }
            }
            return contracts;
        }
        #endregion
        public static int ManageData(string sql, SqlParameter[]? parameters = null)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
        private static string getConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FootballContractsHistory"].ConnectionString;
            return connectionString;
        }
    }
}
