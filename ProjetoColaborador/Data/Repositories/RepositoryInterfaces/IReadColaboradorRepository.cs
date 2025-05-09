using ProjetoColaborador.Models.Entities;

namespace ProjetoColaborador.Data.Repositories.Interfaces
{
    public interface IReadColaboradorRepository
    {
        public Task<IList<Colaborador>> SearchAllColaboradores();
        public Task<IList<Colaborador>?> SearchColaboradorByName(string name);
        public Task<Colaborador?> FindColaboradorById(long id);

    }
}
