using prueba.Domain.Core;
using prueba.Domain.Interfaces;
using prueba.Domain.Models;
using prueba.UseCase.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba.UseCase.Core
{
    public class LibroUseCase: ILibroUseCase
    {
        private readonly LibroDomain _domain;

        public LibroUseCase(LibroDomain domain)
        {
            _domain = domain;
        }

        public LibroEntity Create(LibroEntity libro)
        {
            return _domain.Create(libro);
        }

        public string Delete(int id)
        {
            return _domain.Delete(id);
        }

        public List<LibroEntity> GetAll()
        {
            return _domain.GetAll();
        }

        public LibroEntity GetById(int id)
        {
            return _domain.GetById(id);
        }

        public LibroEntity Update(LibroEntity libro)
        {
            return _domain.Update(libro);
        }
    }
}
