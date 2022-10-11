namespace GildedRose;

public class ShopItemFactory{

    public static ShopItem CreateItem(Item item)
    {
        bool conjured = item.Name.Contains("Conjured");
        switch (item.Name) 
        {
            case string cheese when cheese.Contains("Aged Brie"): 
                return new AgedBrieItem(item, conjured);

            case string backstagePass when backstagePass.ToLower().Contains("backstage pass"): 
                return new BackstagePassItem(item, conjured);
                
            case string legendary when legendary.Contains("Sulfuras, Hand of Ragnaros"):
                return new LegendaryItem(item, conjured);
            
            default:
                return new BasicItem(item, conjured);
        }
    }
}