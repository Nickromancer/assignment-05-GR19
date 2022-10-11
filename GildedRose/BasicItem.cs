namespace GildedRose;

public class BasicItem : ShopItem
{
    public BasicItem(Item item, bool isConjured) : base(item, isConjured)
    {

    }

    protected override void UpdateQuality()
    {  
        if(SellIn < 0)
        {
            IncrementQuality(-2);
        } else
        {
            IncrementQuality(-1);
        }
    }
}