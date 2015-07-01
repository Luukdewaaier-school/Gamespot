using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameSpot.App_Code
{
    public abstract class Post
    {
        /// <summary>
        /// Properties van de klasse Post
        /// </summary>
        public int postId { get; set; }

        public int auteur { get; set; }

        public int theGame { get; set; }

        public string titel { get; set; }

        public string postDatum { get; set; }

        public string content { get; set; }

        /// <summary>
        /// De constructor van de klasse Post
        /// </summary>
        /// <param name="postId"></param> Het id van de post
        /// <param name="auteur"></param> De auteur van de post
        /// <param name="theGame"></param> Het spel waar de post over gaat
        /// <param name="titel"></param> De titel van de post
        /// <param name="postDatum"></param> De postdatum van de post
        /// <param name="content"></param> De content van de post
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