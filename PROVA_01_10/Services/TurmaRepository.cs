using PROVA_01_10.Models;
namespace PROVA_01_10.Services
{
    public class TurmaRepository : ITurmaRepository
    {
        private static List<Turma> listaTurma = new List<Turma>();

        public TurmaRepository() { }

        public void Adicionar(Turma pessoa)
        {
            listaTurma.Add(pessoa);
        }
        public List<Turma> MostrarLista()
        {
            return listaTurma;
        }

    }
}
