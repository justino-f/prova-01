using System.ComponentModel.DataAnnotations;

public class CPFValidationAttribute : ValidationAttribute
{
  protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
  {
    if (value == null)
    {
      return new ValidationResult("CPF não pode ser nulo!");
    }

    string id = value.ToString() ?? string.Empty;

    if (!(id.Length == 11)) return new ValidationResult("CPF Inválido!");
    if (!id.All(char.IsDigit)) return new ValidationResult("CPF Inválido!");

    return ValidationResult.Success;
  }
}