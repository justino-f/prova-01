namespace CascaApi.Models
{
  public class ListaTurno
  { 
    public Dictionary<string, int> eleitoresTurnos = new();
    public Dictionary<string, string> eleitoresJustificativas = new();

    public void RegistrarJustificativa(string cpf, int turno, string justificativa)
    {
      if (!eleitoresTurnos.ContainsKey(cpf)) {
        eleitoresTurnos.Add(cpf, turno);
        eleitoresJustificativas.Add(cpf, justificativa);
      }
    }

    public string ListarJustificativas()
    {
      return string.Join(Environment.NewLine, eleitoresJustificativas.Select(justificativa =>
        $"CPF: {justificativa.Key}, Justificativa: {justificativa.Value}"));
    }
  }
}
