using MaisSabor.Models;
namespace MaisSabor.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        public IEnumerable<Categoria> Categorias {get;}
    }
}