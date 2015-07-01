using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameSpot.App_Code;

namespace GameSpot
{
    public partial class Video : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Lijst van video's updaten 
            Administration.UpdateVideosList();

            //Alles videoclips toevoegen aan de asp tabel
            foreach (Videoclip video in Administration.videoclips)
            {
                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                cell.Text = Convert.ToString(video.titel);
                row.Cells.Add(cell);

                TableCell cell1 = new TableCell();
                cell1.Text = Convert.ToString(video.theGame);
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = Convert.ToString(video.auteur);
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = video.postDatum;
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = video.categorie;
                row.Cells.Add(cell4);

                tblVideoclip.Rows.Add(row);
            }

            //Alle Shows toevoegen aan de ASP tabel
            foreach (Show show in Administration.shows)
            {
                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                cell.Text = Convert.ToString(show.titel);
                row.Cells.Add(cell);

                TableCell cell1 = new TableCell();
                cell1.Text = Convert.ToString(show.theGame);
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = Convert.ToString(show.auteur);
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = show.postDatum;
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = show.startDatum;
                row.Cells.Add(cell4);

                string live;
                if(show.isLive)
                {
                    live = "Live";
                }
                else
                {
                    live = "Niet live";
                }
                TableCell cell5 = new TableCell();
                cell5.Text = live;
                row.Cells.Add(cell5);

                tblShow.Rows.Add(row);
            }
        }
    }
}