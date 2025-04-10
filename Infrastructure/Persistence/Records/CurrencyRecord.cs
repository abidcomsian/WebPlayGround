namespace OweWay.Infrastructure.Persistence.Records
{
    /// <summary>
    /// Represents a currency record in the database.
    /// </summary>
    public class CurrencyRecord
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public long CountryId { get; set; }
    }    
}
