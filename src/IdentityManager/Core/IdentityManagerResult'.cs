namespace IdentityManager.Core
{
    public class IdentityManagerResult<T> : IdentityManagerResult
    {
        public T Result { get; private set; }

        public IdentityManagerResult(T result)
        {
            Result = result;
        }

        public IdentityManagerResult(params string[] errors)
            : base(errors)
        {
        }

    }
}
