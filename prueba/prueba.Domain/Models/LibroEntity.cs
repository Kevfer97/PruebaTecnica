using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace prueba.Domain.Models
{
    [Table("tbl_lib_libros")]
    public class LibroEntity
    {
        [Key]
        [Column("lib_codigo")]
        public int Id { get; set; }
        [Column("lib_nombre")]
        public string Nombre { get; set; }
        [Column("lib_autor")]
        public string Autor { get; set; }
        [Column("lib_descripcion")]
        public string Descripcion { get; set; }
        [Column("lib_stock")]
        public int Stock { get; set; }
        [Column("lib_precio")]
        public decimal Precio { get; set; }
        [Column("lib_fecha_crea")]
        public DateTime? Fecha_crea { get; set; }
        [Column("lib_usuario_crea")]
        public string Usuario_crea { get; set; }
        [Column("lib_fecha_modifica")]
        public DateTime? Fecha_modifica { get; set; }
        [Column("lib_usuario_modifica")]
        public string Usuario_modifica { get; set; }
    }
}
