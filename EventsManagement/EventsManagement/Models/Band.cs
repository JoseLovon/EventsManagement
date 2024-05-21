using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsManagement.Models
{
    public class Band
    {
        private int bandId;
        private string? name;
        private int? genreId;
        private string? genreName;

        public Band(int bandId, string? name, int? genreId, string? genreName)
        {
            BandId = bandId;
            Name = name;
            GenreId = genreId;
            GenreName = genreName;
        }
        public Band(string? name, int? genreId, string? genreName)
        {
            Name = name;
            GenreId = genreId;
            GenreName = genreName;
        }
        public Band(int bandId, string? name, int? genreId)
        {
            BandId = bandId;
            Name = name;
            GenreId = genreId;
        }
        public int BandId { get => bandId; set => bandId = value; }
        public string? Name { get => name; set => name = value; }
        public int? GenreId { get => genreId; set => genreId = value; }
        public string? GenreName { get => genreName; set => genreName = value; }

        private static Band? GetbandById(int bandId)
        {
            var getQuery = $"SELECT A.band_ID, A.Name, G.Genre_ID, G.Name AS " +
                $"Genre FROM band A INNER JOIN Genre G ON G.Genre_ID = A.Genre_ID " +
                $"WHERE A.band_ID = @BandId";

            SqlParameter[] bandIdParam = [
                new SqlParameter("@BandId", bandId)
                ];

            List<Band> bands = DataAccess.Getbands(getQuery, bandIdParam);

            if (bands.Count > 0)
            {
                return bands[0];
            }
            else
            {
                Console.WriteLine($"No band found with ID: {bandId}");
                return null;
            }
        }
        private static List<Band>? GetbandByName(string bandName)
        {
            var getQuery = $"SELECT A.band_ID, A.Name, G.Genre_ID, G.Name AS " +
                $"Genre FROM band A INNER JOIN Genre G ON G.Genre_ID = A.Genre_ID " +
                $"WHERE A.Name LIKE %@bandName%";

            SqlParameter[] bandIdParam = [
                new SqlParameter("@bandName", bandName)
                ];

            List<Band> bands = DataAccess.Getbands(getQuery, bandIdParam);

            if (bands.Count > 0)
            {
                return bands;
            }
            else
            {
                Console.WriteLine($"No band found");
                return null;
            }
        }
        private static List<Band>? GetbandByGenre(string genre)
        {
            var getQuery = $"SELECT A.band_ID, A.Name, G.Genre_ID, G.Name AS " +
                $"Genre FROM band A INNER JOIN Genre G ON G.Genre_ID = A.Genre_ID " +
                $"WHERE G.Name LIKE %@GenreName%";

            SqlParameter[] bandIdParam = [
                new SqlParameter("@GenreName", genre)
                ];

            List<Band> bands = DataAccess.Getbands(getQuery, bandIdParam);

            if (bands.Count > 0)
            {
                return bands;
            }
            else
            {
                Console.WriteLine($"No band found");
                return null;
            }
        }

        private static bool Createband(Band newband)
        {
            string insertQuery = "INSERT INTO band (Name, Genre_ID, Creation_Date) " +
                "VALUES (@Name, @GenreId, @CreationDate)";

            SqlParameter[] insertParams = [
            new SqlParameter("@Name", newband.Name),
            new SqlParameter("@GenreId", newband.GenreId),
            new SqlParameter("@CreationDate", DateTime.Now)
            ];

            int rowsInserted = DataAccess.ManageData(insertQuery, insertParams);

            if (rowsInserted > 0)
            {
                Console.WriteLine("band created successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("band: Failed to create event.");
                return false;
            }
        }
        private static bool Updateband(Band bandToUpdate)
        {
            // Construct the SQL UPDATE statement
            string updateSql = "UPDATE band SET Name = @Name, " +
                "Genre_ID = @GenreId WHERE band_ID = @BandId";

            // Create the SqlParameter array
            SqlParameter[] updateParams = [
            new SqlParameter("@BandId", bandToUpdate.BandId),
            new SqlParameter("@Name", bandToUpdate.Name),
            new SqlParameter("@GenreId", bandToUpdate.GenreId)
            ];

            // Call the UpdateData method
            int rowsUpdated = DataAccess.ManageData(updateSql, updateParams);

            // Check the number of rows updated
            if (rowsUpdated > 0)
            {
                Console.WriteLine("band updated successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Failed to update band.");
                return false;
            }
        }
        private static bool Deleteband(int bandId)
        {
            string deleteQuery = "DELETE FROM band WHERE band_ID = @BandId";

            SqlParameter[] deleteParams = [
            new SqlParameter("@BandId", bandId)
            ];

            int rowsDeleted = DataAccess.ManageData(deleteQuery, deleteParams);

            if (rowsDeleted > 0)
            {
                Console.WriteLine("band deleted successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Error: Failed to delete band.");
                return false;
            }
        }
    }
}
