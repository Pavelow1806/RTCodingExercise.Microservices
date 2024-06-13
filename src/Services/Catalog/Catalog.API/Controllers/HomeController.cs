using Catalog.API.Services.DataService;
using Catalog.Domain.Requests;
using Catalog.Domain.Responses;
using System.Net;

namespace Catalog.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataService _dataService;
        public HomeController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpPost]
        [Route("plates")]
        public async Task<PlatesResponse> GetPlates(PlatesRequest request, CancellationToken cancellationToken)
        {
            var plates = await _dataService.GetPlates(request, cancellationToken);
            return new PlatesResponse
            {
                Plates = plates
            };
        }
        public IActionResult Index()
        {
            return new RedirectResult("~/swagger");
        }
    }
}
