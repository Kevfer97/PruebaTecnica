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
    public class DetalleMovimientoController : ControllerBase
    {
        private readonly IDetalleMovimientoLibroUseCase _UseCase;

        public DetalleMovimientoController(IDetalleMovimientoLibroUseCase useCase)
        {
            _UseCase = useCase;
        }

        // GET: api/DetalleMovimiento
        [HttpGet]
        public List<DetalleMovimientoLibroEntity> Get()
        {
            return _UseCase.GetAll();
        }

        // GET: api/DetalleMovimiento/5
        [HttpGet("{id}", Name = "Get")]
        public DetalleMovimientoLibroEntity Get(int id)
        {
            return _UseCase.GetById(id);
        }

        // POST: api/DetalleMovimiento
        [HttpPost]
        public DetalleMovimientoLibroEntity Post([FromBody] DetalleMovimientoLibroEntity value)
        {
            return _UseCase.Create(value);
        }

        // PUT: api/DetalleMovimiento/5
        [HttpPut]
        public DetalleMovimientoLibroEntity Put( [FromBody] DetalleMovimientoLibroEntity value)
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
