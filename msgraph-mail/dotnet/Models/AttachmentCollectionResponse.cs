// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Graphdotnetv4.Models
{
    #pragma warning disable CS1591
    public class AttachmentCollectionResponse : IAdditionalDataHolder, IParsable
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
        public List<Graphdotnetv4.Models.Attachment>? Value { get; set; }
#nullable restore
#else
        public List<Graphdotnetv4.Models.Attachment> Value { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Graphdotnetv4.Models.AttachmentCollectionResponse"/> and sets the default values.
        /// </summary>
        public AttachmentCollectionResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Graphdotnetv4.Models.AttachmentCollectionResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Graphdotnetv4.Models.AttachmentCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Graphdotnetv4.Models.AttachmentCollectionResponse();
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
                { "value", n => { Value = n.GetCollectionOfObjectValues<Graphdotnetv4.Models.Attachment>(Graphdotnetv4.Models.Attachment.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Graphdotnetv4.Models.Attachment>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
