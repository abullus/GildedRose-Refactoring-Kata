using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class CheeseUpdaterTest
    {
        [Test]
        public void Aged_Brie_Quality_Increases()
        {
            Item item = new Item {Name = "Aged Brie", SellIn = 2, Quality = 0};
            CheeseUpdater cheeseUpdater = new CheeseUpdater();
            cheeseUpdater.UpdateItem(item);
            Assert.AreEqual(1,item.Quality );
        }
        [Test]
        public void Aged_Brie_Quality_Increases_Fast_After_SellIn()
        {
            Item item = new Item {Name = "Aged Brie", SellIn = -5, Quality = 0};
            CheeseUpdater cheeseUpdater = new CheeseUpdater();
            cheeseUpdater.UpdateItem(item);
            Assert.AreEqual(2,item.Quality );
        }
        [Test]
        public void Aged_Brie_SellIn_Decreases()
        {
            Item item = new Item {Name = "Aged Brie", SellIn = 2, Quality = 0};
            CheeseUpdater cheeseUpdater = new CheeseUpdater();
            cheeseUpdater.UpdateItem(item);
            Assert.AreEqual(1,item.SellIn );
        }
    }
}