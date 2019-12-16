namespace Payir.Models
{
    public class PaymentVerify
    {
        public string ApiKey { get; private set; }
        public string Token { get; set; }

        public void SetApiKey(string apiKey)
        {
            ApiKey = apiKey;
        }
    }
}
