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


[Fact]
    public void UpdateQuality_AgedBrie_when_degraded_returns_increased_quality()
    {
        // arrange
       var app = new Program()
       {
            Items = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = 10, Quality = 20 },
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 20 },                
            }
       };
       
        // act
        app.UpdateQuality();
        app.UpdateQuality();
        
        // assert
        app.Items[0].Quality.Should().Be(22);
        app.Items[1].Quality.Should().Be(24);
    }
    [Fact]
    public void UpdateQuality_BackstagPass_increased_quality_based_on_SellIn()
    {
        // arrange
       var app = new Program()
       {
            Items = new List<Item>
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 40
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 40
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 40
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 1,
                    Quality = 40
                },   
            }
       };
       
        // act
        app.UpdateQuality();
        app.UpdateQuality();
        
        // assert
        app.Items[0].Quality.Should().Be(42);
        app.Items[1].Quality.Should().Be(44);
        app.Items[2].Quality.Should().Be(46);
        app.Items[3].Quality.Should().Be(0);

        
        
    }
    [Fact]
    public void UpdateQuality_Items_SellIn_decrease_by_1()
    {
        // arrange
       var app = new Program()
       {
            Items = new List<Item>
                {
                    new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 0 },
                    new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                    new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                    new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
                    new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 },
                    new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 },
                    new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49 },
                    new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 60 },
                    new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 60 }
                }
       };
       
        // act
        app.UpdateQuality();

        // assert
        app.Items[0].Name.Should().Be("+5 Dexterity Vest");
        app.Items[1].Name.Should().Be("Aged Brie");
        app.Items[2].Name.Should().Be("Elixir of the Mongoose");
        app.Items[3].Name.Should().Be("Sulfuras, Hand of Ragnaros");
        app.Items[4].Name.Should().Be("Sulfuras, Hand of Ragnaros");
        app.Items[5].Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");
        app.Items[6].Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");
        app.Items[7].Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");

        app.Items[0].SellIn.Should().Be(-1);
        app.Items[1].SellIn.Should().Be(1);
        app.Items[2].SellIn.Should().Be(4);
        app.Items[3].SellIn.Should().Be(0);
        app.Items[4].SellIn.Should().Be(-1);
        app.Items[5].SellIn.Should().Be(14);
        app.Items[6].SellIn.Should().Be(9);
        app.Items[7].SellIn.Should().Be(4);
    }
}