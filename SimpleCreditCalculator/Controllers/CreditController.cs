using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSwag.Annotations;
using SimpleCreditCalculator.Models;
using SimpleCreditCalculator.Services.Interfaces;

namespace SimpleCreditCalculator.Controllers
{
    [OpenApiIgnore]
    public class CreditController : Controller
    {
        private readonly ILogger<CreditController> _logger;
        private readonly ICreditCalculatorService _creditCalculatorService;

        public CreditController(ICreditCalculatorService creditCalculatorService, ILogger<CreditController> logger)
        {
            _creditCalculatorService = creditCalculatorService;
            _logger = logger;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PaymentsSchedule(InputDataCredit inputDataCredit)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Credit");
            }

            var creditDetails = await _creditCalculatorService.GetOutputCreditDetails(inputDataCredit);

            return View(creditDetails);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
