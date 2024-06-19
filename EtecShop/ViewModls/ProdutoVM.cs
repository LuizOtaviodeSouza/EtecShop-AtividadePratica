using System.ComponentModel.DataAnnotations;
using EtecShop.Models;

namespace EtecShop.ViewModels;

public class ProdutoVM
{
    public Produto Produto { get; set;}

    public List<Avaliacao> Avaliacoes { get; set; }

    [Required(ErrorMessage = "informe o nome")]
    [StringLength(60, ErrorMessage = "O nome deve possuir até 60 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "informe o título")]
    [StringLength(60, ErrorMessage = "O título deve possuir até 60 caracteres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "Escreva sua avaliação")]
    [StringLength(60, ErrorMessage = "O nome deve possuir até 300 caracteres")]
    public string Texto { get; set; }
}