using ProjetoColaborador.Models.Entities;

namespace ProjetoColaborador.Services.ServicesInterfaces
{
    public interface IEditColaboradorService
    {
        public Task Execute(Colaborador colaborador);
    }
}
