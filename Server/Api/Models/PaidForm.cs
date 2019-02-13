// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace TaxumoChatBot.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PaidForm
    {
        /// <summary>
        /// Initializes a new instance of the PaidForm class.
        /// </summary>
        public PaidForm()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PaidForm class.
        /// </summary>
        public PaidForm(int? id = default(int?), int? company = default(int?), string formType = default(string), int? year = default(int?), int? period = default(int?), System.DateTime? dateCreated = default(System.DateTime?), System.DateTime? dateModified = default(System.DateTime?), string user = default(string))
        {
            Id = id;
            Company = company;
            FormType = formType;
            Year = year;
            Period = period;
            DateCreated = dateCreated;
            DateModified = dateModified;
            User = user;
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
        [JsonProperty(PropertyName = "DateCreated")]
        public System.DateTime? DateCreated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateModified")]
        public System.DateTime? DateModified { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "User")]
        public string User { get; set; }

    }
}