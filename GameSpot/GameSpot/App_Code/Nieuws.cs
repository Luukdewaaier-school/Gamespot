using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameSpot.App_Code
{
    public class Nieuws : Post
    {
        public Nieuws(int postId, int auteur, int theGame, string titel, DateTime postDatum, string content)
            : base(postId, auteur, theGame, titel, postDatum, content)
        {

        }
    }
}