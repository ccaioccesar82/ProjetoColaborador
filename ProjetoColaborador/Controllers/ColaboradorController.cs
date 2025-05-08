using Microsoft.AspNetCore.Mvc;
using ProjetoColaborador.Services.ServicesInterfaces;

namespace ProjetoColaborador.Controllers
{
    public class ColaboradorController : Controller
    {

        private readonly IFindColaboradorService _findColaboradorService;

        public ColaboradorController(IFindColaboradorService findColaboradorService)
        {
            _findColaboradorService = findColaboradorService;
        }

        public async Task<IActionResult> Index()
        {
            var resultList = await _findColaboradorService.FindAll();

            return View(resultList);
        }
    }
}
