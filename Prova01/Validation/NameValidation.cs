using System.ComponentModel.DataAnnotations;

public class NameValidationAttribute : ValidationAttribute
{
  protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
  {
    if (value == null)
    {
      return new ValidationResult("Nome não pode ser nulo!");
    }

    string id = value.ToString() ?? string.Empty;

    if (id.Length < 3 || id.Length > 50) return new ValidationResult("Nome Inválido!");
    if (!id.All(char.IsAscii)) return new ValidationResult("Nome Inválido!");

    return ValidationResult.Success;
  }
}