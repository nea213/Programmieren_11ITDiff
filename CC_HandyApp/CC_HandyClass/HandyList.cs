using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using CC_HandyClass;

namespace CC_HandyApp
{
    [Serializable()]
    public class HandyList : List<Handy>
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

        public Handy GetHandy(Guid id)
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

        public HandyList SearchProducer(string producer)
        {
            var fundHandys = new HandyList();

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

        public void Serialize(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, this);
            stream.Close();
        }

        public HandyList Deserialize(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            var result = (HandyList) formatter.Deserialize(stream);
            this.Clear();
            this.AddRange(result);
            stream.Close();
            return result;
        } 
    }
}