using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace prueba.Domain.Models
{
    [Table("tbl_mlb_movimiento_libro")]
    public class MovimientoLibroEntity
    {
        [Key]
        [Column("mlb_codigo")]
        public int Id { get; set; }
        [Column("mlb_codcli")]
        public int Id_cliente { get; set; }
        [Column("mlb_tipo")]
        public string Tipo { get; set; }
        [Column("rbl_fecha_crea")]
        public DateTime? Fecha_crea { get; set; }
        [Column("mlb_usuario_crea")]
        public string Usuario_crea { get; set; }
        [Column("mlb_fecha_modifica")]
        public DateTime? Fecha_modifica { get; set; }
        [Column("mlb_usuario_modifica")]
        public string Usuario_modifica { get; set; }
    }
}
