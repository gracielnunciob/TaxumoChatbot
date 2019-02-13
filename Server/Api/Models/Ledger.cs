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

    public partial class Ledger
    {
        /// <summary>
        /// Initializes a new instance of the Ledger class.
        /// </summary>
        public Ledger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Ledger class.
        /// </summary>
        public Ledger(string name = default(string), IList<LedgerEntry> entries = default(IList<LedgerEntry>))
        {
            Name = name;
            Entries = entries;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entries")]
        public IList<LedgerEntry> Entries { get; set; }

    }
}