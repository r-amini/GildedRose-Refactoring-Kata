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
                UpdateItem(item);
            }
        }

        private void UpdateItem(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    UpdateAgedBrie(item);
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    UpdateBackstagePasses(item);
                    break;
                case "Sulfuras, Hand of Ragnaros":
                    UpdateSulfuras(item);
                    break;
                default:
                    UpdateNormalItem(item);
                    break;
            }
        }

        private void UpdateAgedBrie(Item item)
        {
            item.SellIn = item.SellIn - 1;

            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;

                if (item.SellIn < 0 && item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }
        }

        private void UpdateBackstagePasses(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;

                if (item.Quality < 50)
                {
                    if (item.SellIn < 11)
                    {
                        item.Quality = item.Quality + 1;
                    }
                    if (item.SellIn < 6)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }

                item.SellIn = item.SellIn - 1;

                if (item.SellIn < 0)
                {
                    item.Quality = item.Quality - item.Quality;
                }
            }
            else
            {
                item.SellIn = item.SellIn - 1;

                if (item.SellIn < 0)
                {
                    item.Quality = item.Quality - item.Quality;
                }
            }
        }

        private void UpdateSulfuras(Item item)
        {
            // Do nothing
        }

        private void UpdateNormalItem(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Quality > 0)
                {
                    item.Quality = item.Quality - 1;
                }
            }
        }
    }
}
