using prueba.Domain.Context;
using prueba.Domain.Interfaces;
using prueba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prueba.Domain.Core
{
    public class MovimientoLibroDomain : IMovimientoLibroDomain
    {
        private readonly db_pruebaContext _context;

        public MovimientoLibroDomain(db_pruebaContext context)
        {
            _context = context;
        }

        public MovimientoLibroEntity Create(MovimientoLibroEntity movimiento)
        {
            MovimientoLibroEntity Entity;
            try
            {
                Entity = _context.Movimiento.Add(movimiento).Entity;
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
                var toDelete = _context.Movimiento.Find(id);
                _context.Movimiento.Remove(toDelete);
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

        public List<MovimientoLibroEntity> GetAll()
        {
            var list = _context.Movimiento.ToList();
            return list;
        }

        public MovimientoLibroEntity GetById(int id)
        {
            var obj = _context.Movimiento.Find(id);
            return obj;
        }

        public MovimientoLibroEntity Update(MovimientoLibroEntity movimiento)
        {
            MovimientoLibroEntity Entity;
            try
            {
                Entity = _context.Movimiento.Update(movimiento).Entity;
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
