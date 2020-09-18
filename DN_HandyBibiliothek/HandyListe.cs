using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN_Handy_Bibiliothek
{
    public class HandyListe : List<Handy>
    {
        public int getAmountHersteller(string hersteller)
        {
            int handyAnzahl = 0;
            foreach (var item in this)
            {
                if (item.Hersteller == hersteller)
                {
                    handyAnzahl++;
                }
            }
            return handyAnzahl;
        }

        public double sumPrices()
        {
            double sum = 0;
            foreach (var item in this)
            {
                sum += item.Preis;
            }
            return sum;
        }

        public Handy getHandy(int Id)
        {

            foreach (var item in this)
            {
                if (item.Id == Id) { return item; };
            }
            return null;
        }

        public HandyListe search(string hersteller)
        {
            HandyListe newList = new HandyListe();
            foreach (var item in this)
            {
                if (item.Hersteller == hersteller)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        public Handy getCheapestHandy()
        {
            Handy lowestHandy = new Handy();
            lowestHandy = this[0];
            foreach (var item in this)
            {
                if (item.Preis < lowestHandy.Preis)
                {
                    lowestHandy = item;
                }
            }
            return lowestHandy;
        }
    }
}
