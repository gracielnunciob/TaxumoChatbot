// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace TaxumoChatBot.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class VatClassification
    {
        /// <summary>
        /// Initializes a new instance of the VatClassification class.
        /// </summary>
        public VatClassification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VatClassification class.
        /// </summary>
        public VatClassification(int? id = default(int?), string classification = default(string))
        {
            Id = id;
            Classification = classification;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Classification")]
        public string Classification { get; set; }

    }
}
