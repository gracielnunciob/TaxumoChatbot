// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace TaxumoChatBot.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class WithheldTaxExpanded
    {
        /// <summary>
        /// Initializes a new instance of the WithheldTaxExpanded class.
        /// </summary>
        public WithheldTaxExpanded()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WithheldTaxExpanded class.
        /// </summary>
        public WithheldTaxExpanded(int? id = default(int?), int? company = default(int?), System.DateTime? transactionDate = default(System.DateTime?), string taxCode = default(string), double? baseAmount = default(double?), double? remittedAmount = default(double?), System.DateTime? dateCreated = default(System.DateTime?), System.DateTime? dateModified = default(System.DateTime?), string supplierTin = default(string), string supplierName = default(string), string supplierAddress = default(string), string supplierZipCode = default(string), string doc = default(string))
        {
            Id = id;
            Company = company;
            TransactionDate = transactionDate;
            TaxCode = taxCode;
            BaseAmount = baseAmount;
            RemittedAmount = remittedAmount;
            DateCreated = dateCreated;
            DateModified = dateModified;
            SupplierTin = supplierTin;
            SupplierName = supplierName;
            SupplierAddress = supplierAddress;
            SupplierZipCode = supplierZipCode;
            Doc = doc;
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
        [JsonProperty(PropertyName = "Company")]
        public int? Company { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TransactionDate")]
        public System.DateTime? TransactionDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TaxCode")]
        public string TaxCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BaseAmount")]
        public double? BaseAmount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RemittedAmount")]
        public double? RemittedAmount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateCreated")]
        public System.DateTime? DateCreated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateModified")]
        public System.DateTime? DateModified { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SupplierTin")]
        public string SupplierTin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SupplierName")]
        public string SupplierName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SupplierAddress")]
        public string SupplierAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SupplierZipCode")]
        public string SupplierZipCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Doc")]
        public string Doc { get; set; }

    }
}
