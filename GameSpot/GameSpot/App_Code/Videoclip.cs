using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameSpot.App_Code
{
    public class Videoclip : Post
    {
        /// <summary>
        /// Properties van de klasse Videoclip
        /// </summary>
        public string categorie { get; set; }

        /// <summary>
        /// Constructor van de klasse Videoclip
        /// </summary>
        /// <param name="postId"></param> Het id van de videoclip-post
        /// <param name="auteur"></param> De auteur van de videoclip-post
        /// <param name="theGame"></param> Het spel waar de videoclip-post over gaat
        /// <param name="titel"></param> De titel van de videoclip-post
        /// <param name="postDatum"></param> De postdatum van de videoclip-post
        /// <param name="content"></param> De content van de videoclip-post
        /// <param name="categorie"></param> De categorie van een videoclip-post
        public Videoclip(int postId, int auteur, int theGame, string titel, string postDatum, string content, string categorie)
            : base(postId, auteur, theGame, titel, postDatum, content)
        {
            this.categorie = categorie;
        }
    }
}