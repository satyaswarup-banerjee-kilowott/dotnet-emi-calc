﻿namespace EmiApp
{
    public class Calculator: ICalculator
    {
        public Response CalculateContinousEmi(Request request)
        {
            var response = new Response();
            if(request.InterestRateInPercentage == 0)
            {
                throw new NotFiniteNumberException();
            }

            try
            {
                var p = request.Principal;
                var time = request.LoanDurationInYearCount;
                var rate = request.InterestRateInPercentage / 100;
                var cont = (double)p * System.Math.Pow(1 + (rate / 365), 365 * time);
                response.EmiPayment = (decimal)cont;
                return response;
            }
            catch (Exception ex)
            {
                
                    response = new Response() { ErrorMessage = ex.Message.ToString() };
                
            }
            finally{}
            return response;
        }

        public Response CalculateDailyEmi(Request request)
        {
            var response = new Response();
            try
            {
                var p = request.Principal;
                var time = request.LoanDurationInYearCount;
                var rate = request.InterestRateInPercentage / 100;
                double exp = 2.7183;
                var daily = (double)p * System.Math.Pow(exp, (rate * time)) - (p);
                response.EmiPayment = (decimal)daily;
            }

            catch (Exception ex)
            {
                
                    response = new Response() { ErrorMessage = ex.Message.ToString() };
              
            }
          return response;
          

        }

        public Response CalculateMonthlyEmi(Request request)
        {
            var response = new Response();
            try
            {
                var power = request.LoanDurationInYearCount * 12;
                var rate = request.InterestRateInPercentage / 100;
                var accumulated = (double)request.Principal * System.Math.Pow(1 + rate / 12, power);
                response.EmiPayment = (decimal)accumulated / (power);
                // convert to response object
                return response;
            }
            catch (Exception ex)
            {
                
                    response = new Response {ErrorMessage = ex.Message.ToString() };
       
            }
           
            finally { }
            return response;

            
        }
    }
}