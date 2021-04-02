using System.Collections.Generic;
using System.Linq;

using SimpleCreditCalculator.Models.Interfaces;

namespace SimpleCreditCalculator.Models
{
    public class OutputDataCredit : IOutputDataCredit
    {
        public List<PaymentDetails> PaymentDetails { get; }
        public decimal OverPayment { get; }

        public OutputDataCredit(
            IEnumerable<IPaymentDetails> paymentDetails,
            decimal overPayment)
        {
            PaymentDetails = paymentDetails.Cast<PaymentDetails>().ToList();
            OverPayment = overPayment;
        }
    }
}
