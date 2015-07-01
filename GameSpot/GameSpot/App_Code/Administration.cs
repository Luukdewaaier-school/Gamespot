using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using GameSpot.App_Code;

namespace GameSpot
{
    
    public class Administration
    {
        /// <summary>
        /// Fields voor de werking van Administration klasse
        /// </summary>
        public static List<Nieuws> nieuws;
        public static List<Review> reviews;
        public static List<Videoclip> videoclips;
        public static List<Show> shows;
        public static Database db;

        /// <summary>
        /// Een functie om de lijst van nieuws up te daten
        /// </summary>
        public static void UpdateNieuwsList()
        {
            nieuws = new List<Nieuws>();

            DataTable outcome = Database.RunQuery("SELECT * FROM post WHERE type = 'Nieuws' ORDER BY post_datum");
            foreach (DataRow row in outcome.Rows)
            {
                int postId = Convert.ToInt32(row[0]);
                int auteur = Convert.ToInt32(row[1]);
                int theGame = Convert.ToInt32(row[2]);
                string titel = (string)row[3];
                string postDatum = (string)row[4];
                string content = (string)row[5];
                
                Nieuws nieuwsTemp = new Nieuws(postId, auteur, theGame, titel, postDatum, content);
                nieuws.Add(nieuwsTemp);
            }           
        }

        /// <summary>
        /// Een functie om de lijst van reviews up te daten
        /// </summary>
        public static void UpdateReviewList()
        {
            reviews = new List<Review>();

            DataTable outcome = Database.RunQuery("SELECT * FROM post WHERE type = 'Review' ORDER BY post_datum");
            foreach (DataRow row in outcome.Rows)
            {
                int postId = Convert.ToInt32(row[0]);
                int auteur = Convert.ToInt32(row[1]);
                int theGame = Convert.ToInt32(row[2]);
                string titel = (string)row[3];
                string postDatum = (string)row[4];
                string content = (string)row[5];

                DataTable OutcomeTemp = Database.RunQuery("SELECT platform, rating FROM review WHERE reviewID = (SELECT review FROM ReviewPost WHERE post = " + postId + ")");
                DataRow rowTemp = OutcomeTemp.Rows[0];
                string platform = (string)rowTemp[0];
                double rating = Convert.ToDouble(rowTemp[1]);

                Review reviewTemp = new Review(postId, auteur, theGame, titel, postDatum, content, platform, rating);
                reviews.Add(reviewTemp);
            }
        }

        /// <summary>
        /// Een functie om de lijst van videoclips en shows up te daten
        /// </summary>
        public static void UpdateVideosList()
        {
            videoclips = new List<Videoclip>();
            shows = new List<Show>();

            DataTable outcome = Database.RunQuery("SELECT * FROM post WHERE type = 'Video' ORDER BY post_datum");
            foreach (DataRow row in outcome.Rows)
            {
                int postId = Convert.ToInt32(row[0]);
                int auteur = Convert.ToInt32(row[1]);
                int theGame = Convert.ToInt32(row[2]);
                string titel = (string)row[3];
                string postDatum = (string)row[4];
                string content = (string)row[5];

                DataTable OutcomeTemp = Database.RunQuery("SELECT type FROM video WHERE videoID = (SELECT videoID FROM VideoPost WHERE post = " + postId + ")");
                DataRow rowTemp = OutcomeTemp.Rows[0];
                string type = (string)rowTemp[0];

                if(type == "Videoclip")
                {
                    OutcomeTemp = Database.RunQuery("SELECT naam FROM Categorie WHERE categorieID = (SELECT categorie FROM Videoclipt WHERE videoID = (SELECT videoID FROM VideoPost WHERE post = " + postId + "))");
                    rowTemp = OutcomeTemp.Rows[0];
                    string categorie = (string)rowTemp[0];

                    Videoclip videoclipTemp = new Videoclip(postId, auteur, theGame, titel, postDatum, content, categorie);
                    videoclips.Add(videoclipTemp);
                }
                else if(type == "Show")
                {
                    bool isLive = false;
                    OutcomeTemp = Database.RunQuery("SELECT start_datum, is_live FROM Show WHERE videoID = (SELECT videoID FROM VideoPost WHERE post = " + postId + ")");
                    rowTemp = OutcomeTemp.Rows[0];
                    string startDatum = (string)rowTemp[0];
                    string live = (string)rowTemp[1];

                    if(live == "true")
                    {
                        isLive = true;
                    }
                    else
                    {
                        isLive = false;
                    }

                    Show showTemp = new Show(postId, auteur, theGame, titel, postDatum, content, startDatum, isLive);
                    shows.Add(showTemp);
                }               
            }            
        }

        /// <summary>
        /// Een functie om één bepaald nieuws item op te halen, aan de hand van het postId
        /// </summary>
        /// <param name="post"></param> Een integer die voor een postId staat
        /// <returns> Returned een Nieuws instantie</returns>
        public static Nieuws GetNieuwsData(int post)
        {
            foreach (Nieuws nieuw in nieuws)
            {
                if (nieuw.postId == post)
                {
                    return nieuw;
                }
            }
            return null;
        }

        /// <summary>
        /// Een functie om één bepaalde review op te halen, aan de hand van het postId
        /// </summary>
        /// <param name="post"></param> Een integer die voor een postId staat
        /// <returns> Returned een Review instantie </returns>
        public static Review GetReviewData(int post)
        {
            foreach (Review review in reviews)
            {
                if (review.postId == post)
                {
                    return review;
                }
            }
            return null;
        }

        /// <summary>
        /// Een functie om één bepaalde show op te haalen, aan de hand van het postId
        /// </summary>
        /// <param name="post"></param> Een integer die voor een postId staat
        /// <returns> Returned een Show instantie</returns>
        public static Show GetShowData(int post)
        {
            foreach (Show show in shows)
            {
                if (show.postId == post)
                {
                    return show;
                }
            }
            return null;
        }

        /// <summary>
        /// Een functie om één bepaalde videoclip op te halen, aan de hand van het postId
        /// </summary>
        /// <param name="post"></param> Een integer die voor een postId staat
        /// <returns> Returned een Videoclip instantie</returns> 
        public static Videoclip GetVideoclipData(int post)
        {
            foreach (Videoclip videoclip in videoclips)
            {
                if (videoclip.postId == post)
                {
                    return videoclip;
                }
            }
            return null;
        }

    }
}

