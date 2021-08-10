using prueba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba.Domain.Interfaces
{
    public interface ILibroDomain
    {
        List<LibroEntity> GetAll();
        LibroEntity GetById(int id);
        LibroEntity Create(LibroEntity libro);
        LibroEntity Update(LibroEntity libro);
        string Delete(int id);
    }
}
