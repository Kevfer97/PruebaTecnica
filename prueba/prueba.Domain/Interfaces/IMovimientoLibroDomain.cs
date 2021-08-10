using prueba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba.Domain.Interfaces
{
    public interface IMovimientoLibroDomain
    {
        List<MovimientoLibroEntity> GetAll();
        MovimientoLibroEntity GetById(int id);
        MovimientoLibroEntity Create(MovimientoLibroEntity movimiento);
        MovimientoLibroEntity Update(MovimientoLibroEntity movimiento);
        string Delete(int id);
    }
}
