using prueba.Domain.Context;
using prueba.Domain.Interfaces;
using prueba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prueba.Domain.Core
{
    public class ReservaLibroDomain : IReservaLibroDomain
    {
        private readonly db_pruebaContext _context;

        public ReservaLibroDomain(db_pruebaContext context)
        {
            _context = context;
        }

        public ReservaLibroEntity Create(ReservaLibroEntity reserva)
        {
            ReservaLibroEntity Entity;
            try
            {
                Entity = _context.Reserva.Add(reserva).Entity;
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
                var toDelete = _context.Reserva.Find(id);
                _context.Reserva.Remove(toDelete);
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

        public List<ReservaLibroEntity> GetAll()
        {
            var list = _context.Reserva.ToList();
            return list;
        }

        public ReservaLibroEntity GetById(int id)
        {
            var obj = _context.Reserva.Find(id);
            return obj;
        }

        public ReservaLibroEntity Update(ReservaLibroEntity reserva)
        {
            ReservaLibroEntity Entity;
            try
            {
                Entity = _context.Reserva.Update(reserva).Entity;
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
