using PROVA_01_10.Validations;
using System.ComponentModel.DataAnnotations;

namespace PROVA_01_10.Models
{
    public class Turma
    {
        [Required(ErrorMessage = "Obrigatório")]
        [NomeValidation(ErrorMessage = "Erro Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string DescricaoCarne {  get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string DescricaoBebida {  get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [IdadeValidation(ErrorMessage = "Já é Maior de Idade")]
        public int Idade { get; set; }
    }
}
