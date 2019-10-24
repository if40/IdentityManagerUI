using System.Threading.Tasks;

namespace IdentityManager.Core.Metadata
{
    public abstract class AsyncExecutablePropertyMetadata : PropertyMetadata
    {
        public abstract Task<string> Get(object instance);
        public abstract Task<IdentityManagerResult> Set(object instance, string value);
    }
}