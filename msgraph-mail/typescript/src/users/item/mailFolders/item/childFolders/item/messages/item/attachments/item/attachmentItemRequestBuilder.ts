import {Attachment} from '../../../../../../../../../../models/';
import {createAttachmentFromDiscriminatorValue} from '../../../../../../../../../../models/createAttachmentFromDiscriminatorValue';
import {AttachmentItemRequestBuilderDeleteRequestConfiguration} from './attachmentItemRequestBuilderDeleteRequestConfiguration';
import {AttachmentItemRequestBuilderGetRequestConfiguration} from './attachmentItemRequestBuilderGetRequestConfiguration';
import {BaseRequestBuilder, HttpMethod, Parsable, ParsableFactory, RequestAdapter, RequestInformation, RequestOption, ResponseHandler} from '@microsoft/kiota-abstractions';

/**
 * Builds and executes requests for operations under /users/{user-id}/mailFolders/{mailFolder-id}/childFolders/{mailFolder-id1}/messages/{message-id}/attachments/{attachment-id}
 */
export class AttachmentItemRequestBuilder extends BaseRequestBuilder {
    /**
     * Instantiates a new AttachmentItemRequestBuilder and sets the default values.
     * @param pathParameters The raw url or the Url template parameters for the request.
     * @param requestAdapter The request adapter to use to execute the requests.
     */
    public constructor(pathParameters: Record<string, unknown> | string | undefined, requestAdapter: RequestAdapter) {
        super(pathParameters, requestAdapter, "{+baseurl}/users/{user%2Did}/mailFolders/{mailFolder%2Did}/childFolders/{mailFolder%2Did1}/messages/{message%2Did}/attachments/{attachment%2Did}{?%24select,%24expand}");
    };
    /**
     * Delete navigation property attachments for users
     * @param requestConfiguration Configuration for the request such as headers, query parameters, and middleware options.
     * @param responseHandler Response handler to use in place of the default response handling provided by the core service
     * @returns a Promise of ArrayBuffer
     */
    public delete(requestConfiguration?: AttachmentItemRequestBuilderDeleteRequestConfiguration | undefined, responseHandler?: ResponseHandler | undefined) : Promise<ArrayBuffer | undefined> {
        const requestInfo = this.toDeleteRequestInformation(
            requestConfiguration
        );
        return this.requestAdapter?.sendPrimitiveAsync<ArrayBuffer>(requestInfo, "ArrayBuffer", responseHandler, undefined) ?? Promise.reject(new Error('request adapter is null'));
    };
    /**
     * Read the properties, relationships, or raw contents of an attachment that is attached to a user event, message, or group post.  An attachment can be one of the following types: All these types of attachments are derived from the attachment resource. 
     * @param requestConfiguration Configuration for the request such as headers, query parameters, and middleware options.
     * @param responseHandler Response handler to use in place of the default response handling provided by the core service
     * @returns a Promise of Attachment
     * @see {@link https://docs.microsoft.com/graph/api/attachment-get?view=graph-rest-1.0|Find more info here}
     */
    public get(requestConfiguration?: AttachmentItemRequestBuilderGetRequestConfiguration | undefined, responseHandler?: ResponseHandler | undefined) : Promise<Attachment | undefined> {
        const requestInfo = this.toGetRequestInformation(
            requestConfiguration
        );
        return this.requestAdapter?.sendAsync<Attachment>(requestInfo, createAttachmentFromDiscriminatorValue, responseHandler, undefined) ?? Promise.reject(new Error('request adapter is null'));
    };
    /**
     * Delete navigation property attachments for users
     * @param requestConfiguration Configuration for the request such as headers, query parameters, and middleware options.
     * @returns a RequestInformation
     */
    public toDeleteRequestInformation(requestConfiguration?: AttachmentItemRequestBuilderDeleteRequestConfiguration | undefined) : RequestInformation {
        const requestInfo = new RequestInformation();
        requestInfo.urlTemplate = this.urlTemplate;
        requestInfo.pathParameters = this.pathParameters;
        requestInfo.httpMethod = HttpMethod.DELETE;
        if (requestConfiguration) {
            requestInfo.addRequestHeaders(requestConfiguration.headers);
            requestInfo.addRequestOptions(requestConfiguration.options);
        }
        return requestInfo;
    };
    /**
     * Read the properties, relationships, or raw contents of an attachment that is attached to a user event, message, or group post.  An attachment can be one of the following types: All these types of attachments are derived from the attachment resource. 
     * @param requestConfiguration Configuration for the request such as headers, query parameters, and middleware options.
     * @returns a RequestInformation
     */
    public toGetRequestInformation(requestConfiguration?: AttachmentItemRequestBuilderGetRequestConfiguration | undefined) : RequestInformation {
        const requestInfo = new RequestInformation();
        requestInfo.urlTemplate = this.urlTemplate;
        requestInfo.pathParameters = this.pathParameters;
        requestInfo.httpMethod = HttpMethod.GET;
        requestInfo.headers["Accept"] = ["application/json"];
        if (requestConfiguration) {
            requestInfo.addRequestHeaders(requestConfiguration.headers);
            requestInfo.setQueryStringParametersFromRawObject(requestConfiguration.queryParameters);
            requestInfo.addRequestOptions(requestConfiguration.options);
        }
        return requestInfo;
    };
}
