namespace Payir.Models
{
    public class PaymentRequest
    {
        public string api { get; private set; }
        public int amount { get; set; }
        public string redirect { get; set; }
        public string mobile { get; set; }
        public string factorNumber { get; set; }
        public string description { get; set; }
        public string validCardNumber { get; set; }

        public void SetApiKey(string apiKey)
        {
            api = apiKey;
        }
    }
}
