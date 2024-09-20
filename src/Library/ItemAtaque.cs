namespace Library;

public class ItemAtaque : IItemAtaque
{
    public string nombreItem
    {
        get;
        set;
    }

    public int valorAtaque
    {
        get;
        set;
    }

    public ItemAtaque(string nombreItem, int valorAtaque)
    {
        this.nombreItem = nombreItem;
        this.valorAtaque = valorAtaque;
    }

    public string NombreItem()
    {
        return nombreItem;
    }

    public int ValorAtaque()
    {
        return valorAtaque;
    }
}