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
        private ISerializeable<HandyList> _Serializeable { get; set; }
        public void ConnectSerializer(ISerializeable<HandyList> s)
        {
            _Serializeable = s;
        }
        
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
            this._Serializeable.Serialize(path, this);
        }
        
        public void Deserialize(string path)
        {
            this.Clear();
            var result = this._Serializeable.Deserialize(path);
            this.AddRange(result);
        } 
    }
}