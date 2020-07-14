namespace csharp
{
    public class ConcertTicketsUpdater : ItemUpdater
    {
        public override void UpdateItem(Item item)
        {
            DecreaseSellIn(item);
            if (item.SellIn < 10 && item.SellIn >= 5)
            {
                IncreaseQuality(item);
                IncreaseQuality(item);
            }

            else if (item.SellIn < 5 && item.SellIn >= 0)
            {
                IncreaseQuality(item);
                IncreaseQuality(item);
                IncreaseQuality(item);
            }
            else if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else
            {
                IncreaseQuality(item);
            }
        }
    }
}