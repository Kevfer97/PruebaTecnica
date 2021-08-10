using prueba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba.UseCase.Interfaces
{
   public interface IUsuarioUseCase
    {
        List<UsuarioEntity> GetAll();
        UsuarioEntity GetByUsuario(string usuario);
        UsuarioEntity Create(UsuarioEntity usuario);
        UsuarioEntity Update(UsuarioEntity usuario);
        string Delete(string usuario);
    }
}
