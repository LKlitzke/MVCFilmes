using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFilmes.Models
{
    public class Filmes
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }
        public string Genero { get; set; } = string.Empty;
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18,2)")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        public int? Pontos { get; set; }
    }
}
