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
        private readonly IEditColaboradorService _editColaboradorService;


        public ColaboradorController(IFindColaboradorService findColaboradorService, IColaboradorCreateService colaboradorCreateService
            ,IEditColaboradorService editColaboradorService)
        {
            _findColaboradorService = findColaboradorService;
            _colaboradorCreateService = colaboradorCreateService;
            _editColaboradorService = editColaboradorService;
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
        public async Task<IActionResult> Edit(Colaborador colaborador)
        {
            try
            {
                await _editColaboradorService.Execute(colaborador);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);

            }
        }
    }
}
