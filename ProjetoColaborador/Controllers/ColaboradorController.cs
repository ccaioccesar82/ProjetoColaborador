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
            , IEditColaboradorService editColaboradorService)
        {
            _findColaboradorService = findColaboradorService;
            _colaboradorCreateService = colaboradorCreateService;
            _editColaboradorService = editColaboradorService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var result = await _findColaboradorService.FindAll();



                ViewData["ColaboradoresLista"] = result;
                ViewData["ListadeCargos"] = await _findColaboradorService.FindCargos();

                return View();
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }



        [HttpPost]
        public async Task<IActionResult> Create(Colaborador request)
        {
            try
            {
                await _colaboradorCreateService.Execute(request);

                return RedirectToAction(nameof(Index));
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);


            }


        }


        public async Task<IActionResult> Edit(long Id)
        {
            try
            {
                var colaboradorResult = await _findColaboradorService.FindColaborador(Id);
             
                ViewData["ListadeCargos"] = await _findColaboradorService.FindCargos();

                return PartialView("_EditColaboradorPartialView", colaboradorResult);

            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);

            }
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Colaborador colaborador)
        {
            try
            {
                await _editColaboradorService.Execute(colaborador);

                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }
        }
    }
}
