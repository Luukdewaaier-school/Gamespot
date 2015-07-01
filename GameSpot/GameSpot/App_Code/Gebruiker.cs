using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameSpot.App_Code
{
    public class Gebruiker
    {
        /// <summary>
        /// De properties van de klasse Gebruiker
        /// </summary>
        public int gebruikerId { get; set; }

        public string username { get; set; }

        public string voornaam { get; set; }

        public string achternaam { get; set; }

        public string emailadres { get; set; }

        public string geslacht { get; set; }

        public string geboortedatum { get; set; }

        public string lidSinds { get; set; }

        public string locatie { get; set; }

        public string beschrijving { get; set; }

        public string signature { get; set; }

        public string avatar { get; set; }

        public bool isBeheerder { get; set; }

        /// <summary>
        /// De constructor van de klasse Gebruiker
        /// </summary>
        /// <param name="gebruikerId"></param> Het id van de gebruiker
        /// <param name="username"></param> De username van de gebruiker
        /// <param name="voornaam"></param> De voornaam van de gebruiker
        /// <param name="achternaam"></param> De achternaam van de gebruiker
        /// <param name="emailadres"></param> Het emailadres van de gebruiker
        /// <param name="geslacht"></param> Het geslacht van de gebruiker
        /// <param name="geboortedatum"></param> De geboortedatum van de gebruiker
        /// <param name="lidSinds"></param> De datum sinds wanneer de gebruiker lid is
        /// <param name="locatie"></param> De locatie van de gebruiker
        /// <param name="beschrijving"></param> De beschrijving van de gebruiker
        /// <param name="signature"></param> De signature van de gebruiker kan een filepath zijn
        /// <param name="avatar"></param> De avatar van de gebruiker is een filepath
        /// <param name="isBeheerder"></param> Een boolean om bij te houden of de gebruiker een beheerder is
        public Gebruiker(int gebruikerId, string username, string voornaam, string achternaam, string emailadres, string geslacht, string geboortedatum, string lidSinds,
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