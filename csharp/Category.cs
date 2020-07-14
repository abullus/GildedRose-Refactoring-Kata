namespace csharp
{
    public abstract class Category
    {
        public void IncreaseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;
            }
        }

        public void DecreaseQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality--;
            }
        }

        public void DecreaseSellIn(Item item)
        {
            item.SellIn--;
        }

        public abstract void UpdateItem(Item item);
    }
}