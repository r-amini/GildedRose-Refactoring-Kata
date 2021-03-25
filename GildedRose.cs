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
                var updateStrategy = UpdateStrategyFactory.GetUpdateStrategy(item.Name);
                (item.Quality, item.SellIn) = updateStrategy.UpdateQuality(item.Quality, item.SellIn);
            }
        }
    }
}
