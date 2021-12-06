using System;

namespace EmiApp.Cmdline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var emiRequest = new Request() { Principal = 100000, InterestRateInPercentage = 12, LoanDurationInYearCount = 2 };
            ICalculator emiCalculator = new Calculator();

            #region monthly compounding
            var emiMonthly = emiCalculator.CalculateMonthlyEmi(emiRequest);
            if (string.IsNullOrEmpty(emiMonthly.ErrorMessage))
                Console.WriteLine($"Monthly EMI is {emiMonthly}");
            else 
                Console.WriteLine(emiMonthly.ErrorMessage);
            #endregion 

            // fill other regions below...

        }
    }
}

