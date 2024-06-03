using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballContractsHistory.Models
{
    public class Position
    {
        private int positionId;
        private string? name;
        public Position()
        {
        }
        public Position(int positionId, string? name)
        {
            PositionId = positionId;
            Name = name;
        }

        public int PositionId { get => positionId; set => positionId = value; }
        public string? Name { get => name; set => name = value; }

        public static DataTable GetPositions()
        {
            var getQuery = $"SELECT Position_ID, Name FROM Position ORDER BY Name";

            DataTable dtPositions = DataAccess.GetData(getQuery);
            
            return dtPositions;
        }
    }
}
