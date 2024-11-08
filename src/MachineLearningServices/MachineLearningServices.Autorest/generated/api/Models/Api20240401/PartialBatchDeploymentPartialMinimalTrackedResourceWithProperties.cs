// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Strictly used in update requests.</summary>
    public partial class PartialBatchDeploymentPartialMinimalTrackedResourceWithProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPartialBatchDeploymentPartialMinimalTrackedResourceWithProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPartialBatchDeploymentPartialMinimalTrackedResourceWithPropertiesInternal
    {

        /// <summary>Description of the endpoint deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPartialBatchDeploymentInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPartialBatchDeploymentInternal)Property).Description = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPartialBatchDeployment Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPartialBatchDeploymentPartialMinimalTrackedResourceWithPropertiesInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.PartialBatchDeployment()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPartialBatchDeployment _property;

        /// <summary>Additional attributes of the entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPartialBatchDeployment Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.PartialBatchDeployment()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPartialBatchDeploymentPartialMinimalTrackedResourceWithPropertiesTags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPartialBatchDeploymentPartialMinimalTrackedResourceWithPropertiesTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.PartialBatchDeploymentPartialMinimalTrackedResourceWithPropertiesTags()); set => this._tag = value; }

        /// <summary>
        /// Creates an new <see cref="PartialBatchDeploymentPartialMinimalTrackedResourceWithProperties" /> instance.
        /// </summary>
        public PartialBatchDeploymentPartialMinimalTrackedResourceWithProperties()
        {

        }
    }
    /// Strictly used in update requests.
    public partial interface IPartialBatchDeploymentPartialMinimalTrackedResourceWithProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>Description of the endpoint deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the endpoint deployment.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPartialBatchDeploymentPartialMinimalTrackedResourceWithPropertiesTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPartialBatchDeploymentPartialMinimalTrackedResourceWithPropertiesTags Tag { get; set; }

    }
    /// Strictly used in update requests.
    internal partial interface IPartialBatchDeploymentPartialMinimalTrackedResourceWithPropertiesInternal

    {
        /// <summary>Description of the endpoint deployment.</summary>
        string Description { get; set; }
        /// <summary>Additional attributes of the entity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPartialBatchDeployment Property { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPartialBatchDeploymentPartialMinimalTrackedResourceWithPropertiesTags Tag { get; set; }

    }
}