using System;
using System.Collections.Generic;
using IdentityManager.Core.Metadata;
using IdentityManager.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace IdentityManager.Api.Models
{
    public class CreateUserLink : Dictionary<string, object>
    {
        public CreateUserLink(IUrlHelper url, UserMetadata userMetadata)
        {
            if (url == null) throw new ArgumentNullException(nameof(url));
            if (userMetadata == null) throw new ArgumentNullException(nameof(userMetadata));

            this["href"] = url.Link("CreateUser", null);
            this["meta"] = userMetadata.GetCreateProperties();
        }
    }
}