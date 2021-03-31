using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SimpleCreditCalculator.Models.Interfaces
{
    public interface IOutputDataCredit
    {
        ICollection<IPaymentDetails> PaymentDetails { get; }

        decimal OverPayment { get; }
    }
}
