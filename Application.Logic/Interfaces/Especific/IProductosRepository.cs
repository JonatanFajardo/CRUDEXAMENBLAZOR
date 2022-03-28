using Application.Entities.Entities;
using Application.Logic.Interfaces.Generals;

namespace Application.Logic.Interfaces.Especific
{
    public interface IProductosRepository : IGeneralRepository<tbProductos, PR_tbProductos_ListResult>
    {

    }
}
