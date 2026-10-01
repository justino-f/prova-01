using System.ComponentModel.DataAnnotations;
namespace CascaApi.Models
{
    public class Eleitor
    {
        [NameValidationAttribute(ErrorMessage="Nome Inválido!")]
        public string Nome { get; set; }

        [UFValidationAttribute(ErrorMessage="UF Inválido!")]

        public string UF { get; set; }
        [CPFValidationAttribute(ErrorMessage="CPF Inválido!")]
        public string CPF { get; set; }

        [TituloValidationAttribute(ErrorMessage="Titulo Inválido!")]
        public string Titulo { get; set; }

        public Eleitor(string nome, string UF, string CPF, string titulo)
        {
            this.Nome = nome;
            this.UF = UF;
            this.CPF = CPF;
            this.Titulo = titulo;
        }
    }
}
