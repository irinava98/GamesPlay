using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesPlay.Services
{
    public interface IGenericService<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);

        Task Add(T item);

        Task Update(T item);

        Task DeleteById(int id);

    }
}
