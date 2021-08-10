using prueba.Domain.Core;
using prueba.Domain.Models;
using prueba.UseCase.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba.UseCase.Core
{
   public class UsuarioUseCase: IUsuarioUseCase
    {
        private readonly UsuarioDomain _domain;

        public UsuarioUseCase(UsuarioDomain domain)
        {
            _domain = domain;
        }

        public UsuarioEntity Create(UsuarioEntity usuario)
        {
            return _domain.Create(usuario);
        }

        public string Delete(string usuario)
        {
            return _domain.Delete(usuario);
        }

        public List<UsuarioEntity> GetAll()
        {
            return _domain.GetAll();
        }

        public UsuarioEntity GetByUsuario(string usuario)
        {
            return _domain.GetByUsuario(usuario);
        }

        public UsuarioEntity Update(UsuarioEntity usuario)
        {
            return _domain.Update(usuario);
        }
    }
}
