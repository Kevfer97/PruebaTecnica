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
    public class ReservaController : ControllerBase
    {
        private readonly ReservaLibroUseCase _UseCase;

        public ReservaController(ReservaLibroUseCase useCase)
        {
            _UseCase = useCase;
        }

        // GET: api/Reserva
        [HttpGet]
        public List<ReservaLibroEntity> Get()
        {
            return _UseCase.GetAll();
        }

        // GET: api/Reserva/5
        [HttpGet("{id}", Name = "Get")]
        public ReservaLibroEntity Get(int id)
        {
            return _UseCase.GetById(id);
        }

        // POST: api/Reserva
        [HttpPost]
        public ReservaLibroEntity Post([FromBody] ReservaLibroEntity value)
        {
            return _UseCase.Create(value);
        }

        // PUT: api/Reserva/5
        [HttpPut]
        public ReservaLibroEntity Put([FromBody] ReservaLibroEntity value)
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
