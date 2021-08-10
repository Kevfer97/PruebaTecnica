using Microsoft.EntityFrameworkCore;
using prueba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba.Domain.Context
{
    public class db_pruebaContext : DbContext
    {
        public db_pruebaContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<UsuarioEntity> Usuario { get; set; }
        public DbSet<ClienteEntity> Cliente { get; set; }
        public DbSet<DetalleMovimientoLibroEntity> DetalleMovimiento { get; set; }
        public DbSet<LibroEntity> Libro { get; set; }
        public DbSet<MovimientoLibroEntity> Movimiento { get; set; }
        public DbSet<ReservaLibroEntity> Reserva { get; set; }

    }
}
