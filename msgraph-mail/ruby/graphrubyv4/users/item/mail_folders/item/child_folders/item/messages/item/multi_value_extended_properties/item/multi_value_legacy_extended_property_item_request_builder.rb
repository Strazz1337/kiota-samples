require 'microsoft_kiota_abstractions'
require_relative '../../../../../../../../../../models/multi_value_legacy_extended_property'
require_relative '../../../../../../../../../users'
require_relative '../../../../../../../../item'
require_relative '../../../../../../../mail_folders'
require_relative '../../../../../../item'
require_relative '../../../../../child_folders'
require_relative '../../../../item'
require_relative '../../../messages'
require_relative '../../item'
require_relative '../multi_value_extended_properties'
require_relative './item'

module Graphrubyv4::Users::Item::MailFolders::Item::ChildFolders::Item::Messages::Item::MultiValueExtendedProperties::Item
    ## 
    # Builds and executes requests for operations under \users\{user-id}\mailFolders\{mailFolder-id}\childFolders\{mailFolder-id1}\messages\{message-id}\multiValueExtendedProperties\{multiValueLegacyExtendedProperty-id}
    class MultiValueLegacyExtendedPropertyItemRequestBuilder
        
        ## 
        # Path parameters for the request
        @path_parameters
        ## 
        # The request adapter to use to execute the requests.
        @request_adapter
        ## 
        # Url template to use to build the URL for the current request builder
        @url_template
        ## 
        ## Instantiates a new MultiValueLegacyExtendedPropertyItemRequestBuilder and sets the default values.
        ## @param pathParameters Path parameters for the request
        ## @param requestAdapter The request adapter to use to execute the requests.
        ## @return a void
        ## 
        def initialize(path_parameters, request_adapter)
            raise StandardError, 'path_parameters cannot be null' if path_parameters.nil?
            raise StandardError, 'request_adapter cannot be null' if request_adapter.nil?
            @url_template = "{+baseurl}/users/{user%2Did}/mailFolders/{mailFolder%2Did}/childFolders/{mailFolder%2Did1}/messages/{message%2Did}/multiValueExtendedProperties/{multiValueLegacyExtendedProperty%2Did}{?%24select,%24expand}"
            @request_adapter = request_adapter
            if path_parameters.is_a? String
                path_parameters = { "request-raw-url" => path_parameters }
            end
            @path_parameters = path_parameters
        end
        ## 
        ## Delete navigation property multiValueExtendedProperties for users
        ## @param requestConfiguration Configuration for the request such as headers, query parameters, and middleware options.
        ## @return a request_information
        ## 
        def create_delete_request_information(request_configuration=nil)
            request_info = MicrosoftKiotaAbstractions::RequestInformation.new()
            request_info.url_template = @url_template
            request_info.path_parameters = @path_parameters
            request_info.http_method = :DELETE
            unless request_configuration.nil?
                request_info.set_headers_from_raw_object(request_configuration.headers)
                request_info.add_request_options(request_configuration.options)
            end
            return request_info
        end
        ## 
        ## The collection of multi-value extended properties defined for the message. Nullable.
        ## @param requestConfiguration Configuration for the request such as headers, query parameters, and middleware options.
        ## @return a request_information
        ## 
        def create_get_request_information(request_configuration=nil)
            request_info = MicrosoftKiotaAbstractions::RequestInformation.new()
            request_info.url_template = @url_template
            request_info.path_parameters = @path_parameters
            request_info.http_method = :GET
            request_info.headers['Accept'] = 'application/json'
            unless request_configuration.nil?
                request_info.set_headers_from_raw_object(request_configuration.headers)
                request_info.set_query_string_parameters_from_raw_object(request_configuration.query_parameters)
                request_info.add_request_options(request_configuration.options)
            end
            return request_info
        end
        ## 
        ## Update the navigation property multiValueExtendedProperties in users
        ## @param body The request body
        ## @param requestConfiguration Configuration for the request such as headers, query parameters, and middleware options.
        ## @return a request_information
        ## 
        def create_patch_request_information(body, request_configuration=nil)
            raise StandardError, 'body cannot be null' if body.nil?
            request_info = MicrosoftKiotaAbstractions::RequestInformation.new()
            request_info.url_template = @url_template
            request_info.path_parameters = @path_parameters
            request_info.http_method = :PATCH
            unless request_configuration.nil?
                request_info.set_headers_from_raw_object(request_configuration.headers)
                request_info.add_request_options(request_configuration.options)
            end
            request_info.set_content_from_parsable(self.request_adapter, "application/json", body)
            return request_info
        end
        ## 
        ## Delete navigation property multiValueExtendedProperties for users
        ## @param requestConfiguration Configuration for the request such as headers, query parameters, and middleware options.
        ## @param responseHandler Response handler to use in place of the default response handling provided by the core service
        ## @return a CompletableFuture of void
        ## 
        def delete(request_configuration=nil, response_handler=nil)
            request_info = self.create_delete_request_information(
                request_configuration
            )
            return @request_adapter.send_async(request_info, nil, response_handler)
        end
        ## 
        ## The collection of multi-value extended properties defined for the message. Nullable.
        ## @param requestConfiguration Configuration for the request such as headers, query parameters, and middleware options.
        ## @param responseHandler Response handler to use in place of the default response handling provided by the core service
        ## @return a CompletableFuture of multi_value_legacy_extended_property
        ## 
        def get(request_configuration=nil, response_handler=nil)
            request_info = self.create_get_request_information(
                request_configuration
            )
            return @request_adapter.send_async(request_info, lambda {|pn| Graphrubyv4::Models::MultiValueLegacyExtendedProperty.create_from_discriminator_value(pn) }, response_handler)
        end
        ## 
        ## Update the navigation property multiValueExtendedProperties in users
        ## @param body The request body
        ## @param requestConfiguration Configuration for the request such as headers, query parameters, and middleware options.
        ## @param responseHandler Response handler to use in place of the default response handling provided by the core service
        ## @return a CompletableFuture of void
        ## 
        def patch(body, request_configuration=nil, response_handler=nil)
            raise StandardError, 'body cannot be null' if body.nil?
            request_info = self.create_patch_request_information(
                body, request_configuration
            )
            return @request_adapter.send_async(request_info, nil, response_handler)
        end

        ## 
        # Configuration for the request such as headers, query parameters, and middleware options.
        class MultiValueLegacyExtendedPropertyItemRequestBuilderDeleteRequestConfiguration
            
            ## 
            # Request headers
            attr_accessor :headers
            ## 
            # Request options
            attr_accessor :options
        end

        ## 
        # The collection of multi-value extended properties defined for the message. Nullable.
        class MultiValueLegacyExtendedPropertyItemRequestBuilderGetQueryParameters
            
            ## 
            # Expand related entities
            attr_accessor :expand
            ## 
            # Select properties to be returned
            attr_accessor :select
            ## 
            ## Maps the query parameters names to their encoded names for the URI template parsing.
            ## @param originalName The original query parameter name in the class.
            ## @return a string
            ## 
            def get_query_parameter(original_name)
                raise StandardError, 'original_name cannot be null' if original_name.nil?
                case original_name
                    when "expand"
                        return "%24expand"
                    when "select"
                        return "%24select"
                    else
                        return original_name
                end
            end
        end

        ## 
        # Configuration for the request such as headers, query parameters, and middleware options.
        class MultiValueLegacyExtendedPropertyItemRequestBuilderGetRequestConfiguration
            
            ## 
            # Request headers
            attr_accessor :headers
            ## 
            # Request options
            attr_accessor :options
            ## 
            # Request query parameters
            attr_accessor :query_parameters
        end

        ## 
        # Configuration for the request such as headers, query parameters, and middleware options.
        class MultiValueLegacyExtendedPropertyItemRequestBuilderPatchRequestConfiguration
            
            ## 
            # Request headers
            attr_accessor :headers
            ## 
            # Request options
            attr_accessor :options
        end
    end
end
