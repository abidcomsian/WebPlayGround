using OweWay.Domain.Contracts;
using OweWay.Domain.Entities;

namespace OweWay.Application.Dtos
{
    public class CurrencyDto : IMapFrom<CurrencyEntity>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public void MapFrom(CurrencyEntity source)
        {
            Id = source.Id;
            Name = source.Name;
            Code = source.Code;
            Symbol = source.Symbol;
        }
    }    
}
