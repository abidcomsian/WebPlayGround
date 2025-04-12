using OweWay.Application.Contracts;
using OweWay.Domain.Contracts;
using OweWay.Domain.Entities;

namespace OweWay.Infrastructure.Persistence.Records
{
    /// <summary>
    /// Represents a currency record in the database.
    /// </summary>
    public class CurrencyRecord : BaseRecord, IMapFrom<CurrencyEntity>, IMapTo<CurrencyEntity>
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
        public string Symbol { get; private set; }

        public void MapFrom(CurrencyEntity source)
        {
            Id = source.Id;
            Name = source.Name;
            Code = source.Code;
            Symbol = source.Symbol;
        }
        public CurrencyEntity MapTo()
        {
            var currency = new CurrencyEntity(Name, Code, Symbol);
            currency.SetIdentity(Id);
            return currency;
        }
    }
}
