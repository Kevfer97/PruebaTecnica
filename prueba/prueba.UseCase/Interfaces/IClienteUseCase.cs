using prueba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba.UseCase.Interfaces
{
    public interface IClienteUseCase
    {
        List<ClienteEntity> GetAll();
        ClienteEntity GetById(int id);
        ClienteEntity Create(ClienteEntity cliente);
        ClienteEntity Update(ClienteEntity cliente);
        string Delete(int id);
    }
}
