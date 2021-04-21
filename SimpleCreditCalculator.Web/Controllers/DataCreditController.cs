using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleCreditCalculator.BL.Services.Interfaces;
using SimpleCreditCalculator.Models;
using System;

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
            _creditCalculatorService = creditCalculatorService ?? throw new ArgumentNullException(nameof(creditCalculatorService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Получить детали рассчитанного кредита
        /// </summary>
        /// <param name="inputDataCredit"></param>
        /// <returns></returns>
        [HttpGet("creditdetails")]
        public OutputDataCredit GetOutputCreditDetails([FromBody] InputDataCredit inputDataCredit)
        {
            var creditDetails = _creditCalculatorService.GetOutputCreditDetails(inputDataCredit);

            return (OutputDataCredit)creditDetails;// TODO вместо каста сделать маппером
        }
    }
}
