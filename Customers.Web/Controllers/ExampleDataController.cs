using System.Net;
using System.Threading.Tasks;
using Customers.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Customers.Web.Controllers
{
    [Route("api/[controller]")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public class ExampleDataController : Controller
    {
        private readonly IExampleDataService _exampleDataService;

        public ExampleDataController(IExampleDataService exampleDataService)
        {
            _exampleDataService = exampleDataService;
        }

        [HttpGet("reset-data")]
        public async Task<IActionResult> ResetData()
        {
            await _exampleDataService.ResetData();

            return Ok();
        }
    }
}
