using OweWay.Application.Dtos;
using System.Collections.Generic;

namespace OweWay.Application.Services.Currency
{
    public interface ICurrencyService
    {
        IEnumerable<CurrencyDto> GetAll();
    }
}
