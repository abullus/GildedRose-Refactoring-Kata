namespace csharp
{
    class Conjured : Category
    {
        public override void UpdateItem(Item item)
        {
            DecreaseQuality(item);
            DecreaseQuality(item);
            DecreaseSellIn(item);
        }
    }
}