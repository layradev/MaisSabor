namespace MaisSabor.Models;
public class Item{
    internal int ItemId;
    internal int itemId;

    public int Id {get; set;}

public string Nome {get; set;}

public string Descricao {get; set;}

public string DescricaoCurta {get; set;}

public string ImagemUrl {get; set;}

public string ImagemPequenaUrl {get; set;}

public double Preco {get; set;}

public  Boolean Ativo {get;set;}

public Boolean Destaque {get; set;}

public virtual Categoria Categoria {get; set;}

}