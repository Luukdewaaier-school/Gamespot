using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameSpot.App_Code
{
    public class NieuwsClass : Post
    {
        /// <summary>
        /// De constructor van de klasse post
        /// </summary>
        /// <param name="postId"></param> Het id van de nieuws-post
        /// <param name="auteur"></param> De auteur van de nieuws-post
        /// <param name="theGame"></param> Het spel waar de nieuws-post over gaat
        /// <param name="titel"></param> De titel van de nieuws-post
        /// <param name="postDatum"></param> De postdatum van de nieuws-post
        /// <param name="content"></param> De content van de nieuws-post
        public NieuwsClass(int postId, int auteur, int theGame, string titel, string postDatum, string content)
            : base(postId, auteur, theGame, titel, postDatum, content)
        {            
        }
    }
}