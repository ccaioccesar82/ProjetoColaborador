using ProjetoColaborador.Models.Entities;

namespace ProjetoColaborador.Data.Repositories.Interfaces
{
    public interface IReadColaboradorRepository
    {
        Task<IList<ColaboradorDTO>> SearchAllColaboradores();
        public Task<IList<Colaborador>?> SearchColaboradorByName(string name);
        public Task<Colaborador> FindColaboradorById(long id);

        public Task<IList<Cargos>> FindAllCargos();

    }
}
