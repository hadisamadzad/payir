namespace Payir.Models
{
    public class PaymentVerify
    {
        public string api { get; private set; }
        public string token { get; set; }

        public void SetApiKey(string apiKey)
        {
            api = apiKey;
        }
    }
}
