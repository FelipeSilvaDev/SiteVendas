using Microsoft.AspNetCore.Mvc;
using SiteVendas.Models;
using SiteVendas.Repositories;
using SiteVendas.Repositories.Interfaces;
using SiteVendas.ViewModels;

namespace SiteVendas.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancherepository)
        {
            _lancheRepository = lancherepository;
        }

        public IActionResult List(string categoria)
        {
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                lanches = _lancheRepository.Lanches
                          .Where(l => l.Categoria.CategoriaNome.Equals(categoria))
                          .OrderBy(c => c.Nome);

                categoriaAtual = categoria;
            }

            var lancheslistViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };

            return View(lancheslistViewModel);
        }
    }
}
