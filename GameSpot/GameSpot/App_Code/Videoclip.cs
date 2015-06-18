using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameSpot.App_Code
{
    public class Videoclip : Post
    {
        //Properties
        public string categorie { get; set; }

        //Constructor
        public Videoclip(int postId, int auteur, int theGame, string titel, string postDatum, string content, string categorie)
            : base(postId, auteur, theGame, titel, postDatum, content)
        {
            this.categorie = categorie;
        }
    }
}