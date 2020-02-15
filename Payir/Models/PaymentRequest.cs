namespace Payir.Models
{
    public class PaymentRequest
    {
        public string api { get; private set; }
        public int amount { get; set; }
        public string redirect { get; set; }
        public string mobile { get; set; }
        public string FactorNumber { get; set; }
        public string Description { get; set; }
        public string ValidCardNumber { get; set; }

        public void SetApiKey(string apiKey)
        {
            api = apiKey;
        }
    }
}
