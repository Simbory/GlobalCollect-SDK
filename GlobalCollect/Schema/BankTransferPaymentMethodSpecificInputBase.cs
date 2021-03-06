using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class BankTransferPaymentMethodSpecificInputBase
    {
        /// <summary>
        /// Your additional reference identifier for this transaction. Data supplied in this field will also be returned in our report files, allowing you to reconcile the incoming funds.
        /// </summary>
        [JsonProperty("additionalReference")]
        public string AdditionalReference { get; set; }

        /// <summary>
        /// Payment product identifier
        /// </summary>
        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }
    }
}