namespace ActivationApi.Models.Repos
{
    public interface IDeviceRepo<T> where T : class
    {
        IEnumerable<T> Get();
        void Add(T entity);
    }
}
