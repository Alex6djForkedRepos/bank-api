// <auto-generated/>
#pragma warning disable CS0618
using DownstreamClients.GitHub.Repos.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace DownstreamClients.GitHub.Repos
{
    /// <summary>
    /// Builds and executes requests for operations under \repos
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ReposRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the DownstreamClients.GitHub.repos.item collection</summary>
        /// <param name="position">The account owner of the repository. The name is not case sensitive.</param>
        /// <returns>A <see cref="global::DownstreamClients.GitHub.Repos.Item.WithOwnerItemRequestBuilder"/></returns>
        public global::DownstreamClients.GitHub.Repos.Item.WithOwnerItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("owner", position);
                return new global::DownstreamClients.GitHub.Repos.Item.WithOwnerItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::DownstreamClients.GitHub.Repos.ReposRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReposRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::DownstreamClients.GitHub.Repos.ReposRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReposRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618