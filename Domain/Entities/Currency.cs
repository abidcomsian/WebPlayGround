using System;

namespace OweWay.Domain.Entities
{
    public class Currency
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Code { get; private set; }
        public string Symbol { get; private set; }

        public Currency(string name, string code, string symbol)
        {
            Name = name;
            Code = code;
            Symbol = symbol;
        }

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
