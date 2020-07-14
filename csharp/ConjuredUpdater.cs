namespace csharp
{
    class ConjuredUpdater : ItemUpdater
    {
        public override void UpdateItem(Item item)
        {
            DecreaseQuality(item);
            DecreaseQuality(item);
            DecreaseSellIn(item);
        }
    }
}