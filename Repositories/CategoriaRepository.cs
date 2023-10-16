using InduMovel.Context;
using MaisSabor.Models;
using MaisSabor.Repositories.Interfaces;

namespace MaisSabor.Repositories
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