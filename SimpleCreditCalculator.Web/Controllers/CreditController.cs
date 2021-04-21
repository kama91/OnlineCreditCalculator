using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSwag.Annotations;
using SimpleCreditCalculator.BL.Services.Interfaces;
using SimpleCreditCalculator.Models;
using System;

namespace SimpleCreditCalculator.Controllers
{
    [OpenApiIgnore]
    public class CreditController : Controller
    {
        private readonly ILogger<CreditController> _logger;
        private readonly ICreditCalculatorService _creditCalculatorService;

        public CreditController(
            ICreditCalculatorService creditCalculatorService,
            ILogger<CreditController> logger)
        {
            _creditCalculatorService = creditCalculatorService ?? throw new ArgumentNullException(nameof(creditCalculatorService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PaymentsSchedule(InputDataCredit inputDataCredit)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "One or some parameter(-s) of credit is not valid.");

                return RedirectToAction("Index", "Credit");
            }

            var creditDetails = _creditCalculatorService.GetOutputCreditDetails(inputDataCredit);

            return View(creditDetails);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
