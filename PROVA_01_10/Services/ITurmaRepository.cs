using PROVA_01_10.Models;

namespace PROVA_01_10.Services
{
    public interface ITurmaRepository
    {
        public void Adicionar(Turma pessoa);
        public List<Turma> MostrarLista();

    }
}
