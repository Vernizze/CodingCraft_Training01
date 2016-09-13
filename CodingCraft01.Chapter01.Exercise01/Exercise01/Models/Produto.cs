using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercise01.Models
{
    [Table("produtos")]
    public class Produto
    {
        [Key]
        [Column("id")]
        public Guid ProdutoId { get; set; }

        [Required]
        [StringLength(150)]
        [Column("nome")]
        public string Nome { get; set; }

        [Required]
        [Column("valor")]
        public decimal Valor { get; set; }

        [Required]
        [Column("cardinalidade")]
        public int Cardinalidade { get; set; }


        public virtual Fornecedor Fornecedor { get; set; }
    }
}