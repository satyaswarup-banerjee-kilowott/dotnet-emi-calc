using System;

namespace SecondConsoleApp
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            try {
                var spObject = new CalcProcessor();
                Console.WriteLine("Enter the principle amount for EMI:");
                double principal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the rate of interest for EMI:");
                double interest = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the duration for EMI (in years):");
                int duration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the monthly compounding for EMI:");
                int compounding = Convert.ToInt32(Console.ReadLine());

                if(compounding > 12)
                {
                    throw new MonthlyCom();
                }


                spObject.Amt = principal;
                spObject.i = interest;
                spObject.t = duration;
                spObject.n = compounding;

                var FinalEMI = spObject.CalculateEMI();



                Console.WriteLine("The calculated EMI is: " + Math.Round(FinalEMI, 3) + "  INR\n");

            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                
            }

            finally
            {
               
                Console.WriteLine("Calculation Elapsed.....");

            }










        }
    }
}