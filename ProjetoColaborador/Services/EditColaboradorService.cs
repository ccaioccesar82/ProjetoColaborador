using ProjetoColaborador.Data.Repositories.Interfaces;
using ProjetoColaborador.Models.Entities;
using ProjetoColaborador.Services.ServicesInterfaces;

namespace ProjetoColaborador.Services
{
    public class EditColaboradorService: IEditColaboradorService
    {
        private readonly IReadColaboradorRepository _readColaboradorRepository;
        private readonly IWriteColaboradorRepository _writeColaboradorRepository;


        public EditColaboradorService(IReadColaboradorRepository readColaboradorRepository, IWriteColaboradorRepository writeColaboradorRepository)
        {
            _readColaboradorRepository = readColaboradorRepository;
            _writeColaboradorRepository = writeColaboradorRepository;

        }

        public async Task Execute(Colaborador colaborador)
        {
           var colaboradorSearched = await Validate(colaborador.Id);

            colaboradorSearched.Name = colaborador.Name;
            colaboradorSearched.Email = colaborador.Email;
            colaboradorSearched.Telefone = colaborador.Telefone;
            colaboradorSearched.CargoId = colaborador.CargoId;

            await _writeColaboradorRepository.UpdateColaborador(colaboradorSearched);

        }

        private async Task<Colaborador> Validate(long id)
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
