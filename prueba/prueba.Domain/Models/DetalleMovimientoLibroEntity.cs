using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace prueba.Domain.Models
{
    [Table("tbl_dml_detalle_movimiento_libro")]
    public class DetalleMovimientoLibroEntity
    {
        [Key]
        [Column("dml_codigo")]
        public int Id { get; set; }
        [Column("dml_codmlb")]
        public int Id_movimiento { get; set; }
        [Column("dml_codlib")]
        public int Id_libro { get; set; }
        [Column("dml_cantidad")]
        public int Cantidad { get; set; }
        [Column("dml_precio_unitario")]
        public decimal Precio_unitario { get; set; }
        [Column("dml_fecha_crea")]
        public DateTime? Fecha_crea { get; set; }
        [Column("dml_usuario_crea")]
        public string Usuario_crea { get; set; }
        [Column("dml_fecha_modifica")]
        public DateTime? Fecha_modifica { get; set; }
        [Column("dml_usuario_modifica")]
        public string Usuario_modifica { get; set; }
    }
}
