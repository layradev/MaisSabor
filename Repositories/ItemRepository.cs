using InduMovel.Context;
using MaisSabor.Models;
using MaisSabor.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace InduMovel.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _context;
        public ItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Item> Itens => _context.Items.Include(c =>
        c.Categoria);
        public IEnumerable<Item> ItensEmDestaque =>
        _context.Items.Where(m => m.Destaque).Include(c => c.Categoria);
        public Item GetItemById(int ItemId)
        {
            return _context.Items.FirstOrDefault(m => m.Id == ItemId);
        }
    }



}