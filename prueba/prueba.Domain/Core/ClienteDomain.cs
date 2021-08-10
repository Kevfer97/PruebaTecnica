using prueba.Domain.Context;
using prueba.Domain.Interfaces;
using prueba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prueba.Domain.Core
{
    public class ClienteDomain : IClienteDomain
    {
        private readonly db_pruebaContext _context;
        public ClienteDomain(db_pruebaContext context)
        {
            _context = context;
        }

        public ClienteEntity Create(ClienteEntity cliente)
        {
            ClienteEntity Entity;
            try
            {
                Entity = _context.Cliente.Add(cliente).Entity;
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
                var toDelete = _context.Cliente.Find(id);
                _context.Cliente.Remove(toDelete);
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


        public List<ClienteEntity> GetAll()
        {
            var list = _context.Cliente.ToList();
            return list;
        }

        public ClienteEntity GetById(int id)
        {
            var client = _context.Cliente.Find(id);
            return client;
        }

        public ClienteEntity Update(ClienteEntity cliente)
        {
            ClienteEntity Entity;
            try
            {
                Entity = _context.Cliente.Update(cliente).Entity;
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
