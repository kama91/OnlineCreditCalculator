using SimpleCreditCalculator.Models.Interfaces;

using System.Threading.Tasks;

namespace SimpleCreditCalculator.Services
{
    public interface ICreditCalculatorService
    {
        /// <summary>
        /// Получить рассчитанные данные по кредиту
        /// </summary>
        Task<IOutputDataCredit> GetOutputDataCreditDetails(IInputDataCredit inputDataCredit);
    }
}