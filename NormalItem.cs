using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class NormalItem : IUpdateStrategy
    {
        public (int updatedQuality, int updatedSellIn) UpdateQuality(int quality, int sellIn)
        {
            if (quality > 0)
            {
                quality = quality.Increase(-1);
            }

            sellIn = sellIn.Increase(-1);

            if (sellIn < 0)
            {
                if (quality > 0)
                {
                    quality = quality.Increase(-1);
                }
            }

            return (quality, sellIn);
        }
    }
}
