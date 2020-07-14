using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class ItemUpdaterTest
    {
        [Test]
        public void Quality_Does_Not_Fall_Below_Zero()
        {
            Item item = new Item {Name = "Test product", SellIn = 5, Quality = 0};
            DefaultUpdater defaultUpdater = new DefaultUpdater();
            defaultUpdater.DecreaseQuality(item);
            Assert.AreEqual(0, item.Quality);
        }
        [Test]
        public void Quality_Does_Not_Increase_Above_Fifty()
        {
            Item item = new Item {Name = "Test product", SellIn = 5, Quality = 50};
            DefaultUpdater defaultUpdater = new DefaultUpdater();
            defaultUpdater.IncreaseQuality(item);
            Assert.AreEqual(50, item.Quality);
        }
    }
}