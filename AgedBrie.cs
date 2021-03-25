using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class AgedBrie : IUpdateStrategy
    {
        public (int updatedQuality, int updatedSellIn) UpdateQuality(int quality, int sellIn)
        {
            sellIn = sellIn.Increase(-1);

            if (quality < 50)
            {
                quality = quality.Increase(1);

                if (sellIn < 0 && quality < 50)
                {
                    quality = quality.Increase(1);
                }
            }

            return (quality, sellIn);
        }
    }
}
