﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameSpot.App_Code;

namespace GameSpot
{
    public partial class Nieuws : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Eerst de list updaten van nieuws artikelen
            Administration.UpdateNieuwsList();

            //Daarna alle nieuws artikelen toevoegen aan de asp tabel
            foreach(NieuwsClass n in Administration.nieuws)
            {
                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                cell.Text = Convert.ToString(n.titel);
                row.Cells.Add(cell);

                TableCell cell1 = new TableCell();
                cell1.Text = Convert.ToString(n.theGame);
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = Convert.ToString(n.auteur);
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = n.postDatum;
                row.Cells.Add(cell3);

                tblNieuws.Rows.Add(row);
            }
        }
    }
}