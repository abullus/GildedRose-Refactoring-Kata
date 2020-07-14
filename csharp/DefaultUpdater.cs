namespace csharp
{
    public class DefaultUpdater : ItemUpdater
    {
        public override void UpdateItem(Item item)
        {
            DecreaseQuality(item);
            DecreaseSellIn(item);
            if (item.SellIn < 0)
            {
                DecreaseQuality(item);
            }
        }
    }
}