using System.Collections.Generic;

namespace IdentityManager.Core
{
    public class RoleDetail : RoleSummary
    {
        public IEnumerable<PropertyValue> Properties { get; set; }
    }
}
