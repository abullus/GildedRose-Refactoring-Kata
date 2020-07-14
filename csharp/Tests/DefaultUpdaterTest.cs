using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class DefaultUpdaterTest
    {
        [Test]
        public void Quality_Decreases()
        {
            Item item = new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20};
            DefaultUpdater defaultUpdater = new DefaultUpdater();
            defaultUpdater.UpdateItem(item);
            Assert.AreEqual(19, item.Quality);
        }
        [Test]
        public void SellIn_Decreases()
        {
            Item item = new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20};
            DefaultUpdater defaultUpdater = new DefaultUpdater();
            defaultUpdater.UpdateItem(item);
            Assert.AreEqual(9, item.SellIn);
        }
        [Test]
        public void Quality_Decreases_By_Two_After_SellIn()
        {
            Item item = new Item {Name = "+5 Dexterity Vest", SellIn = -5, Quality = 20};
            DefaultUpdater defaultUpdater = new DefaultUpdater();
            defaultUpdater.UpdateItem(item);
            Assert.AreEqual(18, item.Quality);
        }
    }
}