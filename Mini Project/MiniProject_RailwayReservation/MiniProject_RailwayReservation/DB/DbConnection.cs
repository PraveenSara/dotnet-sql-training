using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_RailwayReservation.DB
{
    internal class DbConnection
    {
        string connectionString = "Data Source = ICS-LT-48QTHT3\\SQLEXPRESS; initial catalog = RailReservationDB; integrated security = true;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
