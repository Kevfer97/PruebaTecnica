using prueba.Domain.Core;
using prueba.Domain.Models;
using prueba.UseCase.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba.UseCase.Core
{
   public class ReservaLibroUseCase: IReservaLibroUseCase
    {
        private readonly ReservaLibroDomain _domain;

        public ReservaLibroUseCase(ReservaLibroDomain domain)
        {
            _domain = domain;
        }

        public ReservaLibroEntity Create(ReservaLibroEntity reserva)
        {
            return _domain.Create(reserva);
        }

        public string Delete(int id)
        {
            return _domain.Delete(id);
        }

        public List<ReservaLibroEntity> GetAll()
        {
            return _domain.GetAll();
        }

        public ReservaLibroEntity GetById(int id)
        {
            return _domain.GetById(id);
        }

        public ReservaLibroEntity Update(ReservaLibroEntity reserva)
        {
            return _domain.Update(reserva);
        }
    }
}
