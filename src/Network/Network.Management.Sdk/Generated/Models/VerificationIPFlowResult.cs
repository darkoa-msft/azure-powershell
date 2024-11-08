// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Results of IP flow verification on the target resource.
    /// </summary>
    public partial class VerificationIPFlowResult
    {
        /// <summary>
        /// Initializes a new instance of the VerificationIPFlowResult class.
        /// </summary>
        public VerificationIPFlowResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VerificationIPFlowResult class.
        /// </summary>

        /// <param name="access">Indicates whether the traffic is allowed or denied.
        /// Possible values include: &#39;Allow&#39;, &#39;Deny&#39;</param>

        /// <param name="ruleName">Name of the rule. If input is not matched against any security rule, it is
        /// not displayed.
        /// </param>
        public VerificationIPFlowResult(string access = default(string), string ruleName = default(string))

        {
            this.Access = access;
            this.RuleName = ruleName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets indicates whether the traffic is allowed or denied. Possible values include: &#39;Allow&#39;, &#39;Deny&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "access")]
        public string Access {get; set; }

        /// <summary>
        /// Gets or sets name of the rule. If input is not matched against any security
        /// rule, it is not displayed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ruleName")]
        public string RuleName {get; set; }
    }
}