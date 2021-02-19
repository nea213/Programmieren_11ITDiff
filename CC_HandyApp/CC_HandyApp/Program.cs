using System;
using System.Linq;
using System.Xml.Serialization;
using CC_HandyClass;

namespace CC_HandyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var handyList = new HandyList();
            var Binary = new Binary<HandyList>();
            var XML = new XML<HandyList>();
            
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var rnd = new Random();
            string[] producers = {"Apple", "Samsung", "Huawei"};
            
            for (var i = 0; i < 10; i++)
            {
                var h = new Handy
                {
                    Price = Math.Round((rnd.NextDouble() * (400 - 100) + 400), 2),
                    Model = new string(chars.Select(c => chars[rnd.Next(chars.Length)]).Take(8).ToArray()),
                    Producer = producers[rnd.Next(0, producers.Length)],
                    SerialNumber = new string(chars.Select(c => chars[rnd.Next(chars.Length)]).Take(8).ToArray()),
                };
                
                handyList.Add(h);
            }
            
            handyList.ConnectSerializer(Binary);
            handyList.Serialize(@"D:\SchulSachen\Programmieren_11ITDiff\object_bin.txt");
            handyList.Deserialize(@"D:\SchulSachen\Programmieren_11ITDiff\object_bin.txt");
            
            handyList.ConnectSerializer(XML);
            handyList.Serialize(@"D:\SchulSachen\Programmieren_11ITDiff\object_xml.txt");
            handyList.Deserialize(@"D:\SchulSachen\Programmieren_11ITDiff\object_xml.txt");
            
            
            // foreach (var h in handyList)
            // {
            //     Console.WriteLine(h.Id);
            //     Console.WriteLine(h.Producer);
            //     Console.WriteLine(h.Model);
            //     Console.WriteLine(h.SerialNumber);
            //     Console.WriteLine(h.Price);
            //     Console.WriteLine("_______________________________");
            // }
        }
    }
}