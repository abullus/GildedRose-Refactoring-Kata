using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class ConcertTicketsUpdaterTest
    {
        [Test]
        public void Backstage_Passes_Have_No_Quality_After_Date()
        {
            Item item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 0,
                Quality = 20
            };
            ConcertTicketsUpdater concertTicketsUpdater = new ConcertTicketsUpdater();
            concertTicketsUpdater.UpdateItem(item);
            Assert.AreEqual(0,item.Quality);
        }
        [Test]
        public void Backstage_Passes_Increase_Quality_Fast_Close_To_Date()
        {
            Item item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 3,
                Quality = 20
            };
            ConcertTicketsUpdater concertTicketsUpdater = new ConcertTicketsUpdater();
            concertTicketsUpdater.UpdateItem(item);
            Assert.AreEqual(23,item.Quality);
        }
        [Test]
        public void Backstage_Passes_SellIn_Decreases()
        {
            Item item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 3,
                Quality = 20
            };
            ConcertTicketsUpdater concertTicketsUpdater = new ConcertTicketsUpdater();
            concertTicketsUpdater.UpdateItem(item);
            Assert.AreEqual(2,item.SellIn );
        }
    }
}