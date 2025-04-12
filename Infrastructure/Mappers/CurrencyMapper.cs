using OweWay.Application.Mapper;
using System;

namespace OweWay.Infrastructure.Mappers
{
    public class CurrencyMapper<Currency, CurrencyRecord> : EnumerableMapper<Currency, CurrencyRecord>
        where Currency : class
        where CurrencyRecord : class
    {
        public override CurrencyRecord MapFrom(Currency source)
        {
            // Implement mapping logic from Currency to CurrencyRecord
            throw new NotImplementedException();
        }
        public override Currency MapTo(CurrencyRecord destination)
        {
            // Implement mapping logic from CurrencyRecord to Currency
            throw new NotImplementedException();
        }

    }
}
