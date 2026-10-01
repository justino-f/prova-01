using System.ComponentModel.DataAnnotations;

public class TituloValidationAttribute : ValidationAttribute
{
  protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
  {
    if (value == null)
    {
      return new ValidationResult("Titulo não pode ser nulo!");
    }

    string id = value.ToString() ?? string.Empty;

    if (id.Length < 3 || id.Length > 50) return new ValidationResult("Titulo Inválido!");
    if (!id.All(char.IsDigit)) return new ValidationResult("Titulo Inválido!");

    return ValidationResult.Success;
  }
}