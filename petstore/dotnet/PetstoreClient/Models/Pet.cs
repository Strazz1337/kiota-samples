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
    public partial class Pet : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The category property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::KiotaSamples.PetStoreSdk.Models.Category? Category { get; set; }
#nullable restore
#else
        public global::KiotaSamples.PetStoreSdk.Models.Category Category { get; set; }
#endif
        /// <summary>The id property</summary>
        public long? Id { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The photoUrls property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PhotoUrls { get; set; }
#nullable restore
#else
        public List<string> PhotoUrls { get; set; }
#endif
        /// <summary>pet status in the store</summary>
        public global::KiotaSamples.PetStoreSdk.Models.Pet_status? Status { get; set; }
        /// <summary>The tags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::KiotaSamples.PetStoreSdk.Models.Tag>? Tags { get; set; }
#nullable restore
#else
        public List<global::KiotaSamples.PetStoreSdk.Models.Tag> Tags { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::KiotaSamples.PetStoreSdk.Models.Pet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::KiotaSamples.PetStoreSdk.Models.Pet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::KiotaSamples.PetStoreSdk.Models.Pet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "category", n => { Category = n.GetObjectValue<global::KiotaSamples.PetStoreSdk.Models.Category>(global::KiotaSamples.PetStoreSdk.Models.Category.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetLongValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "photoUrls", n => { PhotoUrls = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "status", n => { Status = n.GetEnumValue<global::KiotaSamples.PetStoreSdk.Models.Pet_status>(); } },
                { "tags", n => { Tags = n.GetCollectionOfObjectValues<global::KiotaSamples.PetStoreSdk.Models.Tag>(global::KiotaSamples.PetStoreSdk.Models.Tag.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::KiotaSamples.PetStoreSdk.Models.Category>("category", Category);
            writer.WriteLongValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfPrimitiveValues<string>("photoUrls", PhotoUrls);
            writer.WriteEnumValue<global::KiotaSamples.PetStoreSdk.Models.Pet_status>("status", Status);
            writer.WriteCollectionOfObjectValues<global::KiotaSamples.PetStoreSdk.Models.Tag>("tags", Tags);
        }
    }
}
