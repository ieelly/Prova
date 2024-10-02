using System.ComponentModel.DataAnnotations;

namespace PROVA_01_10.Validations
{
    public class IdadeValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(Object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult(ErrorMessage);
            }

            int idade = (int)value;

            return idade < 18 ? ValidationResult.Success : new ValidationResult(ErrorMessage);
        }
    }
}
