using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameSpot.App_Code
{
    public class Game
    {
        //Properties
        public int gameId { get; set; }

        public string titel { get; set; }

        public string developer { get; set; }

        public string genre { get; set; }

        public string platform { get; set; }

        public string releaseDatum { get; set; }

        public double rating { get; set; }

        public double gebruikerRating { get; set; }

        public double metacriticRating { get; set; }

        //Constructor
        public Game(int gameId, string titel, string developer, string genre, string platform, string releaseDatum, double rating, double gebruikerRating, double metacriticRating)
        {
            this.gameId = gameId;
            this.titel = titel;
            this.developer = developer;
            this.genre = genre;
            this.platform = platform;
            this.releaseDatum = releaseDatum;
            this.rating = rating;
            this.gebruikerRating = gebruikerRating;
            this.metacriticRating = metacriticRating;
        }
    }
}