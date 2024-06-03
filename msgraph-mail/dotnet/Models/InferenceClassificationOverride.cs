// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Graphdotnetv4.Models
{
    #pragma warning disable CS1591
    public class InferenceClassificationOverride : Graphdotnetv4.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The classifyAs property</summary>
        public Graphdotnetv4.Models.InferenceClassificationType? ClassifyAs { get; set; }
        /// <summary>The senderEmailAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Graphdotnetv4.Models.EmailAddress? SenderEmailAddress { get; set; }
#nullable restore
#else
        public Graphdotnetv4.Models.EmailAddress SenderEmailAddress { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Graphdotnetv4.Models.InferenceClassificationOverride"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Graphdotnetv4.Models.InferenceClassificationOverride CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Graphdotnetv4.Models.InferenceClassificationOverride();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "classifyAs", n => { ClassifyAs = n.GetEnumValue<Graphdotnetv4.Models.InferenceClassificationType>(); } },
                { "senderEmailAddress", n => { SenderEmailAddress = n.GetObjectValue<Graphdotnetv4.Models.EmailAddress>(Graphdotnetv4.Models.EmailAddress.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<Graphdotnetv4.Models.InferenceClassificationType>("classifyAs", ClassifyAs);
            writer.WriteObjectValue<Graphdotnetv4.Models.EmailAddress>("senderEmailAddress", SenderEmailAddress);
        }
    }
}
