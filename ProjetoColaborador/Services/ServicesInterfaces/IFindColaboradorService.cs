using ProjetoColaborador.Models.Entities;

namespace ProjetoColaborador.Services.ServicesInterfaces
{
    public interface IFindColaboradorService
    {
        public Task<IList<Colaborador>> FindAll();

        public Task<IList<Colaborador>?> FindWithName(string name);
    }
}
