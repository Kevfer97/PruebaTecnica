using prueba.Domain.Interfaces;
using prueba.Domain.Models;
using prueba.UseCase.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba.UseCase.Core
{
    public class ClienteUseCase : IClienteUseCase
    {
        private readonly IClienteDomain _domain;

        public ClienteUseCase(IClienteDomain domain)
        {
            _domain = domain;
        }

        public ClienteEntity Create(ClienteEntity cliente)
        {
            return _domain.Create(cliente);
        }

        public string Delete(int id)
        {
            return _domain.Delete(id);
        }

        public List<ClienteEntity> GetAll()
        {
            return _domain.GetAll();
        }

        public ClienteEntity GetById(int id)
        {
            return _domain.GetById(id);
        }

        public ClienteEntity Update(ClienteEntity cliente)
        {
            return _domain.Update(cliente);
        }
    }
}
