using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaAplicacaoMVC_3.Models
{
    public class Filme_02
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O Títutlo precisa ter no mínimo de 03 caracteres e no máximo de 60 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        public DateTime DataDeLancamento { get; set; }

        [RegularExpression(@"[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Gênero em formato inválido")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres")]
        public string Genero { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "O valor não pode ser menor ou igual a zero")]
        [Column(TypeName = "decimal(18,2")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Preencha o campo de Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números de 1 a 5")]
        public int Avalicao { get; set; }
    }
}
