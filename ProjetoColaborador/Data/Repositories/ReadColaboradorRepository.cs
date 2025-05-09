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

        public async Task<IList<Colaborador>> SearchAllColaboradores() => await _dbContext.Colaboradores.ToListAsync();


        public async Task<Colaborador?> FindColaboradorById(long id)
        {

           return await _dbContext.Colaboradores.SingleOrDefaultAsync(c => c.Id == id);

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

    }
}
