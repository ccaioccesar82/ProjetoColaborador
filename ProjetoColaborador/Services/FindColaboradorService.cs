using ProjetoColaborador.Data.Repositories.Interfaces;
using ProjetoColaborador.Models.Entities;
using ProjetoColaborador.Services.ServicesInterfaces;

namespace ProjetoColaborador.Services
{
    public class FindColaboradorService: IFindColaboradorService
    {

        private readonly IReadColaboradorRepository _repository;


        public FindColaboradorService(IReadColaboradorRepository repository)
        {
            _repository = repository;

        }


        public async Task<IList<Colaborador>> FindAll()
        {

            return await _repository.SearchAllColaboradores();
        }



        public async Task<IList<Colaborador>?> FindWithName(string name)
        {


            return await _repository.SearchColaboradorByName(name);


        }

    }
}
