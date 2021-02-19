using System;

namespace CC_HandyClass
{
    [Serializable()]
    public class Handy : DomainObject
    {
        public string Producer { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public double Price { get; set; }
    }

    [Serializable()]
    public abstract class DomainObject
    {
        public Guid Id { get; set; }

        protected DomainObject()
        {
            this.Id = Guid.NewGuid();
        }
    }
}