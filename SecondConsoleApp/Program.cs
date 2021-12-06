using System;

namespace SecondConsoleApp
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            double principal = 0;
            double interest = 0;
            int duration = 0;
            int compounding = 0;



            var spObject = new CalcProcessor();
            Console.WriteLine("Enter the principle amount for EMI:");
            principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the rate of Interest for EMI:");
            interest = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the duration for EMI (in years):");
            duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the monthly compounding for EMI:");
            compounding = Convert.ToInt32(Console.ReadLine());
            
           

            spObject.Amt = principal;
            spObject.i = interest;
            spObject.t = duration;
            spObject.n = compounding;

            var FinalEMI = spObject.CalculateEMI();
            FinalEMI = Math.Round(FinalEMI,3);
            

            Console.WriteLine($"The calculated EMI is : {FinalEMI}");
            


        }
    }
}