using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PS_Handy_Bibliothek
{
    public class HandyListe : List<Handy>
    {
        // List<Handy> handyListe = new List<Handy>();
        public int getAmountOfHersteller(string hersteller)
        {
            int counter = 0;
            foreach (var item in this)
            {
                if (item.Hersteller == hersteller)
                {
                    counter++;
                }
            }
            return counter;
        }

        public double getSumOfPrices()
        {
            double prices = 0;
            foreach (var item in this)
            {
                prices += item.Preis;
            }
            return prices;
        }

        public Handy getHandyById(int id)
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

        public HandyListe search(string hersteller)
        {
            HandyListe hliste = new HandyListe();
            foreach(var item in this)
            {
                if(item.Hersteller == hersteller)
                {
                    hliste.Add(item);
                }
            }
            return hliste;
        }

        public Handy getCheapestHandy()
        {
            Handy handy = new Handy();
            handy = this[0];
            foreach(var item in this)
            {
                if (item.Preis < handy.Preis)
                {
                    handy = item;
                }
            }
            return handy;
        }
    }
}
