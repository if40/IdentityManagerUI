using System;
using System.Collections.Generic;
using System.Linq;
using IdentityManager.Core.Metadata;
using IdentityManager.Resources;

namespace IdentityManager.Extensions
{
    public static class UserMetadataExtensions
    {
        public static IEnumerable<PropertyMetadata> GetCreateProperties(this UserMetadata userMetadata)
        {
            if (userMetadata == null) throw new ArgumentNullException("GetCreateProperties::userMetadata " + ExceptionMessages.IsNotAssigned);

            var exclude = userMetadata.CreateProperties.Select(x => x.Type);
            var additional = userMetadata.UpdateProperties.Where(x => !exclude.Contains(x.Type) && x.Required);
            return userMetadata.CreateProperties.Union(additional);
        }
    }
}
