namespace GildedRose;

public class BackstagePassItem : ShopItem
{
    public BackstagePassItem(Item item, bool isConjured) : base(item, isConjured)
    {
        
    }
    protected override void UpdateQuality()
    {
        if (SellIn <= 0) 
        {
            Quality = 0;
        }
        else if (SellIn <= 5)
        {
            IncrementQuality(3);
        }
        else if(SellIn <= 10)
        {
            IncrementQuality(2);
        }
        else
        {
            IncrementQuality(1);
        }
    }
}   