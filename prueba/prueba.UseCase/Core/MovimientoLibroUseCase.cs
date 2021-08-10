using prueba.Domain.Core;
using prueba.Domain.Models;
using prueba.UseCase.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba.UseCase.Core
{
   public class MovimientoLibroUseCase: IMovimientoLibroUseCase
    {
        private readonly MovimientoLibroDomain _domain;

        public MovimientoLibroUseCase(MovimientoLibroDomain domain)
        {
            _domain = domain;
        }

        public MovimientoLibroEntity Create(MovimientoLibroEntity movimiento)
        {
            return _domain.Create(movimiento);
        }

        public string Delete(int id)
        {
            return _domain.Delete(id);
        }

        public List<MovimientoLibroEntity> GetAll()
        {
            return _domain.GetAll();
        }

        public MovimientoLibroEntity GetById(int id)
        {
            return _domain.GetById(id);
        }

        public MovimientoLibroEntity Update(MovimientoLibroEntity movimiento)
        {
            return _domain.Update(movimiento);
        }
    }
}
