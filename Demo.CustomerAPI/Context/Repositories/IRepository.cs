namespace Demo.CustomerAPI.Context.Repositories
{
    public interface IRepository<T> where T : class 
    {
        Task<IList<T>> GetList();
        Task Add(T t);
        Task Delete(T t);
        Task Update(T t);
        Task<T> GetByID(int id);
    }
}
