using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PW.HandyBibliothek;

namespace PW.HandyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            HandyListe hList = new HandyListe();

            Handy h = new Handy();
            h.Id = 1;
            h.Hersteller = "Apple";
            h.Modell = "3GS";
            h.Preis = 200;

            Handy h2 = new Handy();
            h2.Id = 2;
            h2.Hersteller = "Samsung";
            h2.Modell = "Galaxy";
            h2.Preis = 900;

            Handy h3 = new Handy();
            h3.Id = 3;
            h3.Hersteller = "Samsung";
            h3.Modell = "Galaxy";
            h3.Preis = 200;

            Console.WriteLine("Objekt Ausgabe:");
            Console.WriteLine(h.Id);
            Console.WriteLine(h.Hersteller);
            Console.WriteLine(h.Modell);
            Console.WriteLine(h.Preis);
            //Console.Read();

            hList.Add(h);
            hList.Add(h2);
            hList.Add(h3);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Objekt Liste Ausgabe:");
            foreach (var item in hList)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Modell);
                Console.WriteLine(item.Hersteller);
                Console.WriteLine(item.Preis);
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(hList.AnzHersteller("Apple"));
            Console.WriteLine("Max. Preise " + hList.SumPrice());

            Console.WriteLine("Handy: " + hList.GetHandy(1).Hersteller);
            Console.WriteLine("HandyListe: " + hList.Search("Apple"));
            Console.WriteLine("cheapestHandy: " + hList.cheapestHandy().Preis);

            foreach(var item in hList.CheapestHandies())
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Modell);
                Console.WriteLine(item.Hersteller);
                Console.WriteLine(item.Preis);
            }

            Console.Read();

            /*h.setId(1);
            h.setHersteller("Apple");
            h.setModell("3GS");
            h.setPreis(200);

            Console.WriteLine(h.getId());
            Console.WriteLine(h.getHersteller());
            Console.WriteLine(h.getModell());
            Console.WriteLine(h.getPreis());**/
        }
    }
}
