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
            for (int i = 0; i < Items.Count; i++)
            {
                var item = Items[i];
                var abstractItem = ItemFactory.CreateItem(item);

                abstractItem.UpdateItem();
                item.SellIn = abstractItem.SellIn;
                item.Quality = abstractItem.Quality;
            }
        }
    }
}
