// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace TaxumoChatBot.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TaxableTransaction
    {
        /// <summary>
        /// Initializes a new instance of the TaxableTransaction class.
        /// </summary>
        public TaxableTransaction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaxableTransaction class.
        /// </summary>
        public TaxableTransaction(string aTC = default(string), string industryClassification = default(string), double? taxableAmount = default(double?), double? taxRate = default(double?), double? taxDue = default(double?))
        {
            ATC = aTC;
            IndustryClassification = industryClassification;
            TaxableAmount = taxableAmount;
            TaxRate = taxRate;
            TaxDue = taxDue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ATC")]
        public string ATC { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IndustryClassification")]
        public string IndustryClassification { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TaxableAmount")]
        public double? TaxableAmount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TaxRate")]
        public double? TaxRate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TaxDue")]
        public double? TaxDue { get; set; }

    }
}