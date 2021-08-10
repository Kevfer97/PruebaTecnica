using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prueba.Domain.Models;
using prueba.UseCase.Core;
using prueba.UseCase.Interfaces;

namespace prueba.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioUseCase _UseCase;

        public UsuarioController(UsuarioUseCase useCase)
        {
            _UseCase = useCase;
        }

        // GET: api/Usuario
        [HttpGet]
        public List<UsuarioEntity> Get()
        {
            return _UseCase.GetAll();
        }

        // GET: api/Usuario/5
        [HttpGet("{id}", Name = "Get")]
        public UsuarioEntity Get(string id)
        {
            return _UseCase.GetByUsuario(id);
        }

        // POST: api/Usuario
        [HttpPost]
        public UsuarioEntity Post([FromBody] UsuarioEntity value)
        {
            return _UseCase.Create(value);
        }

        // PUT: api/Usuario/5
        [HttpPut]
        public UsuarioEntity Put([FromBody] UsuarioEntity value)
        {
            return _UseCase.Update(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(string id)
        {
            return _UseCase.Delete(id);
        }
    }
}
