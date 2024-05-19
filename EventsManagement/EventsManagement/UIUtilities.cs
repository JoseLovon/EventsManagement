using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsManagement
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
            dr[emptyColumnName] = "-- Please select an option --";
            dr[nullColumnName] = emptyValue;
            dt.Rows.InsertAt(dr, 0);
        }
    }
}
