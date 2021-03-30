using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleCreditCalculator.Models;
using SimpleCreditCalculator.Models.Interfaces;
using SimpleCreditCalculator.Services;

using System.Threading.Tasks;

namespace SimpleCreditCalculator.Controllers
{
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
        
        [HttpGet("creditdetails")]
        public async Task<IOutputDataCredit> GetOutputDataCreditDetails([FromBody] InputDataCredit inputDataCredit)
        {
            var creditDetails =  await _creditCalculatorService.GetOutputDataCreditDetails(inputDataCredit);
            return creditDetails;
        }
    }
}
