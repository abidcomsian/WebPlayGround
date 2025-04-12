using OweWay.Application.Dtos;
using OweWay.Application.Services.Currency;
using System.Collections.Generic;
using System.Web.Http;

namespace OweWay.Api.Controllers
{
    public class CurrencyController : ApiController
    {
        private readonly ICurrencyService _currencyService;

        public CurrencyController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        // GET api/values
        public IEnumerable<CurrencyDto> Get()
        {
            return _currencyService.GetAll();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
