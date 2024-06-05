using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtecShop.Models;

[Table("Categoria")]
public class Categoria
{
    [Key]
    [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required (ErrorMessage = "Informe o nome da categoria")]
    [StringLength (30, ErrorMessage = "O nome deve possuir até 30 caracteres")]
    public string Nome {get; set; }
}