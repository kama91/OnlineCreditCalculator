using ApiClient;
using System;
using System.Threading.Tasks;

namespace ApiClientConsole
{
    public static class Program
    {
        private async static Task Main(string[] args)
        {
            while (Console.ReadKey().Key != ConsoleKey.S)
            {
            }

            var client = new DataCreditClient("https://localhost:44345/");
            var data = await client.GetOutputCreditDetailsAsync(
                new InputDataCredit
                {
                    SumOfCredit = 100000,
                    CreditTerm = 12,
                    InterestRateOfYear = 12
                });

            Console.WriteLine(data.OverPayment);
            foreach(var d in data.PaymentDetails)
            {
                Console.WriteLine(d.PaymentNumber);
            }
        }
    }
}
