using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class LabelTemplateElement
    {
        /// <summary>
        /// Name of the attribute that is shown to the consumer on selection pages or screens
        /// </summary>
        [JsonProperty("attributeKey")]
        public string AttributeKey { get; set; }

        /// <summary>
        /// Regular mask for the attributeKey Note: The mask is optional as not every field has a mask
        /// </summary>
        [JsonProperty("mask")]
        public string Mask { get; set; }
    }
}