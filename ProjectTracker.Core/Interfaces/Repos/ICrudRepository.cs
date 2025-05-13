using ProjectTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Interfaces.Repos
{

    //maybe is better to convert to using one generic interface like
    //this as all repos have the same 5 operations
    //given that the project is already set up using individule interfaces and that
    //understanding and implementing this change isn't hard just time consuming
    //maybe i leave as is for this project but use this approach next time.
    public interface ICrudRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task AddAsync(T model);
        Task UpdateAsync(T model);

    }
}
