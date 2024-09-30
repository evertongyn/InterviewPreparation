using InterviewPreparation.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace InterviewPreparation.Web.Controllers
{
    [ApiController]
    [Route("sort")]
    public class OrdinationController : ControllerBase
    {
        private readonly IOrdinationService _orderService;

        public OrdinationController(IOrdinationService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public ActionResult<List<int>> SortNumbers([FromBody] List<int> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return BadRequest("A lista de números está vazia ou é nula.");
            }

            var sortedNumbers = _orderService.OrderSimply(numbers);

            return Ok(sortedNumbers);
        }
    }
}
