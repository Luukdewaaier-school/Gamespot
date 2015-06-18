using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameSpot.App_Code
{
    public class Post
    {
        //Properties
        public int postId { get; set; }

        public int auteur { get; set; }

        public int theGame { get; set; }

        public string titel { get; set; }

        public string postDatum { get; set; }

        public string content { get; set; }

        //Constructor
        public Post(int postId, int auteur, int theGame, string titel, string postDatum, string content)
        {
            this.postId = postId;
            this.auteur = auteur;
            this.theGame = theGame;
            this.titel = titel;
            this.postDatum = postDatum;
            this.content = content;
        }

    }
}