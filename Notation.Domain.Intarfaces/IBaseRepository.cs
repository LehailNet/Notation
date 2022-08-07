using System.Collections.Generic;
using System.Threading.Tasks;

namespace Notation.Domain.Intarfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task CreateAsync(T entity);

        Task<T> Get(int id);

        Task UpdateAsync(T entity);

        Task DeleteAsync(int id);

        Task<IEnumerable<T>> GetAll();

    }
}
