// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Graphdotnetv4.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class ExtensionCollectionResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataNextLink property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataNextLink { get; set; }
#nullable restore
#else
        public string OdataNextLink { get; set; }
#endif
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Graphdotnetv4.Models.Extension>? Value { get; set; }
#nullable restore
#else
        public List<global::Graphdotnetv4.Models.Extension> Value { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Graphdotnetv4.Models.ExtensionCollectionResponse"/> and sets the default values.
        /// </summary>
        public ExtensionCollectionResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Graphdotnetv4.Models.ExtensionCollectionResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Graphdotnetv4.Models.ExtensionCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Graphdotnetv4.Models.ExtensionCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.nextLink", n => { OdataNextLink = n.GetStringValue(); } },
                { "value", n => { Value = n.GetCollectionOfObjectValues<global::Graphdotnetv4.Models.Extension>(global::Graphdotnetv4.Models.Extension.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", OdataNextLink);
            writer.WriteCollectionOfObjectValues<global::Graphdotnetv4.Models.Extension>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
