using prueba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba.Domain.Interfaces
{
    public interface IReservaLibroDomain
    {
        List<ReservaLibroEntity> GetAll();
        ReservaLibroEntity GetById(int id);
        ReservaLibroEntity Create(ReservaLibroEntity reserva);
        ReservaLibroEntity Update(ReservaLibroEntity reserva);
        string Delete(int id);
    }
}
