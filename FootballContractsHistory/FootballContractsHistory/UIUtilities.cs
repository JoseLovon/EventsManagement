using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballContractsHistory
{
    public static class UIUtilities
    {
        public static void Bind(this ListControl control, string displayMember, string valueMember, DataTable? dataSource)
        {
            control.DataSource = null;
            control.DataSource = dataSource;
            control.DisplayMember = displayMember;
            control.ValueMember = valueMember;
        }
        public static void AddEmptyRow(this DataTable dt, string emptyColumnName, string nullColumnName, object? emptyValue = null)
        {
            if(emptyValue == null)
            {
                emptyValue = DBNull.Value;
            }

            DataRow dr = dt.NewRow();
            //dr[emptyColumnName] = string.Empty;
            if(nullColumnName == "Position_ID")
            {
                dr[emptyColumnName] = "-- Please select a position --";
            } else if (nullColumnName == "Club_ID")
            {
                dr[emptyColumnName] = "-- Please select a club --";
            }
            else if (nullColumnName == "Player_ID")
            {
                dr[emptyColumnName] = "-- Please select a player --";
            }
            else if (nullColumnName == "Contract_ID")
            {
                dr[emptyColumnName] = "-- Please select a contract --";
            }

            dr[nullColumnName] = emptyValue;
            dt.Rows.InsertAt(dr, 0);
        }
    }
}
