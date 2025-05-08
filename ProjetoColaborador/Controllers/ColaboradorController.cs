using System.Data;
using Microsoft.AspNetCore.Mvc;
using ProjetoColaborador.Models.Entities;
using ProjetoColaborador.Services.ServicesInterfaces;

namespace ProjetoColaborador.Controllers
{
    public class ColaboradorController : Controller
    {

        private readonly IFindColaboradorService _findColaboradorService;
        private readonly IColaboradorCreateService _colaboradorCreateService;

        public ColaboradorController(IFindColaboradorService findColaboradorService, IColaboradorCreateService colaboradorCreateService)
        {
            _findColaboradorService = findColaboradorService;
            _colaboradorCreateService = colaboradorCreateService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _findColaboradorService.FindAll();



            ViewData["ColaboradoresLista"] = result;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Colaborador request)
        {

            await _colaboradorCreateService.Execute(request);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> SearchByName(string name)
        {
            
            ViewData["ColaboradorFiltrado"] = await _findColaboradorService.FindWithName(name);

            return RedirectToAction("Index");
        }



        public async Task<IActionResult> Update()
        {

            return RedirectToAction("Index");
        }
    }
}
