using Newtonsoft.Json;
using Payir.Models;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Payir
{
    public class Payment
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// Returns a new Pay.ir payment object.
        /// </summary>
        /// <param name="apiKey">Client's ApiKey, For test api call, use parameterless constructor</param>
        public Payment(string apiKey = "test")
        {
            _apiKey = apiKey;
        }

        /// <summary>
        /// Return a token for payment
        /// </summary>
        /// <param name="paymentRequest">Payload for getting token request</param>
        /// <returns></returns>
        public async Task<PaymentRequestResult> GetTokenAsync(PaymentRequest paymentRequest)
        {
            paymentRequest.SetApiKey(_apiKey);
            var json = JsonConvert.SerializeObject(paymentRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{PayirDefaults.RequestUri}", content);
            
            return JsonConvert.DeserializeObject<PaymentRequestResult>(await response.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Returns verification result
        /// </summary>
        /// <param name="paymentVerify">Payload for verifying payment</param>
        /// <returns></returns>
        public async Task<PaymentVerifyResult> VerifyAsync(PaymentVerify paymentVerify)
        {
            paymentVerify.SetApiKey(_apiKey);
            var json = JsonConvert.SerializeObject(paymentVerify);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{PayirDefaults.VerifyUri}", content);
            
            return JsonConvert.DeserializeObject<PaymentVerifyResult>(await response.Content.ReadAsStringAsync());
        }
    }
}