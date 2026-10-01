using CascaApi.Models;

namespace CascaApi.Repository
{
    public class EleitorRepository : IEleitorRepository
    {
        private readonly ListaEleitores _listaEleitores;

        public EleitorRepository(ListaEleitores listaEleitores)
        {
            _listaEleitores = listaEleitores;
        }
        public bool ConsultarEleitor(string CPF)
        {
            return _listaEleitores.ConsultarEleitor(CPF);
        }
        public string ListarEleitores()
        {
            return _listaEleitores.ListarEleitores();
        }
        public void IncluirEleitor(Eleitor eleitor)
        {
            _listaEleitores.IncluirEleitor(eleitor);
        }
    }
}
