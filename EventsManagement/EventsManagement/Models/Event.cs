using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsManagement.Models
{
    public class Event
    {
        private int eventId;
        private int userId;
        private string? name;
        private string? description;
        private DateTime eventDate;

        public Event(int eventId, int userId, string? name, string? description, DateTime eventDate)
        {
            EventId = eventId;
            UserId = userId;
            Name = name;
            Description = description;
            EventDate = eventDate;
        }
        public Event(int userId, string? name, string? description, DateTime eventDate)
        {
            UserId = userId;
            Name = name;
            Description = description;
            EventDate = eventDate;
        }
        public int EventId { get => eventId; set => eventId = value; }
        public int UserId { get => userId; set => userId = value; }
        public string? Name { get => name; set => name = value; }
        public string? Description { get => description; set => description = value; }
        public DateTime EventDate { get => eventDate; set => eventDate = value; }

        private Event? GetEventById(int eventId)
        {
            var getQuery = $"SELECT EventId, UserId, Name, Description, Event_Date FROM Event " +
                                    $"WHERE EventId = @EventId ORDER BY Name";
            
            SqlParameter[] eventIdParam = [
                new SqlParameter("@EventId", eventId)
                ];

            List<Event> events = DataAccess.GetEvents(getQuery, eventIdParam);

            if (events.Count > 0)
            {
                return events[0];
            }
            else
            {
                Console.WriteLine($"No event found with ID: {eventId}");
                return null;
            }
        }
        private List<Event>? GetEventByName(string eventName)
        {
            var getQuery = $"SELECT EventId, UserId, Name, Description, Event_Date FROM Event " +
                                    $"WHERE Name = @EventName ORDER BY Name";

            SqlParameter[] eventIdParam = [
                new SqlParameter("@EventName", eventName)
                ];

            List<Event> events = DataAccess.GetEvents(getQuery, eventIdParam);

            if (events.Count > 0)
            {
                return events;
            }
            else
            {
                Console.WriteLine($"No event found with ID: {eventId}");
                return null;
            }
        }
        private List<Event>? GetEventByDate(DateTime selectedDate)
        {
            var getQuery = $"SELECT EventId, UserId, Name, Description, Event_Date FROM Event " +
                                    $"WHERE EventDate = @EventDate ORDER BY Name";

            SqlParameter[] eventIdParam = [
                new SqlParameter("@EventDate", selectedDate)
                ];

            List<Event> events = DataAccess.GetEvents(getQuery, eventIdParam);

            if (events.Count > 0)
            {
                return events;
            }
            else
            {
                Console.WriteLine($"No events found with EventDate: {eventId}");
                return null;
            }
        }

        private bool CreateEvent(Event newEvent)
        {
            string insertQuery = "INSERT INTO Event (Name, Description, EventDate) " +
                "VALUES (@Name, @Description, @EventDate)";

            SqlParameter[] insertParams = [
            new SqlParameter("@Name", newEvent.Name),
            new SqlParameter("@Description", newEvent.Description),
            new SqlParameter("@EventDate", newEvent.EventDate.Date)
            ];

            int rowsInserted = DataAccess.ManageData(insertQuery, insertParams);

            if (rowsInserted > 0)
            {
                Console.WriteLine("Event created successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Error: Failed to create event.");
                return false;
            }
        }
        private bool UpdateEvent(Event eventToUpdate)
        {
            // Construct the SQL UPDATE statement
            string updateSql = "UPDATE Event SET Name = @Name, " +
                "Description = @Description, " +
                "EventDate = @EventDate " +
                "WHERE EventId = @EventId";

            // Create the SqlParameter array
            SqlParameter[] updateParams = [
            new SqlParameter("@Name", eventToUpdate.Name),
            new SqlParameter("@Description", eventToUpdate.Description),
            new SqlParameter("@EventDate", eventToUpdate.EventDate),
            new SqlParameter("@EventId", eventToUpdate.EventId)
            ];

            // Call the UpdateData method
            int rowsUpdated = DataAccess.ManageData(updateSql, updateParams);

            // Check the number of rows updated
            if (rowsUpdated > 0)
            {
                Console.WriteLine("Event updated successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Failed to update event.");
                return false;
            }
        }
        private bool DeleteEvent(int eventId)
        {
            string deleteQuery = "DELETE FROM Event WHERE EventId = @EventId";

            SqlParameter[] deleteParams = [
            new SqlParameter("@EventId", eventId)
            ];

            int rowsDeleted = DataAccess.ManageData(deleteQuery, deleteParams);

            if (rowsDeleted > 0)
            {
                Console.WriteLine("Event deleted successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Error: Failed to delete event.");
                return false;
            }
        }
    }
}
