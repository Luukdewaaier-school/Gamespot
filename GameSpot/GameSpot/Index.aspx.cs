﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameSpot.App_Code;

namespace GameSpot
{
    public partial class Index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Lists updaten, variabelen en instanties om mee te werken
            int i = 0;
            Random rnd = new Random();
            Administration.UpdateVideosList();
            Administration.UpdateReviewList();
            Administration.UpdateNieuwsList();

            //3 random nieuws artikelen toevoegen aan de asp tabel
            while (i < 4)
            {
                int r = rnd.Next(Administration.nieuws.Count);

                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                cell.Text = Convert.ToString(Administration.nieuws[r].titel);
                row.Cells.Add(cell);

                TableCell cell1 = new TableCell();
                cell1.Text = Convert.ToString(Administration.nieuws[r].theGame);
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = Convert.ToString(Administration.nieuws[r].auteur);
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = Administration.nieuws[r].postDatum;
                row.Cells.Add(cell3);

                tblNieuws.Rows.Add(row);
            }
            //3 random reviews toevoegen aan de asp tabel
            i = 0;
            while(i < 4)
            {
                int r = rnd.Next(Administration.reviews.Count);
                
                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                cell.Text = Convert.ToString(Administration.reviews[r].titel);
                row.Cells.Add(cell);

                TableCell cell1 = new TableCell();
                cell1.Text = Convert.ToString(Administration.reviews[r].theGame);
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = Convert.ToString(Administration.reviews[r].auteur);
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = Administration.reviews[r].postDatum;
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = Administration.reviews[r].platform;
                row.Cells.Add(cell4);

                TableCell cell5 = new TableCell();
                cell5.Text = Convert.ToString(Administration.reviews[r].rating);
                row.Cells.Add(cell5);

                tblReview.Rows.Add(row);
                i++;
            }

            //2 random videoclips toevoegen aan de asp tabel
            i = 0;
            while(i < 3)
            {
                int r = rnd.Next(Administration.videoclips.Count);

                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                cell.Text = Convert.ToString(Administration.videoclips[r].titel);
                row.Cells.Add(cell);

                TableCell cell1 = new TableCell();
                cell1.Text = Convert.ToString(Administration.videoclips[r].theGame);
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = Convert.ToString(Administration.videoclips[r].auteur);
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = Administration.videoclips[r].postDatum;
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = Administration.videoclips[r].categorie;
                row.Cells.Add(cell4);

                tblVideoclip.Rows.Add(row);
                i++;
            }
            //2 random shows toevoegen aan de asp tabel
            i = 0;
            while(i < 3)
            {
                int r = rnd.Next(Administration.shows.Count);

                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                cell.Text = Convert.ToString(Administration.shows[r].titel);
                row.Cells.Add(cell);

                TableCell cell1 = new TableCell();
                cell1.Text = Convert.ToString(Administration.shows[r].theGame);
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = Convert.ToString(Administration.shows[r].auteur);
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = Administration.shows[r].postDatum;
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = Administration.shows[r].startDatum;
                row.Cells.Add(cell4);

                string live;
                if (Administration.shows[r].isLive)
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
                i++;
            }
        }
    }
}