using ProjetoColaborador.Models.Entities;

namespace ProjetoColaborador.Data.Repositories.Interfaces
{
    public interface IReadColaboradorRepository
    {
        Task<IList<ColaboradorResponseDTO>> SearchAllColaboradores();
        public Task<IList<Colaborador>?> SearchColaboradorByName(string name);
        public Task<Colaborador> FindColaboradorById(long id);

        public Task<IList<Cargos>> FindAllCargos();

    }
}
