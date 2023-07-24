using System.ComponentModel.DataAnnotations;

namespace ProdutosApp.Services.Models
{
    /// <summary>
    /// Modelo de dados para edição de produto na API
    /// </summary>
    public class ProdutosPutModel
    {
        [Required(ErrorMessage = "Por favor, informe o id do produto desejado.")]
        public Guid? Id { get; set; }

        [MinLength(8, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do produto.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o preço do produto.")]
        public decimal? Preco { get; set; }

        [Required(ErrorMessage = "Por favor, informe a quantidade do produto.")]
        public int? Quantidade { get; set; }
    }
}



