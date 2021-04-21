using SimpleCreditCalculator.Models.Interfaces;

namespace SimpleCreditCalculator.BL.Services.Interfaces
{
    public interface ICreditCalculatorService
    {
        /// <summary>
        /// Получить рассчитанные данные по кредиту
        /// </summary>
        IOutputDataCredit GetOutputCreditDetails(IInputDataCredit inputDataCredit);
    }
}