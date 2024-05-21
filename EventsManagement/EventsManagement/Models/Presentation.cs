using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsManagement.Models
{
    public class Presentation
    {
        private int presentationId;
        private int eventId;
        private string? eventName;
        private int bandId;
        private string? bandName;
        private DateTime startTime;
        private DateTime endTime;

        public Presentation(int presentationId, int eventId, string? eventName, int bandId, string? bandName, DateTime startTime, DateTime endTime)
        {
            PresentationId = presentationId;
            EventId = eventId;
            EventName = eventName;
            BandId = bandId;
            BandName = bandName;
            StartTime = startTime;
            EndTime = endTime;
        }
        public Presentation(int eventId, string? eventName, int bandId, string? bandName, DateTime startTime, DateTime endTime)
        {
            EventId = eventId;
            EventName = eventName;
            BandId = bandId;
            BandName = bandName;
            StartTime = startTime;
            EndTime = endTime;
        }
        public int PresentationId { get => presentationId; set => presentationId = value; }
        public int EventId { get => eventId; set => eventId = value; }
        public string? EventName { get => eventName; set => eventName = value; }
        public int BandId { get => bandId; set => bandId = value; }
        public string? BandName { get => bandName; set => bandName = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }

        private static Presentation? GetPresentationById(int presentationId)
        {
            var getQuery = $"SELECT P.Presentation_ID, P.Event_ID, E.Name AS Event," +
                $" P.band_ID, A.Name AS band FROM Presentation P" +
                $" INNER JOIN band A ON P.band_ID = A.band_ID" +
                $" INNER JOIN Event E ON E.Event_ID = P.Event_ID " +
                $"WHERE P.Presentation_ID = @PresentationId";

            SqlParameter[] presentationIdParam = [
                new SqlParameter("@PresentationId", presentationId)
                ];

            List<Presentation> presentations = DataAccess.GetPresentations(getQuery, presentationIdParam);

            if (presentations.Count > 0)
            {
                return presentations[0];
            }
            else
            {
                Console.WriteLine($"No presentation found with ID: {presentationId}");
                return null;
            }
        }
        private static List<Presentation>? GetPresentationByName(int presentationName)
        {
            var getQuery = $"SELECT P.Presentation_ID, P.Event_ID, E.Name AS Event," +
                $" P.band_ID, A.Name AS band, P.Start_Time, P.End_Time FROM Presentation P" +
                $" INNER JOIN band A ON P.band_ID = A.band_ID" +
                $" INNER JOIN Event E ON E.Event_ID = P.Event_ID " +
                $"WHERE P.Name LIKE %@PresentationName%";

            SqlParameter[] presentationIdParam = [
                new SqlParameter("@PresentationName", presentationName)
                ];

            List<Presentation> presentations = DataAccess.GetPresentations(getQuery, presentationIdParam);

            if (presentations.Count > 0)
            {
                return presentations;
            }
            else
            {
                Console.WriteLine($"No presentations found");
                return null;
            }
        }
        //Most likely to use for search
        private static List<Presentation>? GetPresentationByEventName(string eventName)
        {
            var getQuery = $"SELECT P.Presentation_ID, P.Event_ID, E.Name AS Event," +
                $" P.band_ID, A.Name AS band, P.Start_Time, P.End_Time FROM Presentation P" +
                $" INNER JOIN band A ON P.band_ID = A.band_ID" +
                $" INNER JOIN Event E ON E.Event_ID = P.Event_ID " +
                $"WHERE E.Name LIKE %@EventName%";

            SqlParameter[] presentationIdParam = [
                new SqlParameter("@EventName", eventName)
                ];

            List<Presentation> presentations = DataAccess.GetPresentations(getQuery, presentationIdParam);

            if (presentations.Count > 0)
            {
                return presentations;
            }
            else
            {
                Console.WriteLine($"No presentations found");
                return null;
            }
        }
        private static List<Presentation>? GetPresentationBybandName(string bandName)
        {
            var getQuery = $"SELECT P.Presentation_ID, P.Event_ID, E.Name AS Event," +
                $" P.band_ID, A.Name AS band, P.Start_Time, P.End_Time FROM Presentation P" +
                $" INNER JOIN band A ON P.band_ID = A.band_ID" +
                $" INNER JOIN Event E ON E.Event_ID = P.Event_ID " +
                $"WHERE A.Name LIKE %@bandName%";

            SqlParameter[] presentationIdParam = [
                new SqlParameter("@bandName", bandName)
                ];

            List<Presentation> presentations = DataAccess.GetPresentations(getQuery, presentationIdParam);

            if (presentations.Count > 0)
            {
                return presentations;
            }
            else
            {
                Console.WriteLine($"No presentations found");
                return null;
            }
        }
        private static bool CreatePresentation(Presentation newPresentation)
        {
            string insertQuery = "INSERT INTO Presentation (Event_ID, band_ID, Start_Time, End_Time) " +
                "VALUES (@EventId, @BandId, @StartTime, @EndTime)";

            SqlParameter[] insertParams = [
            new SqlParameter("@EventId", newPresentation.EventId),
            new SqlParameter("@BandId", newPresentation.bandId),
            new SqlParameter("@StartTime", newPresentation.StartTime),
            new SqlParameter("@EndTime", newPresentation.EndTime)
            ];

            int rowsInserted = DataAccess.ManageData(insertQuery, insertParams);

            if (rowsInserted > 0)
            {
                Console.WriteLine("Presentation created successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Presentation: Failed to create presentation.");
                return false;
            }
        }
        private static bool UpdatePresentation(Presentation presentationToUpdate)
        {
            // Construct the SQL UPDATE statement
            string updateSql = "UPDATE Presentation SET Event_ID = @EventId, " +
                "band_ID = @BandId, Start_Time = @StartTime, End_Time = @EndTime " +
                "WHERE Presentation_ID = @PresentationId";

            // Create the SqlParameter array
            SqlParameter[] updateParams = [
            new SqlParameter("@PresentationId", presentationToUpdate.bandId),
            new SqlParameter("@EventId", presentationToUpdate.EventId),
            new SqlParameter("@BandId", presentationToUpdate.bandId),
            new SqlParameter("@StartTime", presentationToUpdate.StartTime.ToString("HH:mm:ss")),
            new SqlParameter("@EndTime", presentationToUpdate.EndTime.ToString("HH:mm:ss"))
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
        private static bool DeletePresentation(int presentationId)
        {
            string deleteQuery = "DELETE FROM Presentation WHERE Presentation_ID = @PresentationId";

            SqlParameter[] deleteParams = [
            new SqlParameter("@PresentationId", presentationId)
            ];

            int rowsDeleted = DataAccess.ManageData(deleteQuery, deleteParams);

            if (rowsDeleted > 0)
            {
                Console.WriteLine("Presentation deleted successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Error: Failed to delete presentation.");
                return false;
            }
        }
    }
}
