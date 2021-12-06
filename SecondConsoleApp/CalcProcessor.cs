using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    internal class CalcProcessor
    {
        internal double Amt { private get; set; }
        internal double i { private get; set; }
        internal int t { private get; set; }
        internal int n { private get; set; }



        internal double CalculateEMI()
        {
            double EMI = 0;

            EMI = Amt * Math.Pow((1 + i/n), 2*n);

            return EMI;
        }

       

        
    }
}