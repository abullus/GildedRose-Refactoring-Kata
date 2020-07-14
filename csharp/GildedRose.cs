using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                categorize(item).UpdateItem(item);
            }
        }

        public Category categorize(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    return new Cheese();
                case "Sulfuras, Hand of Ragnaros":
                    return new Legendary();
                case "Conjured Mana Cake":
                    return new Conjured();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new ConcertTickets();
                default:
                    return new DefaultCategory();
            }
        }
    }
}