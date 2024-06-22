

namespace BoletosBus.WebApplication.Services
{
    public interface IBaseService<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task Save(T model);
        Task Update(T model);
        Task<T> Delete(int id);
    }
}
