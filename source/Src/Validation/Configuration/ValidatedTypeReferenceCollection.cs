﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using System.Configuration;

namespace Microsoft.Practices.EnterpriseLibrary.Validation.Configuration
{
    /// <summary>
    /// Represents a collection of validation rulesets.
    /// </summary>
    /// <seealso cref="ValidatedPropertyReference"/>
    [ConfigurationCollection(typeof(ValidatedTypeReference), AddItemName = "type", ClearItemsName = "clear", RemoveItemName = "remove")]
    public class ValidatedTypeReferenceCollection : NamedElementCollection<ValidatedTypeReference>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ValidatedTypeReferenceCollection"/> class.</para>
        /// </summary>
        public ValidatedTypeReferenceCollection()
        {
            this.AddElementName = "type";
        }
    }
}
