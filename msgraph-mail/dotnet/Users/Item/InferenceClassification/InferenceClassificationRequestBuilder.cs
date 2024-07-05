// <auto-generated/>
using Graphdotnetv4.Models.ODataErrors;
using Graphdotnetv4.Models;
using Graphdotnetv4.Users.Item.InferenceClassification.Overrides;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Graphdotnetv4.Users.Item.InferenceClassification
{
    /// <summary>
    /// Builds and executes requests for operations under \users\{user-id}\inferenceClassification
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class InferenceClassificationRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The overrides property</summary>
        public global::Graphdotnetv4.Users.Item.InferenceClassification.Overrides.OverridesRequestBuilder Overrides
        {
            get => new global::Graphdotnetv4.Users.Item.InferenceClassification.Overrides.OverridesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Graphdotnetv4.Users.Item.InferenceClassification.InferenceClassificationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InferenceClassificationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/inferenceClassification{?%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Graphdotnetv4.Users.Item.InferenceClassification.InferenceClassificationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InferenceClassificationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/inferenceClassification{?%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Relevance classification of the user&apos;s messages based on explicit designations that override inferred relevance or importance.
        /// </summary>
        /// <returns>A <see cref="global::Graphdotnetv4.Models.InferenceClassification"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Graphdotnetv4.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Graphdotnetv4.Models.InferenceClassification?> GetAsync(Action<RequestConfiguration<global::Graphdotnetv4.Users.Item.InferenceClassification.InferenceClassificationRequestBuilder.InferenceClassificationRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Graphdotnetv4.Models.InferenceClassification> GetAsync(Action<RequestConfiguration<global::Graphdotnetv4.Users.Item.InferenceClassification.InferenceClassificationRequestBuilder.InferenceClassificationRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Graphdotnetv4.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Graphdotnetv4.Models.InferenceClassification>(requestInfo, global::Graphdotnetv4.Models.InferenceClassification.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property inferenceClassification in users
        /// </summary>
        /// <returns>A <see cref="global::Graphdotnetv4.Models.InferenceClassification"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Graphdotnetv4.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Graphdotnetv4.Models.InferenceClassification?> PatchAsync(global::Graphdotnetv4.Models.InferenceClassification body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Graphdotnetv4.Models.InferenceClassification> PatchAsync(global::Graphdotnetv4.Models.InferenceClassification body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Graphdotnetv4.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Graphdotnetv4.Models.InferenceClassification>(requestInfo, global::Graphdotnetv4.Models.InferenceClassification.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Relevance classification of the user&apos;s messages based on explicit designations that override inferred relevance or importance.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Graphdotnetv4.Users.Item.InferenceClassification.InferenceClassificationRequestBuilder.InferenceClassificationRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Graphdotnetv4.Users.Item.InferenceClassification.InferenceClassificationRequestBuilder.InferenceClassificationRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property inferenceClassification in users
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Graphdotnetv4.Models.InferenceClassification body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Graphdotnetv4.Models.InferenceClassification body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Graphdotnetv4.Users.Item.InferenceClassification.InferenceClassificationRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Graphdotnetv4.Users.Item.InferenceClassification.InferenceClassificationRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Graphdotnetv4.Users.Item.InferenceClassification.InferenceClassificationRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Relevance classification of the user&apos;s messages based on explicit designations that override inferred relevance or importance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class InferenceClassificationRequestBuilderGetQueryParameters 
        {
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class InferenceClassificationRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Graphdotnetv4.Users.Item.InferenceClassification.InferenceClassificationRequestBuilder.InferenceClassificationRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class InferenceClassificationRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
