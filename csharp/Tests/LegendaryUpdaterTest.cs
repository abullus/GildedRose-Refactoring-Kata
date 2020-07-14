using System.Collections.Generic;
using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class LegendaryUpdaterTest
    {
        [Test]
        public void Sulfuras_Have_Constant_Quality()
        {
            Item item = new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80};
            LegendaryUpdater legendaryUpdater = new LegendaryUpdater();
            legendaryUpdater.UpdateItem(item);
            Assert.AreEqual(80,item.Quality );
        }
        
        [Test]
        public void Sulfuras_Have_Constant_SellIn()
        {
            Item item = new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80};
            LegendaryUpdater legendaryUpdater = new LegendaryUpdater();
            legendaryUpdater.UpdateItem(item);
            Assert.AreEqual(0,item.SellIn );
        }

    }
}