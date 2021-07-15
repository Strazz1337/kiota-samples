using Graphdotnetv4.Users.InferenceClassification;
using Graphdotnetv4.Users.MailFolders;
using Graphdotnetv4.Users.Messages;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace Graphdotnetv4.Users.Item {
    /// <summary>Builds and executes requests for operations under \users\{user-id}</summary>
    public class UserRequestBuilder {
        /// <summary>Current path for the request</summary>
        public string CurrentPath { get; set; }
        /// <summary>Core service to use to execute the requests</summary>
        public IHttpCore HttpCore { get; set; }
        public InferenceClassificationRequestBuilder InferenceClassification { get =>
            new InferenceClassificationRequestBuilder { HttpCore = HttpCore, CurrentPath = CurrentPath + PathSegment };
        }
        public MailFoldersRequestBuilder MailFolders { get =>
            new MailFoldersRequestBuilder { HttpCore = HttpCore, CurrentPath = CurrentPath + PathSegment };
        }
        public MessagesRequestBuilder Messages { get =>
            new MessagesRequestBuilder { HttpCore = HttpCore, CurrentPath = CurrentPath + PathSegment };
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>
        /// Instantiates a new UserRequestBuilder and sets the default values.
        /// </summary>
        public UserRequestBuilder() {
            PathSegment = "";
        }
    }
}
