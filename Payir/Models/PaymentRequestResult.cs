namespace Payir.Models
{
    public class PaymentRequestResult
    {
        public bool Status { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string Token { get; set; }
    }
}
