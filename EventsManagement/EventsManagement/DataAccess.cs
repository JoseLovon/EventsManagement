using EventsManagement.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsManagement
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
                            int userId = reader.GetInt32(reader.GetOrdinal("UserId"));
                            string? username = reader.GetString(reader.GetOrdinal("Username"));

                            User us = new User(userId, username);
                            users.Add(us);
                        }
                    }
                }
            }
            return users;
        }
        #endregion
        #region Event
        public static List<Event> GetEvents(string sql, SqlParameter[]? parameters = null)
        {
            List<Event> events = new List<Event>();
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
                            int eventId = reader.GetInt32(reader.GetOrdinal("EventId"));
                            int userId = reader.GetInt32(reader.GetOrdinal("UserId"));
                            string? name = reader.GetString(reader.GetOrdinal("Name"));
                            string? description = reader.GetString(reader.GetOrdinal("Description"));
                            DateTime eventDate = reader.GetDateTime(reader.GetOrdinal("EventDate"));

                            Event ev = new Event(eventId, userId, name, description, eventDate);
                            events.Add(ev);
                        }
                    }
                }
            }
            return events;
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
            string connectionString = ConfigurationManager.ConnectionStrings["musicCart"].ConnectionString;
            return connectionString;
        }
    }
}
