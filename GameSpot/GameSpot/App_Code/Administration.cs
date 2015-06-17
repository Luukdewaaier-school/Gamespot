using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace GameSpot
{
    
    public class Administration
    {
        public static List<Nieuws> nieuws;

        public static List<Nieuws> UpdateNieuwsList()
        {
            nieuws = new List<Nieuws>();

            DataTable outcome = Database.RunQuery("");
            DataRow row = outcome.Rows[0];
            string name = (string)row[4];
            int id = Convert.ToInt32(row[0]);
            double price = Convert.ToDouble(row[3]);
            int capacity = Convert.ToInt32(row[2]);
            int number = Convert.ToInt32(row[1]);

            return nieuws;
        }
    }
}