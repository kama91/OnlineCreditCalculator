using System.Collections.Generic;
using SimpleCreditCalculator.Models.Interfaces;

namespace SimpleCreditCalculator.Models
{
    public class OutputDataCredit : IOutputDataCredit
    {
        public ICollection<IPaymentDetails> PaymentDetails { get; }
        public decimal OverPayment { get; }

        public OutputDataCredit(
            ICollection<IPaymentDetails> paymentDetails,
            decimal overPayment)
        {
            PaymentDetails = paymentDetails;
            OverPayment = overPayment;
        }
    }
}
