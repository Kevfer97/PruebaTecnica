using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace prueba.Domain.Models
{
    [Table("tbl_rlb_reserva_libros")]
    public class ReservaLibroEntity
    {
        [Key]
        [Column("rbl_codigo")]
        public int Id { get; set; }
        [Column("rbl_codlib")]
        public int Id_libro { get; set; }
        [Column("rbl_codcli")]
        public int Id_cliente { get; set; }
        [Column("rbl_cantidad")]
        public int Cantidad { get; set; }
        [Column("rbl_estado")]
        public string Estado { get; set; }
        [Column("rbl_fecha_inicio")]
        public DateTime Fecha_inicio { get; set; }
        [Column("rbl_fecha_fin")]
        public DateTime Fecha_fin { get; set; }
        [Column("rbl_fecha_crea")]
        public DateTime? Fecha_crea { get; set; }
        [Column("rbl_usuario_crea")]
        public string Usuario_crea { get; set; }
        [Column("rbl_fecha_modifica")]
        public DateTime? Fecha_modifica { get; set; }
        [Column("rbl_usuario_modifica")]
        public string Usuario_modifica { get; set; }
    }
}
