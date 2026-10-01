using System.ComponentModel.DataAnnotations;

public class UFValidationAttribute : ValidationAttribute
{
  protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
  {
    if (value == null)
    {
      return new ValidationResult("UF não pode ser nulo!");
    }

    string id = value.ToString() ?? string.Empty;

    if (id != "MG" && id != "SP" && id != "RJ" && id != "ES") return new ValidationResult("UF Inválido!");

    return ValidationResult.Success;
  }
}