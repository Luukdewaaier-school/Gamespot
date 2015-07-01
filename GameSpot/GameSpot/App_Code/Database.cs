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
        /// <summary>
        /// Fields voor die essentieel zijn voor de connectie met de database
        /// </summary>
        private static string host = "//localhost:1521/xe";
        private static string username = "system";
        private static string password = "classified";
        private static string oracleDatabase = "User Id=" + username + ";Password=" + password + ";Data Source= " + host + ";";

        /// <summary>
        /// Deze functie voert een query uit op de database dit kan een INSERT, SELECT, DELETE of een UPDATE zijn.
        /// </summary>
        /// <param name="query"></param> De parameter query is een string die je meegeeft. Deze word uitegevoerd op de database
        /// <returns></returns>
        public static DataTable RunQuery(string query)
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