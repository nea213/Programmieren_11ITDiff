using System;
using System.Collections.Generic;
using CC_HandyClass;

namespace CC_HandyApp
{
    public class HandyListClass : List<Handy>
    {
        public int CountProducer(string producer)
        {
            var count = 0;

            foreach (var handy in this)
            {
                if (handy.Producer == producer)
                {
                    count++;
                }
            }

            return count;
        }

        public double SumPrice()
        {
            var count = 0.0;

            foreach (var handy in this)
            {
                count += handy.Price;
            }

            return count;
        }

        public Handy GetHandy(int id)
        {
            var result = new Handy();
            foreach (var handy in this)
            {
                if (handy.Id == id)
                {
                    result = handy;
                }
            }

            return result;
        }

        public HandyListClass SearchProducer(string producer)
        {
            var fundHandys = new HandyListClass();

            foreach (var handy in this)
            {
                if (handy.Producer == producer)
                {
                    fundHandys.Add(handy);
                }
            }

            return fundHandys;
        }

        public Handy SearchCheapestHandy()
        {
            Handy result = this[0];

            foreach (var handy in this)
            {
                if (result.Price > handy.Price)
                {
                    result = handy;
                }
            }

            return result;
        }
    }
}