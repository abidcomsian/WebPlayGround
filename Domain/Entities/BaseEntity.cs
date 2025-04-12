using System;

namespace OweWay.Domain.Entities
{
    public abstract class BaseEntity
    {
        public long Id { get; private set; }
        public void SetIdentity(long id)
        {
            if (Id > 0)
            {
                throw new InvalidOperationException("Identity has already been set.");
            }
            Id = id;
        }
    }
}
