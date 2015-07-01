using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameSpot.App_Code
{
    public class Review : Post
    {
        /// <summary>
        /// Properties van de klasse Review
        /// </summary>
        public string platform { get; set; }

        public double rating { get; set; }

        /// <summary>
        /// De constructor van de klasse Review
        /// </summary>
        /// <param name="postId"></param> Het id van de review-post
        /// <param name="auteur"></param> De auteur van de review-post
        /// <param name="theGame"></param> Het spel waar de review-post over gaat
        /// <param name="titel"></param> De titel van de review-post
        /// <param name="postDatum"></param> De postdatum van de review-post
        /// <param name="content"></param> De content van de review-post
        /// <param name="platform"></param> Het platform waar de review-post op gemaakt is
        /// <param name="rating"></param> De rating die de review-post heeft gekregen
        public Review(int postId, int auteur, int theGame, string titel, string postDatum, string content, string platform, double rating) 
            : base (postId, auteur, theGame, titel, postDatum, content)
        {
            this.platform = platform;
            this.rating = rating;
        }
    }
}