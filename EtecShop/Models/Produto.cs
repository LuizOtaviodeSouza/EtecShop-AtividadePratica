using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtecShop.Models;

[Table("Produto")]
public class Produto
{
    [Key]
    [DatabaseGenerated (DatabaseGeneratedOption.Identity) ]
    public int Id { get; set; }

    [Required (ErrorMessage = "Informe o nome do produto") ]
    [StringLength (100, ErrorMessage = "O nome deve possuir até 100 caracteres") ]
    public string Nome { get; set; }

    [Display (Name = "Descrição") ]
    [StringLength (1000, ErrorMessage = "A descrição deve possuir até 1.000 caracteres")]
    public string Descricao { get; set; }

    [Display (Name = "Preço") ]
    [Column (TypeName = "decimal(10,2)") ]
    [Required (ErrorMessage = "Informe o preço da venda") ]
    public decimal Preco { get; set; }

    [Display (Name = "Qtde. Estoque") ]
    [Required (ErrorMessage = "Informe a Qtde. em estoque") ]
    public int Estoque { get; set; }

    [Display (Name = "Categoria") ]
    [Required (ErrorMessage = "Informe a categoria") ]
    public int CategoriaId { get; set; }
    [ForeignKey ("CategoriaId") ]
    public Categoria Categoria { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }
}