using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace prueba.Domain.Models
{
    [Table("tbl_cli_cliente")]
    public class ClienteEntity
    {
        [Key]
        [Column("cli_codigo")]
        public int Id { get; set; }
        [Column("cli_nombre")]
        public string Nombre { get; set; }
        [Column("cli_email")]
        public string Email { get; set; }
        [Column("cli_fecha_crea")]
        public DateTime? Fecha_crea { get; set; }
        [Column("cli_usuario_crea")]
        public string Usuario_crea { get; set; }
        [Column("cli_fecha_modifica")]
        public DateTime? Fecha_modifica { get; set; }
        [Column("cli_usuario_modifica")]
        public string Usuario_modifica { get; set; }
    }
}
