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
    public class LibroController : ControllerBase
    {
        private readonly LibroUseCase _UseCase;

        public LibroController(LibroUseCase useCase)
        {
            _UseCase = useCase;
        }

        // GET: api/Libro
        [HttpGet]
        public List<LibroEntity> Get()
        {
            return _UseCase.GetAll();
        }

        // GET: api/Libro/5
        [HttpGet("{id}", Name = "Get")]
        public LibroEntity Get(int id)
        {
            return _UseCase.GetById(id);
        }

        // POST: api/Libro
        [HttpPost]
        public LibroEntity Post([FromBody] LibroEntity value)
        {
            return _UseCase.Create(value);
        }

        // PUT: api/Libro/5
        [HttpPut]
        public LibroEntity Put( [FromBody] LibroEntity value)
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
