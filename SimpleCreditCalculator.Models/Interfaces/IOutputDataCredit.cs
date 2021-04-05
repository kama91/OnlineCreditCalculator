using System.Collections.Generic;

namespace SimpleCreditCalculator.Models.Interfaces
{
    public interface IOutputDataCredit
    {
        IReadOnlyCollection<PaymentDetails> PaymentDetails { get; }

        decimal OverPayment { get; }
    }
}
