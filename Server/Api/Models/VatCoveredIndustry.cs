// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace TaxumoChatBot.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class VatCoveredIndustry
    {
        /// <summary>
        /// Initializes a new instance of the VatCoveredIndustry class.
        /// </summary>
        public VatCoveredIndustry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VatCoveredIndustry class.
        /// </summary>
        public VatCoveredIndustry(string code = default(string), string industry = default(string))
        {
            Code = code;
            Industry = industry;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Code")]
        public string Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Industry")]
        public string Industry { get; set; }

    }
}
