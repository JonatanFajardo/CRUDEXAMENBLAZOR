using Application.Logic.Interfaces.Especific;
using Application.Logic.Interfaces.Generals;
using Application.Logic.Repositories;
using System;

namespace Application.Logic
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(
            IProductosRepository productosRepository
            //ITipoProductosRepository tipoProductosRepository,
            //IUnidadMedidasRepository unidadMedidasRepository
            )
        {
            Productos = productosRepository;
            //TipoProductos = tipoProductosRepository;
            //UnidadMedidas = unidadMedidasRepository;
        }


        public IProductosRepository Productos { get; }

        public ITipoProductosRepository TipoProductos { get; }

        public IUnidadMedidasRepository UnidadMedidas { get; }
    }
}
