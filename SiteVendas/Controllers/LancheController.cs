using Microsoft.AspNetCore.Mvc;
using SiteVendas.Repositories.Interfaces;

namespace SiteVendas.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancherepository;

        public LancheController(ILancheRepository lancherepository)
        {
            _lancherepository = lancherepository;
        }

        public IActionResult List()
        {
            //var lanches = _lancherepository.Lanches;
            //return View(lanches);
            var lancheslistViewModel = new ViewModels.LancheListViewModel();
            lancheslistViewModel.Lanches = _lancherepository.Lanches;
            lancheslistViewModel.CategoriaAtual = "Categoria Atual";

            return View(lancheslistViewModel);
        }
    }
}
