using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameSpot.App_Code;

namespace GameSpot
{
    public partial class Review : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //List met reviews updaten
            Administration.UpdateReviewList();

            //Elke item uit de list aan de ASP tabel toevoegen
            foreach (ReviewClass review in Administration.reviews)
            {
                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                cell.Text = Convert.ToString(review.titel);
                row.Cells.Add(cell);

                TableCell cell1 = new TableCell();
                cell1.Text = Convert.ToString(review.theGame);
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = Convert.ToString(review.auteur);
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = review.postDatum;
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = review.platform;
                row.Cells.Add(cell4);

                TableCell cell5 = new TableCell();
                cell5.Text = Convert.ToString(review.rating);
                row.Cells.Add(cell5);

                tblReview.Rows.Add(row);
            }
        }
    }
}