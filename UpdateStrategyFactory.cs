using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class UpdateStrategyFactory
    {
        public static IUpdateStrategy GetUpdateStrategy(string itemName)
        {
            switch (itemName)
            {
                case "Aged Brie":
                    return new AgedBrie();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagePasses();
                case "Sulfuras, Hand of Ragnaros":
                    return new Sulfuras();
                case "Conjured Mana Cake":
                    return new Conjured();
                default:
                   return new NormalItem();
            }
        }
    }
}
