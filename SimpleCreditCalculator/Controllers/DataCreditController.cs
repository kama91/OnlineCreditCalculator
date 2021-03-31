using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using SimpleCreditCalculator.Models;
using SimpleCreditCalculator.Models.Interfaces;
using SimpleCreditCalculator.Services.Interfaces;

using System.Threading.Tasks;

namespace SimpleCreditCalculator.Controllers
{
    /// <summary>
    /// Контроллер для доступа по web api
    /// </summary>
    [Route("/api/[controller]")]
    [ApiController]
    public class DataCreditController : ControllerBase
    {
        private readonly ILogger<DataCreditController> _logger;
        private readonly ICreditCalculatorService _creditCalculatorService;

        public DataCreditController(
            ICreditCalculatorService creditCalculatorService,
            ILogger<DataCreditController> logger)
        {
            _creditCalculatorService = creditCalculatorService ?? throw new System.ArgumentNullException(nameof(creditCalculatorService));
            _logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Получить детали рассчитанного кредита
        /// </summary>
        /// <param name="inputDataCredit"></param>
        /// <returns></returns>
        [HttpGet("creditdetails")]
        public async Task<IOutputDataCredit> GetOutputCreditDetails([FromBody] InputDataCredit inputDataCredit)
        {
            var creditDetails = await _creditCalculatorService.GetOutputCreditDetails(inputDataCredit);

            return creditDetails;
        }
    }
}
