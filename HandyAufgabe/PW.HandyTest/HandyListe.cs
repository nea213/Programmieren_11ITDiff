using PW.HandyBibliothek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW.HandyTest
{
    public class HandyListe : List<Handy> 
    {
        public int AnzHersteller(string hersteller )
        {
            int counter = 0;
            foreach(var item in this) {
                if (item.Hersteller.Equals(hersteller))
                {
                    counter++;
                }
            }
            return counter;
        }

        public double SumPrice(string hersteller = "")
        {
            double preis = 0;
            foreach (var item in this)
            {
                if (String.IsNullOrEmpty(hersteller)) {
                    preis += item.Preis;
                }
                else {
                    if (item.Hersteller.Equals(hersteller)) {
                        preis += item.Preis;
                    }
                }
            }
            return preis;
        }

        public Handy GetHandy(int id)
        {
            foreach (var item in this)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }            
            return null;
        }

        public HandyListe Search(string hersteller)
        {
            HandyListe neueListe = new HandyListe();
            foreach (var item in this)
            {
                if (item.Hersteller.Equals(hersteller))
                {
                    neueListe.Add(item);
                }
            }
            return neueListe;
        }

        public Handy cheapestHandy()
        {
            double niedPreis = 900000;
            foreach(var item in this)
            {
                if (item.Preis < niedPreis) niedPreis = item.Preis;
            }

            foreach (var item in this)
            {
                if (item.Preis == niedPreis)
                {
                    return item;
                }
            }
            return null;
        }

        public HandyListe CheapestHandies()
        {
            double niedPreis = 900000;
            HandyListe neueListe = new HandyListe();
            foreach (var item in this)
            {
                if (item.Preis < niedPreis) niedPreis = item.Preis;
            }

            foreach (var item in this)
            {
                if (item.Preis == niedPreis)
                {
                    neueListe.Add(item);
                }
            }
            return neueListe;
        }
    }
}
