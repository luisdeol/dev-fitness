using System;

namespace DevFitness.API.Core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            CreatedAt = DateTime.Now;
            Active = true;
        }

        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; private set; }

        public void Deactivate()
        {
            Active = false;
        }
    }
}
