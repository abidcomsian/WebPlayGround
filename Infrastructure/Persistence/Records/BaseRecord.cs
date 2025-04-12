using OweWay.Application.Contracts;
using System;

namespace OweWay.Infrastructure.Persistence.Records
{
    public abstract class BaseRecord
    {
        public long Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public long UpdatedBy { get; set; }
    }
}
