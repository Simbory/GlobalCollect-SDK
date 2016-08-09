using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PaymentProductFieldTooltip
    {
        /// <summary>
        /// Relative URL that can be used to retrieve an image for the tooltip image. You can use our server-side resize functionality by appending '?size={{width}}x{{height}}' to the full URL, where width and height are specified in pixels. The resized image will always keep its correct aspect ratio.
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// A text explaining the field in more detail. This is meant to be used for displaying to the consumer.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }
    }
}