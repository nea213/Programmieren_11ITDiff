using System;
using System.Runtime.CompilerServices;
using System.Xml;
using PS_Handy_Bibliothek;

namespace PS_Handy
{
    class Program
    {
        static void Main(string[] args)
        {
            HandyListe handyListe = new HandyListe();

            Handy handy1 = new Handy();

            handy1.Id = 1;
            handy1.Hersteller = "Apple";
            handy1.Model = "XS";
            handy1.Preis = 700;

            Handy handy2 = new Handy();

            handy2.Id = 2;
            handy2.Hersteller = "Samsung";
            handy2.Model = "Galaxy S10";
            handy2.Preis = 800;

            Handy handy3 = new Handy();

            handy3.Id = 3;
            handy3.Hersteller = "Apple";
            handy3.Model = "7S";
            handy3.Preis = 600;

            Handy handy4 = new Handy();

            handy4.Id = 4;
            handy4.Hersteller = "Samsung";
            handy4.Model = "5S";
            handy4.Preis = 500;

            handyListe.Add(handy1);
            handyListe.Add(handy2);
            handyListe.Add(handy3);
            handyListe.Add(handy4);

            foreach (var item in handyListe)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Hersteller);
                Console.WriteLine(item.Model);
                Console.WriteLine(item.Preis);
                Console.WriteLine(" ");
                Console.WriteLine("Es existieren " + handyListe.getAmountOfHersteller(item.Hersteller) + " Handy vom Hersteller " +item.Hersteller);
                Console.WriteLine(handyListe.getHandyById(item.Id));
                Console.WriteLine("Summe der Preise der Hersteller " + item.Hersteller + ": " + handyListe.search(item.Hersteller).getSumOfPrices());

            }

            Console.WriteLine("Anzahl Hersteller von Apple: " + handyListe.getAmountOfHersteller("Apple"));
            Console.WriteLine("Anzahl Hersteller von Samsung: " + handyListe.getAmountOfHersteller("Samsung"));
            Console.WriteLine("");
            Console.WriteLine("Summe aller Handypreise: " + handyListe.getSumOfPrices());
            Console.WriteLine("");
            Console.WriteLine("Günstigstes Handy: " + handyListe.getCheapestHandy().Hersteller + " " + handyListe.getCheapestHandy().Model);

            /*
            Console.WriteLine(handy.Id);
            Console.WriteLine(handy.Hersteller);
            Console.WriteLine(handy.Model);
            Console.WriteLine(handy.Preis);
            /* 
            handy.setId(1);
            handy.setHersteller("Apple");
            handy.setModel("XS");
            handy.setPreis(800);

            Console.WriteLine("ID: " + handy.getId());
            Console.WriteLine("Hersteller: " + handy.getHersteller());
            Console.WriteLine("Model: " + handy.getModel());
            Console.WriteLine("Preis: " + handy.getPreis());
            */
        }
    }
}
