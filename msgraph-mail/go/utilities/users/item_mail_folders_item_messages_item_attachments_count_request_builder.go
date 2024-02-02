package users

import (
    "context"
    i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f "github.com/microsoft/kiota-abstractions-go"
    i64ecde285b206ca053eecbd6e7f197e884287a3d0eaa42aae2406e7b3007eba1 "github.com/microsoft/kiota-samples/msgraph-mail/go/utilities/models/odataerrors"
)

// ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilder builds and executes requests for operations under \users\{user-id}\mailFolders\{mailFolder-id}\messages\{message-id}\attachments\$count
type ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilder struct {
    i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.BaseRequestBuilder
}
// ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilderGetQueryParameters get the number of the resource
type ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilderGetQueryParameters struct {
    // Filter items by property values
    Filter *string `uriparametername:"%24filter"`
}
// ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilderGetRequestConfiguration configuration for the request such as headers, query parameters, and middleware options.
type ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilderGetRequestConfiguration struct {
    // Request headers
    Headers *i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestHeaders
    // Request options
    Options []i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestOption
    // Request query parameters
    QueryParameters *ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilderGetQueryParameters
}
// NewItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilderInternal instantiates a new ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilder and sets the default values.
func NewItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilderInternal(pathParameters map[string]string, requestAdapter i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestAdapter)(*ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilder) {
    m := &ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilder{
        BaseRequestBuilder: *i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.NewBaseRequestBuilder(requestAdapter, "{+baseurl}/users/{user%2Did}/mailFolders/{mailFolder%2Did}/messages/{message%2Did}/attachments/$count{?%24filter}", pathParameters),
    }
    return m
}
// NewItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilder instantiates a new ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilder and sets the default values.
func NewItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilder(rawUrl string, requestAdapter i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestAdapter)(*ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilder) {
    urlParams := make(map[string]string)
    urlParams["request-raw-url"] = rawUrl
    return NewItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilderInternal(urlParams, requestAdapter)
}
// Get get the number of the resource
// returns a *int32 when successful
// returns a ODataError error when the service returns a 4XX status code
// returns a ODataError error when the service returns a 5XX status code
func (m *ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilder) Get(ctx context.Context, requestConfiguration *ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilderGetRequestConfiguration)(*int32, error) {
    requestInfo, err := m.ToGetRequestInformation(ctx, requestConfiguration);
    if err != nil {
        return nil, err
    }
    errorMapping := i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.ErrorMappings {
        "4XX": i64ecde285b206ca053eecbd6e7f197e884287a3d0eaa42aae2406e7b3007eba1.CreateODataErrorFromDiscriminatorValue,
        "5XX": i64ecde285b206ca053eecbd6e7f197e884287a3d0eaa42aae2406e7b3007eba1.CreateODataErrorFromDiscriminatorValue,
    }
    res, err := m.BaseRequestBuilder.RequestAdapter.SendPrimitive(ctx, requestInfo, "int32", errorMapping)
    if err != nil {
        return nil, err
    }
    if res == nil {
        return nil, nil
    }
    return res.(*int32), nil
}
// ToGetRequestInformation get the number of the resource
// returns a *RequestInformation when successful
func (m *ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilder) ToGetRequestInformation(ctx context.Context, requestConfiguration *ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilderGetRequestConfiguration)(*i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestInformation, error) {
    requestInfo := i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.NewRequestInformationWithMethodAndUrlTemplateAndPathParameters(i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.GET, m.BaseRequestBuilder.UrlTemplate, m.BaseRequestBuilder.PathParameters)
    if requestConfiguration != nil {
        if requestConfiguration.QueryParameters != nil {
            requestInfo.AddQueryParameters(*(requestConfiguration.QueryParameters))
        }
        requestInfo.Headers.AddAll(requestConfiguration.Headers)
        requestInfo.AddRequestOptions(requestConfiguration.Options)
    }
    requestInfo.Headers.TryAdd("Accept", "text/plain;q=0.9")
    return requestInfo, nil
}
// WithUrl returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
// returns a *ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilder when successful
func (m *ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilder) WithUrl(rawUrl string)(*ItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilder) {
    return NewItemMailFoldersItemMessagesItemAttachmentsCountRequestBuilder(rawUrl, m.BaseRequestBuilder.RequestAdapter);
}
