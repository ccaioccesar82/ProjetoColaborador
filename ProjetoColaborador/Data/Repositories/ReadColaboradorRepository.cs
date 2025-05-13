using Microsoft.EntityFrameworkCore;
using ProjetoColaborador.Data.Repositories.Interfaces;
using ProjetoColaborador.Models.Entities;

namespace ProjetoColaborador.Data.Repositories
{
    public class ReadColaboradorRepository : IReadColaboradorRepository
    {
        private readonly ColaboradorDbContext _dbContext;

        public ReadColaboradorRepository(ColaboradorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<ColaboradorResponseDTO>> SearchAllColaboradores() {


            var result = await (from co in _dbContext.Colaboradores
                          join ca in _dbContext.Cargos on co.CargoID equals ca.Id
                          select new ColaboradorResponseDTO
                          {
                              Id = co.Id,
                              Name = co.Name,
                              Email = co.Email,
                              Telefone = co.Telefone,
                              Cargo = ca.Name

                          }).ToListAsync();

            return result;
  
        }


        public async Task<Colaborador> FindColaboradorById(long id)
        {

           return await _dbContext.Colaboradores.SingleAsync(c => c.Id == id);

        }

        public async Task<IList<Colaborador>?> SearchColaboradorByName(string name)
        {
            var result = await _dbContext.Colaboradores.Where(c => c.Name == name).ToListAsync();

            if (result.Count == 0 )
            {
                return null;
            }

            return result;
        }

        public async Task<IList<Cargos>> FindAllCargos()
        {
            return await _dbContext.Cargos.OrderBy(cargos => cargos.Name).ToListAsync();
        }
    }
}
