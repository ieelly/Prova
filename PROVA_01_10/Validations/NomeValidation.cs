using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
namespace PROVA_01_10.Validations
{
    public class NomeValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(Object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Digite nome");
            }

            string nome = value.ToString();

            if (nome.Length >= 255)
            {
                return new ValidationResult("Nome ultrapassou olimite de caracteres");
            }

            if (nome.Length < 3)
            {
                return new ValidationResult("O Minímo deve ser 3 caracteres");
            }

            return ValidationResult.Success;
        }


    }
}
