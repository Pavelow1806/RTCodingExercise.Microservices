using Catalog.API.Configuration;
using Catalog.Domain.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    public class Configuration : Controller
    {
        [HttpGet]
        [Route("get")]
        public ConfigurationResponse GetConfiguration()
        {
            return new ConfigurationResponse
            {
                MarkupMultiplier = DataConfiguration.MarkupMultiplier,
                ItemsPerPage = DataConfiguration.ItemsPerPage,
            };
        }
        public IActionResult Index()
        {
            return new RedirectResult("~/swagger");
        }
    }
}
