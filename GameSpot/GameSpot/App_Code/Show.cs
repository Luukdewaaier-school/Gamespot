using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameSpot.App_Code
{
    public class Show : Post
    {
        //Properties
        public string startDatum { get; set; }

        public bool isLive { get; set; }

        //Constructor
        public Show(int postId, int auteur, int theGame, string titel, string postDatum, string content, string startDatum, bool isLive)
            : base(postId, auteur, theGame, titel, postDatum, content)
        {
            this.startDatum = startDatum;
            this.isLive = isLive;
        }
    }
}