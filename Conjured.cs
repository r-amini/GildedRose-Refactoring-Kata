using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Conjured : AbstractItem
    {
        public Conjured(int sellIn, int quality)
            : base("Conjured Mana Cake", sellIn, quality)
        {
        }

        public override void UpdateItem()
        {
            if (Quality > 0)
            {
                Quality = Quality.Increase(-2);
            }

            SellIn = SellIn.Increase(-1);

            if (SellIn < 0)
            {
                if (Quality > 0)
                {
                    Quality = Quality.Increase(-2);
                }
            }
        }
    }
}
