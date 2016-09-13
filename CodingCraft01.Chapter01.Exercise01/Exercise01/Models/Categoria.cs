using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercise01.Models
{
    [Table("categorias")]
    public class Categoria
    {
        [Key]
        [Column("id")]
        public Guid CAtegoriaId { get; set; }

        [Required]
        [StringLength(150)]
        [Column("descricao")]
        public string Descricao { get; set; }
    }
}