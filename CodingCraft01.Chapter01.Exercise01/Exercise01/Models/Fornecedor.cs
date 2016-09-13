using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercise01.Models
{
    [Table("fornecedores")]
    public class Fornecedor
    {
        [Key]
        [Column("id")]
        public Guid FornecdorId { get; set; }

        [Required]
        [StringLength(150)]
        [Column("nome")]
        public string Nome { get; set; }
    }
}