using ProjetoColaborador.Data.Repositories.Interfaces;
using ProjetoColaborador.Models.Entities;
using ProjetoColaborador.Services.ServicesInterfaces;

namespace ProjetoColaborador.Services
{
    public class FindColaboradorService: IFindColaboradorService
    {

        private readonly IReadColaboradorRepository _readColaboradorRepository;


        public FindColaboradorService(IReadColaboradorRepository repository)
        {
            _readColaboradorRepository = repository;

        }


        public async Task<IList<ColaboradorDTO>> FindAll()
        {

            return await _readColaboradorRepository.SearchAllColaboradores();
        }

        public async Task<IList<Cargos>> FindCargos()
        {
            return await _readColaboradorRepository.FindAllCargos();
        }

        public async Task<Colaborador> FindColaborador(long id)
        {
            var result = await _readColaboradorRepository.FindColaboradorById(id);

            if (result == null)
            {
                throw new Exception("Usuário não existe.");
            }

            return result;

        }



    }
}
