using SimpleCreditCalculator.Models.Interfaces;
using System.Threading.Tasks;

namespace SimpleCreditCalculator.BL.Services.Interfaces
{
    public interface ICreditCalculatorService
    {
        /// <summary>
        /// Получить рассчитанные данные по кредиту
        /// </summary>
        Task<IOutputDataCredit> GetOutputCreditDetails(IInputDataCredit inputDataCredit);
    }
}