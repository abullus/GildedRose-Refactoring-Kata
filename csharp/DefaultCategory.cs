namespace csharp
{
    public class DefaultCategory : Category
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