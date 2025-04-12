using OweWay.Application.Contracts;
using OweWay.Application.Dtos;
using OweWay.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OweWay.Application.Services.Currency
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ILoggerService _loggerService;
        private readonly IRepository<CurrencyEntity> _currencyRepository;

        public CurrencyService(ILoggerService loggerService,
            IRepository<CurrencyEntity> currencyRepository)
        {
            _loggerService = loggerService;
            _currencyRepository = currencyRepository;
        }

        public IEnumerable<CurrencyDto> GetAll()
        {
            _loggerService.Info("Currency service started.");
            var currencies = _currencyRepository.GetAll();
            return currencies.Select(x =>
            {
                var dto = new CurrencyDto();
                dto.MapFrom(x);
                return dto;
            });
        }
    }

}