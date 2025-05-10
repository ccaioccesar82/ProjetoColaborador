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

        public async Task Execute(Colaborador colaboradorRequest)
        {

            var colaboradorResult = await Validate(colaboradorRequest);

            colaboradorResult.Name = colaboradorRequest.Name;
            colaboradorResult.Email = colaboradorRequest.Email;
            colaboradorResult.Telefone = colaboradorRequest.Telefone;
            colaboradorResult.CargoId = colaboradorRequest.CargoId;

            await _writeColaboradorRepository.UpdateColaborador(colaboradorResult);

        }

        private async Task<Colaborador> Validate(Colaborador colaboradorRequest)
        {

            if(string.IsNullOrWhiteSpace(colaboradorRequest.Name) || string.IsNullOrWhiteSpace(colaboradorRequest.Email) ||
                string.IsNullOrWhiteSpace(colaboradorRequest.Telefone))
            {
                throw new Exception("Todos os campos são obrigatórios");

            }

           var result = await _readColaboradorRepository.FindColaboradorById(colaboradorRequest.Id);

            if (result == null)
            {
                throw new Exception("Usuário não existe.");
            }

            return result;

        }

    }
}
