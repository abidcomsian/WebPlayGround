namespace OweWay.Domain.Entities
{
    public class CurrencyEntity : BaseEntity
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
        public string Symbol { get; private set; }

        public CurrencyEntity(string name, string code, string symbol)
        {
            Name = name;
            Code = code;
            Symbol = symbol;
        }
    }
}
