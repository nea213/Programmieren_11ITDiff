using System;

namespace CC_HandyClass
{
    public class Handy : GuidId
    {
        public string Producer { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public double Price { get; set; }
    }


    public abstract class GuidId
    {
        public Guid Id { get; set; }
    }
}