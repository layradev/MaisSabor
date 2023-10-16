using MaisSabor.Models;
using Microsoft.EntityFrameworkCore;
namespace InduMovel.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<CarrinhoItem> CarrinhoItens{get; set;}
    }
}