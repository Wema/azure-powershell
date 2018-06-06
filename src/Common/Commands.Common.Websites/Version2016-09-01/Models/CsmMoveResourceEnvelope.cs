// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Version2016_09_01.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Object with a list of the resources that need to be moved and the
    /// resource group they should be moved to.
    /// </summary>
    public partial class CsmMoveResourceEnvelope
    {
        /// <summary>
        /// Initializes a new instance of the CsmMoveResourceEnvelope class.
        /// </summary>
        public CsmMoveResourceEnvelope()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CsmMoveResourceEnvelope class.
        /// </summary>
        public CsmMoveResourceEnvelope(string targetResourceGroup = default(string), IList<string> resources = default(IList<string>))
        {
            TargetResourceGroup = targetResourceGroup;
            Resources = resources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceGroup")]
        public string TargetResourceGroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<string> Resources { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetResourceGroup != null)
            {
                if (TargetResourceGroup.Length > 90)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "TargetResourceGroup", 90);
                }
                if (TargetResourceGroup.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "TargetResourceGroup", 1);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(TargetResourceGroup, " ^[-\\w\\._\\(\\)]+[^\\.]$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "TargetResourceGroup", " ^[-\\w\\._\\(\\)]+[^\\.]$");
                }
            }
        }
    }
}
