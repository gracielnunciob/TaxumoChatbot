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

    public partial class Order
    {
        /// <summary>
        /// Initializes a new instance of the Order class.
        /// </summary>
        public Order()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Order class.
        /// </summary>
        public Order(System.Guid? id = default(System.Guid?), string owner = default(string), int? company = default(int?), Product product = default(Product), Coupon coupon = default(Coupon), System.DateTime? dateCreated = default(System.DateTime?), string status = default(string), IList<Settlement> settlements = default(IList<Settlement>), int? payment = default(int?))
        {
            Id = id;
            Owner = owner;
            Company = company;
            Product = product;
            Coupon = coupon;
            DateCreated = dateCreated;
            Status = status;
            Settlements = settlements;
            Payment = payment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Owner")]
        public string Owner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Company")]
        public int? Company { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product")]
        public Product Product { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Coupon")]
        public Coupon Coupon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateCreated")]
        public System.DateTime? DateCreated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Settlements")]
        public IList<Settlement> Settlements { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Payment")]
        public int? Payment { get; set; }

    }
}
