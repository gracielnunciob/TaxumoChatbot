// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace TaxumoChatBot.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Transaction2304
    {
        /// <summary>
        /// Initializes a new instance of the Transaction2304 class.
        /// </summary>
        public Transaction2304()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Transaction2304 class.
        /// </summary>
        public Transaction2304(string tIN = default(string), string name = default(string), string aTC = default(string), string incomeNature = default(string), double? incomeAmount = default(double?))
        {
            TIN = tIN;
            Name = name;
            ATC = aTC;
            IncomeNature = incomeNature;
            IncomeAmount = incomeAmount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TIN")]
        public string TIN { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ATC")]
        public string ATC { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IncomeNature")]
        public string IncomeNature { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IncomeAmount")]
        public double? IncomeAmount { get; set; }

    }
}