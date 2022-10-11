namespace GildedRose;

public abstract class ShopItem 
{
    private readonly Item _item;
    private readonly bool _isConjured;
    protected int Quality {get => _item.Quality; set => _item.Quality = value; }
    protected int SellIn {get => _item.SellIn; set => _item.SellIn = value; }
    
    public ShopItem(Item item, bool isConjured)
    {
        _item = item;
        _isConjured = isConjured;
    }

    protected void IncrementQuality(int amount) 
    { 
        amount = _isConjured ? 2 * amount : amount;
        int value = Quality + amount; 
        value = Math.Max(value, 0);
        value = Math.Min(value, 50);
        Quality = value;
    }
    public void PassDay()
    {   
        UpdateQuality();
        SellIn--;
    }

    protected abstract void UpdateQuality();
}


