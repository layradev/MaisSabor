using MaisSabor.Models;

namespace MaisSabor.Repositories.Interfaces
{
    public interface IItemRepository
    {
        IEnumerable<Item> Itens { get; }
        IEnumerable<Item>  ItensEmDestaque { get; }
        Item GetItemById(int ItemId);
    }
}