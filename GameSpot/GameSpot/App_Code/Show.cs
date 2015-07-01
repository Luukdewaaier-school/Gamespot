using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameSpot.App_Code
{
    public class Show : Post
    {
        /// <summary>
        /// Properties van de klasse Show
        /// </summary>
        public string startDatum { get; set; }

        public bool isLive { get; set; }

        /// <summary>
        /// De constructor van de klasse Show
        /// </summary>
        /// <param name="postId"></param> Het id van de show-post
        /// <param name="auteur"></param> De auteur van de show-post
        /// <param name="theGame"></param> Het spel waar de show-post over gaat
        /// <param name="titel"></param> De titel van de show-post
        /// <param name="postDatum"></param> De postdatum van de show-post
        /// <param name="content"></param> De content van de show-post
        /// <param name="startDatum"></param> De startdatum van de show
        /// <param name="isLive"></param> Een boolean die bijhoud of de show live is
        public Show(int postId, int auteur, int theGame, string titel, string postDatum, string content, string startDatum, bool isLive)
            : base(postId, auteur, theGame, titel, postDatum, content)
        {
            this.startDatum = startDatum;
            this.isLive = isLive;
        }
    }
}