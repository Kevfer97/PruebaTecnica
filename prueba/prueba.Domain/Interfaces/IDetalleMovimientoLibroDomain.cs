using prueba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba.Domain.Interfaces
{
    public interface IDetalleMovimientoLibroDomain
    {
        List<DetalleMovimientoLibroEntity> GetAll();
        DetalleMovimientoLibroEntity GetById(int id);
        DetalleMovimientoLibroEntity Create(DetalleMovimientoLibroEntity detalle);
        DetalleMovimientoLibroEntity Update(DetalleMovimientoLibroEntity detalle);
        string Delete(int id);
    }
}
