using prueba.Domain.Context;
using prueba.Domain.Interfaces;
using prueba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prueba.Domain.Core
{
    public class DetalleMovimientoLibroDomain : IDetalleMovimientoLibroDomain
    {
        private readonly db_pruebaContext _context;

        public DetalleMovimientoLibroDomain(db_pruebaContext context)
        {
            _context = context;
        }

        public DetalleMovimientoLibroEntity Create(DetalleMovimientoLibroEntity detalle)
        {
            DetalleMovimientoLibroEntity Entity;
            try
            {
                Entity = _context.DetalleMovimiento.Add(detalle).Entity;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Entity = null;
            }

            return Entity;
        }

        public string Delete(int id)
        {
            string deleted = "El Elemento no se pudo Eliminar";

            try
            {
                var toDelete = _context.DetalleMovimiento.Find(id);
                _context.DetalleMovimiento.Remove(toDelete);
                if (_context.SaveChanges() == 1)
                {
                    deleted = "Elemento Eliminado Corectamente";
                }
            }
            catch (Exception ex)
            {
                deleted = "El Elemento no se pudo Eliminar Error: " + ex.Message;
            }

            return deleted;
        }
    

        public List<DetalleMovimientoLibroEntity> GetAll()
        {
        var list = _context.DetalleMovimiento.ToList();
        return list;
        }

        public DetalleMovimientoLibroEntity GetById(int id)
        {
            var obj = _context.DetalleMovimiento.Find(id);
            return obj;
        }

        public DetalleMovimientoLibroEntity Update(DetalleMovimientoLibroEntity detalle)
        {
            DetalleMovimientoLibroEntity Entity;
            try
            {
                Entity = _context.DetalleMovimiento.Update(detalle).Entity;
                _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Entity = null;
            }

            return Entity;
        }
    }
}
