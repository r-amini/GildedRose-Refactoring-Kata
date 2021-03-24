using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class ItemFactory
    {
        public static AbstractItem CreateItem(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    return new AgedBrie(item.SellIn, item.Quality);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagePasses(item.SellIn, item.Quality);
                case "Sulfuras, Hand of Ragnaros":
                    return new Sulfuras(item.SellIn, item.Quality);
                case "Conjured Mana Cake":
                    return new Conjured(item.SellIn, item.Quality);
                default:
                   return new NormalItem(item.Name, item.SellIn, item.Quality);
            }
        }
    }
}
