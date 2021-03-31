using SimpleCreditCalculator.Models;
using SimpleCreditCalculator.Models.Interfaces;

using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace SimpleCreditCalculator.Services.Interfaces
{
    public interface ICreditCalculatorService
    {
        /// <summary>
        /// Получить рассчитанные данные по кредиту
        /// </summary>
        Task<IOutputDataCredit> GetOutputCreditDetails(IInputDataCredit inputDataCredit);
    }
}