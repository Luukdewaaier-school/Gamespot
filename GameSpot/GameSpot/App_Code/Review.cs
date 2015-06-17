using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameSpot.App_Code
{
    public class Review : Post
    {
        //Properties
        public string platform { get; set; }

        public double rating { get; set; }

        public Review(int postId, int auteur, int theGame, string titel, DateTime postDatum, string content, string platform, double rating) 
            : base (postId, auteur, theGame, titel, postDatum, content)
        {
            this.platform = platform;
            this.rating = rating;
        }
    }
}