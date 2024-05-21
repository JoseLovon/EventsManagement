using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsManagement.Models
{
    public class Genre
    {
        private int genreId;
        private string? name;

        public Genre(int genreId, string? name)
        {
            GenreId = genreId;
            Name = name;
        }

        public int GenreId { get => genreId; set => genreId = value; }
        public string? Name { get => name; set => name = value; }

        private List<Genre>? GetGenres()
        {
            var getQuery = $"SELECT GenreId, Name, FROM Genre ORDER BY Name";

            List<Genre> events = DataAccess.GetGenres(getQuery);

            if (events.Count > 0)
            {
                return events;
            }
            else
            {
                Console.WriteLine($"No events found");
                return null;
            }
        }
    }
}
