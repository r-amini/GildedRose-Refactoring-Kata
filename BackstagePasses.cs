using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class BackstagePasses : AbstractItem
    {
        public BackstagePasses(int sellIn, int quality)
            : base("Backstage passes to a TAFKAL80ETC concert", sellIn, quality)
        {
        }

        public override void UpdateItem()
        {
            if (Quality < 50)
            {
                Quality = Quality.Increase(1);

                if (Quality < 50)
                {
                    if (SellIn < 11)
                    {
                        Quality = Quality.Increase(1);
                    }
                    if (SellIn < 6)
                    {
                        Quality = Quality.Increase(1);
                    }
                }

                SellIn = SellIn.Increase(-1);

                if (SellIn < 0)
                {
                    Quality = Quality - Quality;
                }
            }
            else
            {
                SellIn = SellIn.Increase(-1);

                if (SellIn < 0)
                {
                    Quality = Quality - Quality;
                }
            }
        }
    }
}
