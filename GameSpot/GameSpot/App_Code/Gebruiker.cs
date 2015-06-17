using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameSpot.App_Code
{
    public class Gebruiker
    {
        //Properties
        public int gebruikerId { get; set; }

        public string username { get; set; }

        public string voornaam { get; set; }

        public string achternaam { get; set; }

        public string emailadres { get; set; }

        public string geslacht { get; set; }

        public DateTime geboortedatum { get; set; }

        public DateTime lidSinds { get; set; }

        public string locatie { get; set; }

        public string beschrijving { get; set; }

        public string signature { get; set; }

        public string avatar { get; set; }

        public bool isBeheerder { get; set; }

        //Constructor
        public Gebruiker(int gebruikerId, string username, string voornaam, string achternaam, string emailadres, string geslacht, DateTime geboortedatum, DateTime lidSinds,
            string locatie, string beschrijving, string signature, string avatar, bool isBeheerder)
        {
            this.gebruikerId = gebruikerId;
            this.username = username;
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.emailadres = emailadres;
            this.geslacht = geslacht;
            this.geboortedatum = geboortedatum;
            this.lidSinds = lidSinds;
            this.locatie = locatie;
            this.beschrijving = beschrijving;
            this.signature = signature;
            this.avatar = avatar;
            this.isBeheerder = isBeheerder;
        }
    }
}