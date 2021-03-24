using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class AgedBrie : AbstractItem
    {
        public AgedBrie(int sellIn, int quality)
            : base("Aged Brie", sellIn, quality)
        {
        }

        public override void UpdateItem()
        {
            SellIn = SellIn.Increase(-1);

            if (Quality < 50)
            {
                Quality = Quality.Increase(1);

                if (SellIn < 0 && Quality < 50)
                {
                    Quality = Quality.Increase(1);
                }
            }
        }
    }
}
