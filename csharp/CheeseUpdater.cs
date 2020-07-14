namespace csharp
{
    class CheeseUpdater : ItemUpdater
    {
        public override void UpdateItem(Item item)
        {
            DecreaseSellIn(item);
            IncreaseQuality(item);
            if (item.SellIn < 0)
            {
                IncreaseQuality(item);
            }
        }
    }
}