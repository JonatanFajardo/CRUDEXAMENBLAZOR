using Application.Logic.Interfaces.Especific;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Logic.Interfaces.Generals
{
    public interface IUnitOfWork
    {

        IProductosRepository Productos { get; }
        //ITipoProductosRepository TipoProductos { get; }
        //IUnidadMedidasRepository UnidadMedidas { get; }
    }
}
