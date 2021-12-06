namespace EmiApp
{
    public class Response
    {
        public decimal EmiPayment { get; set; }
       

        public string EmiPaymentType3 { get; set; } = "Monthly";
        public string EmiPaymentType2 { get; set; } = "Daily";
        public string EmiPaymentType1 { get; set; } = "Continous";
        // for example "monthly", "daily", "continuous"
        public string ErrorMessage { get; set; } = string.Empty;
    }
}