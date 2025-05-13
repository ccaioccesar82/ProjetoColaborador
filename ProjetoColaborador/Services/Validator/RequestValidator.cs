using ProjetoColaborador.Models.Entities;

namespace ProjetoColaborador.Services.Validator
{
    static class RequestValidator
    {

        public static void ValidateFields(ColaboradorDTO colaborador)
        {
            if(string.IsNullOrWhiteSpace(colaborador.Name) || string.IsNullOrWhiteSpace(colaborador.Email)
                || string.IsNullOrWhiteSpace(colaborador.Telefone))
            {

                throw new Exception("Todos os campos são obrigatórios");
            }

        }

    }
}
