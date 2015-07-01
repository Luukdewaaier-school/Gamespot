using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameSpot.App_Code
{
    public class Game
    {
        /// <summary>
        /// De properties van de klasse Game
        /// </summary>
        public int gameId { get; set; }

        public string titel { get; set; }

        public string developer { get; set; }

        public string genre { get; set; }

        public string platform { get; set; }

        public string releaseDatum { get; set; }

        public double rating { get; set; }

        public double gebruikerRating { get; set; }

        public double metacriticRating { get; set; }

        /// <summary>
        /// Dit is de constructor van de klasse Game
        /// </summary>
        /// <param name="gameId"></param> Het idee van de game
        /// <param name="titel"></param> De titel van de game
        /// <param name="developer"></param> De naam van de developer van de game
        /// <param name="genre"></param> Het genre waar de game in gemaakt is
        /// <param name="platform"></param> Het platform waar de game op gereleased is
        /// <param name="releaseDatum"></param> De releasedatum van de game
        /// <param name="rating"></param> De rating die de game heeft ontvange
        /// <param name="gebruikerRating"></param> De gebruiker rating die de game heef ontvangen
        /// <param name="metacriticRating"></param> De metacritic rating die de game heeft ontvangen
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