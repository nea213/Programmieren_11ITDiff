using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN_Handy_Bibiliothek
{
    public class Handy
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string hersteller;

        public string Hersteller
        {
            get { return hersteller; }
            set { hersteller = value; }
        }

        private string modell;

        public string Modell
        {
            get { return modell; }
            set { modell = value; }
        }

        private double preis;

        public double Preis
        {
            get { return preis; }
            set { preis = value; }
        }
    }
}
