using System.Collections.Generic;

namespace SimpleCreditCalculator.Models.Interfaces
{
    public interface IOutputDataCredit
    {
        List<PaymentDetails> PaymentDetails { get; }

        decimal OverPayment { get; }
    }
}
