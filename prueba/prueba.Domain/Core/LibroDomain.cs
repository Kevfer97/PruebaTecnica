using prueba.Domain.Context;
using prueba.Domain.Interfaces;
using prueba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prueba.Domain.Core
{
    public class LibroDomain : ILibroDomain
    {
        private readonly db_pruebaContext _context;

        public LibroDomain(db_pruebaContext context)
        {
            _context = context;
        }

        public LibroEntity Create(LibroEntity libro)
        {
            LibroEntity Entity;
            try
            {
                Entity = _context.Libro.Add(libro).Entity;
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
                var toDelete = _context.Libro.Find(id);
                _context.Libro.Remove(toDelete);
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

        public List<LibroEntity> GetAll()
        {
            var list = _context.Libro.ToList();
            return list;
        }

        public LibroEntity GetById(int id)
        {
            var obj = _context.Libro.Find(id);
            return obj;
        }

        public LibroEntity Update(LibroEntity libro)
        {
            LibroEntity Entity;
            try
            {
                Entity = _context.Libro.Update(libro).Entity;
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
