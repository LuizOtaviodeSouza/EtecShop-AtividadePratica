using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtecShop.Models;

[Table ("Avaliacao") ]
public class Avaliacao
{
    [Key]
    [DatabaseGenerated (DatabaseGeneratedOption.Identity) ]
    public int Id { get; set; }

    [Required (ErrorMessage = "Informe o nome") ]
    [StringLength (60, ErrorMessage = "O título deve possuir até 60 caracteres") ]
    public string Titul { get; set; }

    [Required (ErrorMessage = "Escreva sua Avaliação") ]
    [StringLength (300, ErrorMessage = "A avaliação de possuir no máximo 300 caracteres") ]
    public string Texto { get; set; }

    [Display (Name = "Data da avaliação") ]
    public DateTime DataAvaliacao { get; set; } = DateTime.Now;

    [Display (Name = "Produto") ]
    [Required (ErrorMessage = "Informe o produto") ]
    public int ProdutoId { get; set; }
    [ForeignKey ("ProdutoId") ]
    public Produto Produto { get; set; }
}