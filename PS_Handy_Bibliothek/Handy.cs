using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Handy_Bibliothek
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

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private double preis;
        public double Preis
        {
            get { return preis; }
            set { preis = value; }
        }


        /*
        private int id;
        private string hersteller;
        private string model;
        private double preis;

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }

        public void setHersteller(string hersteller)
        {
            this.hersteller = hersteller;
        }

        public string getHersteller()
        {
            return this.hersteller;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public string getModel()
        {
            return this.model;
        }

        public void setPreis(double preis)
        {
            this.preis = preis;
        }

        public double getPreis()
        {
            return this.preis;
        }
        */
    }
}
