// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace TaxumoChatBot.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PaymentFormDetails
    {
        /// <summary>
        /// Initializes a new instance of the PaymentFormDetails class.
        /// </summary>
        public PaymentFormDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PaymentFormDetails class.
        /// </summary>
        public PaymentFormDetails(System.DateTime? returnDate = default(System.DateTime?), string aTC = default(string), string taxType = default(string), string taxpayerType = default(string), string paymentManner = default(string), string paymentType = default(string), double? amount = default(double?), string requiredDetails = default(string))
        {
            ReturnDate = returnDate;
            ATC = aTC;
            TaxType = taxType;
            TaxpayerType = taxpayerType;
            PaymentManner = paymentManner;
            PaymentType = paymentType;
            Amount = amount;
            RequiredDetails = requiredDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReturnDate")]
        public System.DateTime? ReturnDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ATC")]
        public string ATC { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TaxType")]
        public string TaxType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TaxpayerType")]
        public string TaxpayerType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PaymentManner")]
        public string PaymentManner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PaymentType")]
        public string PaymentType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RequiredDetails")]
        public string RequiredDetails { get; set; }

    }
}