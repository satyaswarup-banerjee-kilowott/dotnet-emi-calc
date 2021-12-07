using System;

namespace EmiApp.Cmdline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var emiRequest = new Request() { Principal = 100000, InterestRateInPercentage = 12, LoanDurationInYearCount = 2 };
        

            ICalculator emiCalculator = new Calculator();

     
            var response = new Response();


            var emiContinous = emiCalculator.CalculateContinousEmi(emiRequest);
            if (!string.IsNullOrEmpty(emiContinous.ErrorMessage))
                Console.WriteLine($"{response.EmiPaymentType[0]} EMI is :" + Math.Round(emiContinous.EmiPayment , 3) + " INR" );
            else
                Console.WriteLine(emiContinous.ErrorMessage);



            var emiDaily = emiCalculator.CalculateDailyEmi(emiRequest);
            if (!string.IsNullOrEmpty(emiDaily.ErrorMessage))
                Console.WriteLine($"{response.EmiPaymentType[1]} EMI is : "+ Math.Round(emiDaily.EmiPayment , 3) + " INR");
            else
                Console.WriteLine(emiDaily.ErrorMessage);

            



            var emiMonthly = emiCalculator.CalculateMonthlyEmi(emiRequest);
            if (!string.IsNullOrEmpty(emiMonthly.ErrorMessage))
                Console.WriteLine($"{response.EmiPaymentType[2]} EMI is : " + Math.Round(emiMonthly.EmiPayment , 3) + " INR");
            else
                Console.WriteLine(emiMonthly.ErrorMessage);


           













        }
    }
}

