namespace CascaApi.Models
{
  public class ListaEleitores
  {
    private readonly List<Eleitor> listaEleitores = new();

    public void IncluirEleitor(Eleitor eleitor)
    {
      if (ConsultarEleitor(eleitor.CPF))
      {
        throw new InvalidOperationException("Já existe um eleitor com este CPF.");
      }

      listaEleitores.Add(eleitor);
    }

    public string ListarEleitores()
    {
      return string.Join(Environment.NewLine, listaEleitores.Select(eleitor =>
        $"Nome: {eleitor.Nome}, CPF: {eleitor.CPF}, Título: {eleitor.Titulo}, UF: {eleitor.UF}"));
    }

    public bool ConsultarEleitor(string CPF)
    {
      return listaEleitores.Any(eleitor => eleitor.CPF == CPF);
    }
  }
}
