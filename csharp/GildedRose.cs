using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> items)
        {
            this.Items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                categorizeItem(item).UpdateItem(item);
            }
        }

        public ItemUpdater categorizeItem(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    return new CheeseUpdater();
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryUpdater();
                case "Conjured Mana Cake":
                    return new ConjuredUpdater();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new ConcertTicketsUpdater();
                default:
                    return new DefaultUpdater();
            }
        }
    }
}