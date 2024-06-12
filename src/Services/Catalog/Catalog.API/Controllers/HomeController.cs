using Catalog.Domain.Responses;

namespace Catalog.API.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("plates")]
        public async Task<PlatesResponse> GetPlates(CancellationToken cancellationToken)
        {

        }
        public IActionResult Index()
        {
            return new RedirectResult("~/swagger");
        }
    }
}
