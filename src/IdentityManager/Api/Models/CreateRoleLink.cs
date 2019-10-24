using System;
using System.Collections.Generic;
using IdentityManager.Core;
using IdentityManager.Core.Metadata;
using IdentityManager.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace IdentityManager.Api.Models
{
    public class CreateRoleLink : Dictionary<string, object>
    {
        public CreateRoleLink(IUrlHelper url, RoleMetadata roleMetadata)
        {
            if (url == null) throw new ArgumentNullException(nameof(url));
            if (roleMetadata == null ) throw new ArgumentNullException(nameof(roleMetadata));

            this["href"] = url.Link(Constants.RouteNames.CreateRole, null);
            this["meta"] = roleMetadata.GetCreateProperties();
        }
    }
}
