namespace csharp
{
    class Cheese : Category
    {
        public override void UpdateItem(Item item)
        {
            DecreaseSellIn(item);
            IncreaseQuality(item);
        }
    }
}