namespace GildedRose.Tests;

public class ProgramTests
{   
    Program app;
    public ProgramTests()
    {
        app = new Program()
                        {
                            Items = new List<Item>
                                    {
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 },
                                    }

                        };

    }
    [Fact]
    public void UpdateQuality_DexterityVestQualityDecrese_WhenSellinDecrese()
    {
        // arrange
       var app = new Program()
       {
            Items = new List<Item>
            {
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 }
            }
       };
       
        // act
        app.UpdateQuality();
        app.UpdateQuality();
        
        // assert
        app.Items[0].Quality.Should().Be(18);
    }

}