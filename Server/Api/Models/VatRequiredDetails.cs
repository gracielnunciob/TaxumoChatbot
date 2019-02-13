// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace TaxumoChatBot.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class VatRequiredDetails
    {
        /// <summary>
        /// Initializes a new instance of the VatRequiredDetails class.
        /// </summary>
        public VatRequiredDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VatRequiredDetails class.
        /// </summary>
        public VatRequiredDetails(double? inputTaxCarriedOver = default(double?), double? inputTaxDeferredOnCapitalGoods = default(double?), double? transitionalInputTax = default(double?), double? presumptiveInputTax = default(double?), double? others = default(double?), string requiredFields = default(string))
        {
            InputTaxCarriedOver = inputTaxCarriedOver;
            InputTaxDeferredOnCapitalGoods = inputTaxDeferredOnCapitalGoods;
            TransitionalInputTax = transitionalInputTax;
            PresumptiveInputTax = presumptiveInputTax;
            Others = others;
            RequiredFields = requiredFields;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InputTaxCarriedOver")]
        public double? InputTaxCarriedOver { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InputTaxDeferredOnCapitalGoods")]
        public double? InputTaxDeferredOnCapitalGoods { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TransitionalInputTax")]
        public double? TransitionalInputTax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PresumptiveInputTax")]
        public double? PresumptiveInputTax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Others")]
        public double? Others { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RequiredFields")]
        public string RequiredFields { get; set; }

    }
}
