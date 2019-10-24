using System.Collections.Generic;

namespace IdentityManager.Core
{
    public class UserDetail : UserSummary
    {
        public IEnumerable<PropertyValue> Properties { get; set; }
        public IEnumerable<ClaimValue> Claims { get; set; }
    }
}
