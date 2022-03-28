using Application.Entities.Entities;
using Application.Logic.Interfaces.Generals;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Business.Services
{
    public class ProductosServices
    {
        private IUnitOfWork _unitOfWork;
        public ProductosServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<PR_tbProductos_ListResult[]> GetAll()
        {
            try
            {
                var resultRepo = await _unitOfWork.Productos.GetAll();
                return resultRepo.ToArray();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<PR_tbProductos_ListResult> GetOne()
        {
            try
            {
                var resultRepo = await _unitOfWork.Productos.GetAll();
                return resultRepo.FirstOrDefault();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<Boolean> Add(tbProductos entity)
        {

            throw new NotImplementedException();
        }

        public async Task<Boolean> Edit(tbProductos entity)
        {

            throw new NotImplementedException();
        }

        public async Task<Boolean> Remove(int id)
        {

            throw new NotImplementedException();
        }
    }
}
