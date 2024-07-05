// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace KiotaSamples.PetStoreSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Order : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The complete property</summary>
        public bool? Complete { get; set; }
        /// <summary>The id property</summary>
        public long? Id { get; set; }
        /// <summary>The petId property</summary>
        public long? PetId { get; set; }
        /// <summary>The quantity property</summary>
        public int? Quantity { get; set; }
        /// <summary>The shipDate property</summary>
        public DateTimeOffset? ShipDate { get; set; }
        /// <summary>Order Status</summary>
        public global::KiotaSamples.PetStoreSdk.Models.Order_status? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::KiotaSamples.PetStoreSdk.Models.Order"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::KiotaSamples.PetStoreSdk.Models.Order CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::KiotaSamples.PetStoreSdk.Models.Order();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "complete", n => { Complete = n.GetBoolValue(); } },
                { "id", n => { Id = n.GetLongValue(); } },
                { "petId", n => { PetId = n.GetLongValue(); } },
                { "quantity", n => { Quantity = n.GetIntValue(); } },
                { "shipDate", n => { ShipDate = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::KiotaSamples.PetStoreSdk.Models.Order_status>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("complete", Complete);
            writer.WriteLongValue("id", Id);
            writer.WriteLongValue("petId", PetId);
            writer.WriteIntValue("quantity", Quantity);
            writer.WriteDateTimeOffsetValue("shipDate", ShipDate);
            writer.WriteEnumValue<global::KiotaSamples.PetStoreSdk.Models.Order_status>("status", Status);
        }
    }
}
