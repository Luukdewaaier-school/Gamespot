using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace GameSpot.App_Code
{
    public class Database
    {
        //Fields
        private static string host = "//localhost:1521/xe";
        private static string username = "system";
        private static string password = "classified";
        private static string oracleDatabase = "User Id=" + username + ";Password=" + password + ";Data Source= " + host + ";";

        {
            //Open connection
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = oracleDatabase;
            connection.Open();

            //Run query
            OracleCommand command = new OracleCommand(query, connection);
            command.BindByName = true;
            OracleDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            //Close connection
            connection.Close();

            //Return outcome
            return dataTable;
        }
    }
}
