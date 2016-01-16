using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewModel.DbHandler
{
    class DbConnection
    {
        private static String connectionString = @"Data Source=MDU\SQLEXPRESS; Initial Catalog=TestDB; Integrated Security=True";
        //change here to own SQL Serve
        private static SqlConnection dbConnection = new SqlConnection(connectionString);
        private static SqlCommand dbCommand = new SqlCommand(null, dbConnection);

        public static void Open()
        {
            if (dbConnection.State.ToString().CompareTo("Open") != 0)
            {
                dbConnection.Open();
            }
        }

        public static void Close()
        {
            dbConnection.Close();
        }

        public static SqlCommand GetDbCommand(String sqlQuery)
        {
            if (dbConnection.State.ToString().Equals("Open") == true)
            {
                Close();
            }
            Open();
            if (dbCommand == null)
            {
                dbCommand = new SqlCommand(sqlQuery, dbConnection);
            }
            dbCommand.CommandText = sqlQuery;
            return dbCommand;
        }
    }
}
