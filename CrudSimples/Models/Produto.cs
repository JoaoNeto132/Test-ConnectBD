using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudSimples.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código")]

        public int Id { get; set; }

        [Column("Descricao")]
        [Display(Name = "Descricao")]

        public string Name { get; set; }
    }
}
