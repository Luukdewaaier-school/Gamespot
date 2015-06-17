using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameSpot.App_Code
{
    public class Show : Post
    {
        //Properties
        public string beschrijving { get; set; }

        public DateTime startDatum { get; set; }

        public bool isLive { get; set; }

        //Constructor
        public Show(int postId, int auteur, int theGame, string titel, DateTime postDatum, string content, string beschrijving, DateTime startDatum, bool isLive)
            : base(postId, auteur, theGame, titel, postDatum, content)
        {
            this.beschrijving = beschrijving;
            this.startDatum = startDatum;
            this.isLive = isLive;
        }
    }
}