using System.ComponentModel.DataAnnotations;
using IdentityManager.Resources;

namespace IdentityManager.Core
{
    public class  PropertyValue
    {
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "PropertyTypeRequired")]
        public string Type { get; set; }
        public string Value { get; set; }
    }
}
