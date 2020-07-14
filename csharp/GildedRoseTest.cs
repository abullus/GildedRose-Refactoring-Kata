using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("fixme", Items[0].Name);
        }

        [Test]
        public void Sulfuras_Have_Constant_Quality()
        {
            IList<Item> Items = new List<Item> { new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80}};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(80,Items[0].Quality );
        }
        
        [Test]
        public void Sulfuras_Have_Constant_SellIn()
        {
            IList<Item> Items = new List<Item> { new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80}};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0,Items[0].SellIn );
        }
        
        [Test]
        public void Aged_Brie_Quality_Increases()
        {
            IList<Item> Items = new List<Item> { new Item {Name = "Aged Brie", SellIn = 2, Quality = 0}};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(1,Items[0].Quality );
        }
        
        [Test]
        public void Backstage_Passes_Have_No_Quality_After_Date()
        {
            IList<Item> Items = new List<Item> { new Item {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 0,
                Quality = 20
            }};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0,Items[0].Quality);
        }
        [Test]
        public void Backstage_Passes_Increase_Quality_Fast_Close_To_Date()
        {
            IList<Item> Items = new List<Item> { new Item {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 3,
                Quality = 20
            }};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(23,Items[0].Quality);
        }
        [Test]
        public void Conjured_Mana_Cake_Quality_Decreases_Fast()
        {
            IList<Item> Items = new List<Item> { new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(4,Items[0].Quality);
        }
        
        [Test]
        public void Quality_Decreases_By_One()
        {
            IList<Item> Items = new List<Item> { new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(19,Items[0].Quality);
        }
        [Test]
        public void SellIn_Decreases_By_One()
        {
            IList<Item> Items = new List<Item> { new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(9,Items[0].SellIn);
        }
        [Test]
        public void Quality_Does_Not_Fall_Below_Zero()
        {
            IList<Item> Items = new List<Item> { new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 0}};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0,Items[0].Quality);
        }
        [Test]
        public void Quality_Does_Not_Increase_Above_Fifty()
        {
            IList<Item> Items = new List<Item> { new Item {Name = "Aged Brie", SellIn = 10, Quality = 50}};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50,Items[0].Quality);
        }
        [Test]
        public void Quality_Decreases_By_Two_After_SellIn()
        {
            IList<Item> Items = new List<Item> { new Item {Name = "+5 Dexterity Vest", SellIn = -5, Quality = 20}};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(18,Items[0].Quality);
        }
    }
}
