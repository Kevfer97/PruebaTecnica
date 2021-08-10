using prueba.Domain.Context;
using prueba.Domain.Interfaces;
using prueba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prueba.Domain.Core
{
    public class UsuarioDomain : IUsuarioDomain
    {
        private readonly db_pruebaContext _context;

        public UsuarioDomain(db_pruebaContext context)
        {
            _context = context;
        }

        public UsuarioEntity Create(UsuarioEntity usuario)
        {
            UsuarioEntity Entity;
            try
            {
                Entity = _context.Usuario.Add(usuario).Entity;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Entity = null;
            }

            return Entity;
        }

        public string Delete(string usuario)
        {
            string deleted = "El Elemento no se pudo Eliminar";

            try
            {
                var toDelete = _context.Usuario.Find(usuario);
                _context.Usuario.Remove(toDelete);
                if (_context.SaveChanges() == 1)
                {
                    deleted = "Elemento Eliminado Corectamente";
                }
            }
            catch (Exception ex)
            {
                deleted = "El Elemento no se pudo Eliminar Error: "+ ex.Message;
            }

            return deleted;
        }

        public List<UsuarioEntity> GetAll()
        {
            var list = _context.Usuario.ToList();
            return list;
        }

        public UsuarioEntity GetByUsuario(string usuario)
        {
            var client = _context.Usuario.Find(usuario);
            return client;
        }

        public UsuarioEntity Update(UsuarioEntity usuario)
        {
            UsuarioEntity Entity;
            try
            {
                Entity = _context.Usuario.Update(usuario).Entity;
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
