namespace IdentityManager.Configuration.Hosting
{
    public interface ITokenProvider<T>
    {
        string Generate(T model);
        T Validate(string data);
    }
}