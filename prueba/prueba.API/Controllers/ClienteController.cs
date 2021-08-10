using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prueba.Domain.Models;
using prueba.UseCase.Interfaces;

namespace prueba.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteUseCase _UseCase;

        public ClienteController(IClienteUseCase useCase)
        {
            _UseCase = useCase;
        }

        // GET: api/Cliente
        [HttpGet]
        public List<ClienteEntity> Get()
        {
            return _UseCase.GetAll();
        }

        // GET: api/Cliente/5
        [HttpGet("{id}", Name = "Get")]
        public ClienteEntity Get(int id)
        {
            return _UseCase.GetById(id);
        }

        // POST: api/Cliente
        [HttpPost]
        public ClienteEntity Post([FromBody] ClienteEntity value)
        {
            return _UseCase.Create(value);
        }

        // PUT: api/Cliente/5
        [HttpPut]
        public ClienteEntity Put([FromBody] ClienteEntity value)
        {
            return _UseCase.Update(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _UseCase.Delete(id);
        }
    }
}
