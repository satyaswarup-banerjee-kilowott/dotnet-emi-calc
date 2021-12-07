namespace EmiApp
{
    public class Response
    {
        public decimal EmiPayment { get; set; }


        public string[] EmiPaymentType { get; set; } = { "Continous", "Daily", "Monthly" };     
        // for example "monthly", "daily", "continuous"
        public string ErrorMessage { get; set; } = "Unexpected error occured....";
    }
}