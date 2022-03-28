using Application.Entities.Entities;
using Application.Logic.Interfaces.Especific;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Logic.Repositories
{
    public class ProductosRepository : BaseRepository, IProductosRepository
    {
        public Task<bool> Delete(int identifier)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PR_tbProductos_ListResult>> GetAll()
        {
            string sqlQuery = "PR_tbProductos_List";
            return await SelectAll<PR_tbProductos_ListResult>(sqlQuery);
        }

        public Task<PR_tbProductos_ListResult> GetOne(int identifier)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(tbProductos entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(tbProductos entity)
        {
            throw new NotImplementedException();
        }
    }
}
