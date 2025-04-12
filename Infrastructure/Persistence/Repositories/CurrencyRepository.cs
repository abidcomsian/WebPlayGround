using OweWay.Application.Contracts;
using OweWay.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OweWay.Infrastructure.Persistence.Repositories
{
    public class CurrencyRepository : IRepository<CurrencyEntity>
    {
        private readonly ILoggerService _loggerService;

        public CurrencyRepository(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        public void Add(CurrencyEntity record)
        {
            _loggerService.Info($"Adding currency with id: {record.Id}");
        }

        public void Delete(int id)
        {
            _loggerService.Info($"Deleting currency with id {id}");
        }

        public IEnumerable<CurrencyEntity> GetAll()
        {
            _loggerService.Info("Getting all currencies");
            return new List<CurrencyEntity>
            {
                new CurrencyEntity("USD", "United States Dollar", "$"),
                new CurrencyEntity("EUR", "Euro", "€"),
                new CurrencyEntity("JPY", "Japanese Yen", "¥")
            };
        }

        public CurrencyEntity GetById(int id)
        {
            _loggerService.Info($"Getting currency with id {id}");
            return new CurrencyEntity("USD", "United States Dollar", "$");
        }

        public void Update(CurrencyEntity record)
        {
            _loggerService.Info($"Updating currency with id: {record.Id}");
        }
    }
}
