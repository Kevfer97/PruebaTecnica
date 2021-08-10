using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using prueba.API.Controllers;
using prueba.Domain.Models;
using prueba.UseCase.Interfaces;
using System.Collections.Generic;

namespace prueba.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMetodoGetAllClientes()
        {
            var clienteUseCase = Substitute.For<IClienteUseCase>();
            List<ClienteEntity> obj = new List<ClienteEntity> { new ClienteEntity { Id = 1, Nombre = "Kevin", Email = "Kevin@gmail.com" },
            new ClienteEntity { Id = 1, Nombre = "Kevin", Email = "Kevin@gmail.com" }};

            clienteUseCase.GetAll().Returns(obj);

            ClienteController controlador = new ClienteController(clienteUseCase);
            var result = controlador.Get();
            Assert.AreEqual(result.Count, 2);
        }
    }
}
