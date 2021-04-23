using System;

namespace CC_HandyClass
{
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