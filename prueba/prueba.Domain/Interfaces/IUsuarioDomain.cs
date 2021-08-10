using prueba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba.Domain.Interfaces
{
    public interface IUsuarioDomain
    {
        List<UsuarioEntity> GetAll();
        UsuarioEntity GetByUsuario(string usuario);
        UsuarioEntity Create(UsuarioEntity usuario);
        UsuarioEntity Update(UsuarioEntity usuario);
        string Delete(string usuario);
    }
}
