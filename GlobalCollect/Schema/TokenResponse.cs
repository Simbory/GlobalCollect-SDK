using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class TokenResponse
    {
        /// <summary>
        /// Object containing card details
        /// </summary>
        [JsonProperty("card")]
        public TokenCard Card { get; set; }

        /// <summary>
        /// Object containing eWallet details
        /// </summary>
        [JsonProperty("eWallet")]
        public TokenEWallet EWallet { get; set; }

        /// <summary>
        /// Object containing the non SEPA Direct Debit details
        /// </summary>
        [JsonProperty("nonSepaDirectDebit")]
        public TokenNonSepaDirectDebit NonSepaDirectDebit { get; set; }

        /// <summary>
        /// Payment product identifier Required
        /// </summary>
        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }

        /// <summary>
        /// Object containing the SEPA Direct Debit details
        /// </summary>
        [JsonProperty("sepaDirectDebit")]
        public TokenSepaDirectDebit SepaDirectDebit { get; set; }
    }
}