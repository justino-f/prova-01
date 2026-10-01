
using CascaApi.Models;

namespace CascaApi.Repository
{
    public interface IEleitorRepository
    {
        public bool ConsultarEleitor(string CPF);
        public string ListarEleitores();
        public void IncluirEleitor(Eleitor eleitor);

    }
}
