using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Logic.Interfaces.Generals
{
    public interface IGeneralRepository<T, D>
    {
        Task<IEnumerable<D>> GetAll();
        Task<D> GetOne(int identifier);
        Task<Boolean> Insert(T entity);
        Task<Boolean> Update(T entity);
        Task<Boolean> Delete(int identifier);
    }
}
