using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class ConjuredUpdaterTest
    {
        [Test]
        public void Conjured_Mana_Cake_Quality_Decreases_Fast()
        {
            Item item = new Item{Name = "Conjured Mana Cake", SellIn = 3, Quality = 6};
            ConjuredUpdater conjuredUpdater = new ConjuredUpdater();
            conjuredUpdater.UpdateItem(item);
            Assert.AreEqual(4,item.Quality);
        }
        [Test]
        public void Conjured_Mana_Cake_SellIn_Decreases()
        {
            Item item = new Item{Name = "Conjured Mana Cake", SellIn = 3, Quality = 6};
            ConjuredUpdater conjuredUpdater = new ConjuredUpdater();
            conjuredUpdater.UpdateItem(item);
            Assert.AreEqual(2,item.SellIn);
        }
    }
}