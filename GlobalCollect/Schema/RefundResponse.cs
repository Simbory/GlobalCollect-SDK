using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RefundResponse
    {
        /// <summary>
        /// Our unique refund transaction identifier
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Information of the refund resource such as amount, currency, nature of the refund.
        /// </summary>
        [JsonProperty("refundOutput")]
        public RefundOutput RefundOutput { get; set; }

        /// <summary>
        /// Current high-level status of the refund in a human-readable form. Possible values are: CREATED - The transaction has been created. This is the initial state once a new refund is created. PENDING_APPROVAL - The transaction is awaiting approval from you to proceed with the processing of the refund REJECTED - The refund has been rejected REFUND_REQUESTED - The transaction is in the queue to be refunded CAPTURED - We have successfully refunded the consumer and has received an online confirmation from the third party REFUNDED - We have successfully refunded the consumer CANCELLED - You have cancelled the transaction
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// This object has the numeric representation of the current refund status, timestamp of last status change and performable action on the current refund resource. In case of a rejected refund, detailed error information is listed.
        /// </summary>
        [JsonProperty("statusOutput")]
        public OrderStatusOutput StatusOutput { get; set; }
    }
}