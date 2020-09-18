using System;
using DN_Handy_Bibiliothek;

namespace DN_Handy
{
    class Program
    {
        public static void Main(string[] args)
        {
            HandyListe hListe = new HandyListe();

            Handy h = new Handy();

            h.Id = 1;
            h.Hersteller = "Oneplus";
            h.Modell = "Oneplus 8 Pro";
            h.Preis = 1000;

            hListe.Add(h);


            Handy h2 = new Handy();

            h2.Id = 2;
            h2.Hersteller = "Samsung";
            h2.Modell = "S20 Pro";
            h2.Preis = 1100;

            hListe.Add(h2);


            Handy h3 = new Handy();

            h3.Id = 3;
            h3.Hersteller = "Apple";
            h3.Modell = "Iphone 11 Pro";
            h3.Preis = 1120;

            hListe.Add(h3);

            Handy h4 = new Handy();

            h4.Id = 1;
            h4.Hersteller = "Oneplus";
            h4.Modell = "Oneplus 8";
            h4.Preis = 800;

            hListe.Add(h4);

            foreach (var item in hListe)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Hersteller);
                Console.WriteLine(item.Modell);
                Console.WriteLine(item.Preis);
                Console.WriteLine("Es gibt noch " + hListe.getAmountHersteller(item.Hersteller) + " weitere Handys vom Hersteller " + item.Hersteller);
                Console.WriteLine(hListe.getHandy(item.Id));
                Console.WriteLine("Preis aller Handys in der Liste vom Hersteller" + item.Hersteller + " : " + hListe.search(item.Hersteller).sumPrices());
            }
            Console.WriteLine("Insgesamt wurden " + hListe.sumPrices() + " Euro für Handys in der Liste ausgegeben.");
            Console.WriteLine(hListe.getCheapestHandy().Modell);
        }
    }
}

