using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace prueba.Domain.Models
{
    [Table("tbl_usu_usuario")]
    public class UsuarioEntity
    {
        [Key]
        [Column("usu_usuario")]
        public string Usuario { get; set; }
        [Column("usu_nombre")]
        public string Nombre { get; set; }
        [Column("usu_clave")]
        public string Clave { get; set; }
        [Column("usu_fecha_crea")]
        public DateTime? Fecha_crea { get; set; }
        [Column("usu_usuario_crea")]
        public string Usuario_crea { get; set; }
        [Column("usu_fecha_modifica")]
        public DateTime? Fecha_modifica { get; set; }
        [Column("usu_usuario_modifica")]
        public string Usuario_modifica { get; set; }
    }
}
