using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CreateHostedCheckoutResponse
    {
        /// <summary>
        /// When the consumer is returned to your site we will append this field and value to the query-string. You should store this data, so you can identify the returning consumer.
        /// </summary>
        [JsonProperty("RETURNMAC")]
        public string RETURNMAC { get; set; }

        /// <summary>
        /// This is the ID under which the data for this checkout can be retrieved.
        /// </summary>
        [JsonProperty("hostedCheckoutId")]
        public string HostedCheckoutId { get; set; }

        /// <summary>
        /// The partial URL as generated by our system. You will need to add the protocol and the relevant subdomain to this URL, before redirecting your consumer to this URL. A special 'payment' subdomain will always work so you can always add 'https://payment.' at the beginning of this response value to view your MyCheckout hosted payment pages.
        /// </summary>
        [JsonProperty("partialRedirectUrl")]
        public string PartialRedirectUrl { get; set; }
    }
}