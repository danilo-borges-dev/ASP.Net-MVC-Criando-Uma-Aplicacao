using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaAplicacaoMVC_3.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O Título precisa ter entre 3 ou 60 caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataDeLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""\w]*$", ErrorMessage = "Gênero em formato inválido")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres"), Required(ErrorMessage = "O campo Gênero é requirido")]
        public string Genero { get; set; }

        [Range(0.1, int.MaxValue, ErrorMessage = "Valode não pode ser menor OU igual a Zero")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "decimal(18,2")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Avaliação")]
        [RegularExpression(@"^[0+5]*$", ErrorMessage = "Somente números de 0 a 5")]
        public int Avaliacao { get; set; }
    }
}
