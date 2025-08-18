using SiteVendas.Context;
using SiteVendas.Models;
using SiteVendas.Repositories.Interfaces;

namespace SiteVendas.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
