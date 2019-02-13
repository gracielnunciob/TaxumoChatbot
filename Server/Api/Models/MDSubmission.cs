// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace TaxumoChatBot.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MDSubmission
    {
        /// <summary>
        /// Initializes a new instance of the MDSubmission class.
        /// </summary>
        public MDSubmission()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MDSubmission class.
        /// </summary>
        public MDSubmission(int? id = default(int?), IList<TaxSubmission> taxSubmission = default(IList<TaxSubmission>), int? company = default(int?), string formType = default(string), int? year = default(int?), int? period = default(int?), int? status = default(int?), System.DateTime? dateCreated = default(System.DateTime?), System.DateTime? dateModified = default(System.DateTime?))
        {
            Id = id;
            TaxSubmission = taxSubmission;
            Company = company;
            FormType = formType;
            Year = year;
            Period = period;
            Status = status;
            DateCreated = dateCreated;
            DateModified = dateModified;
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
        [JsonProperty(PropertyName = "TaxSubmission")]
        public IList<TaxSubmission> TaxSubmission { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Company")]
        public int? Company { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FormType")]
        public string FormType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Year")]
        public int? Year { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Period")]
        public int? Period { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public int? Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateCreated")]
        public System.DateTime? DateCreated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateModified")]
        public System.DateTime? DateModified { get; set; }

    }
}
