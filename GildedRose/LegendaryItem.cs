namespace GildedRose;

public class LegendaryItem : ShopItem
{
    public LegendaryItem(Item item, bool isConjured) : base(item, isConjured)
    {
        
    }
    protected override void UpdateQuality()
    {
        //Because PassDay() Decreases SellIn with 1
        SellIn++;
    }
}