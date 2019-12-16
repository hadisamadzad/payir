namespace Payir.Models
{
    public class PaymentRequest
    {
        public string ApiKey { get; private set; }
        public int Amount { get; set; }
        public string RedirectUrl { get; set; }
        public string Mobile { get; set; }
        public string FactorNumber { get; set; }
        public string Description { get; set; }
        public string ValidCardNumber { get; set; }

        public void SetApiKey(string apiKey)
        {
            ApiKey = apiKey;
        }
    }
}
