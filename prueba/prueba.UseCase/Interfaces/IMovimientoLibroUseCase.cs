using prueba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba.UseCase.Interfaces
{
   public interface IMovimientoLibroUseCase
    {
        List<MovimientoLibroEntity> GetAll();
        MovimientoLibroEntity GetById(int id);
        MovimientoLibroEntity Create(MovimientoLibroEntity movimiento);
        MovimientoLibroEntity Update(MovimientoLibroEntity movimiento);
        string Delete(int id);
    }
}
