using prueba.Domain.Interfaces;
using prueba.Domain.Models;
using prueba.UseCase.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba.UseCase.Core
{
    public class DetalleMovimientoLibroUseCase: IDetalleMovimientoLibroUseCase
    {
        private readonly IDetalleMovimientoLibroDomain _domain;

        public DetalleMovimientoLibroUseCase(IDetalleMovimientoLibroDomain domain)
        {
            _domain = domain;
        }

        public DetalleMovimientoLibroEntity Create(DetalleMovimientoLibroEntity detalle)
        {
            return _domain.Create(detalle);
        }

        public string Delete(int id)
        {
            return _domain.Delete(id);
        }

        public List<DetalleMovimientoLibroEntity> GetAll()
        {
            return _domain.GetAll();
        }

        public DetalleMovimientoLibroEntity GetById(int id)
        {
            return _domain.GetById(id);
        }

        public DetalleMovimientoLibroEntity Update(DetalleMovimientoLibroEntity detalle)
        {
            return _domain.Update(detalle);
        }
    }
}
