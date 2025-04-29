using System.Web.Http;
using System.Web.Http.Description;

namespace OweWay.Api.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class RootController : ApiController
    {
        [HttpGet, Route("")]
        public IHttpActionResult RedirectToSwagger()
        {
            var absoluteUrl = Url.Content("~/swagger");
            return Redirect(absoluteUrl);
        }
    }
}