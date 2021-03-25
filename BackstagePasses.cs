using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class BackstagePasses : IUpdateStrategy
    {
        public (int updatedQuality, int updatedSellIn) UpdateQuality(int quality, int sellIn)
        {
            if (quality < 50)
            {
                quality = quality.Increase(1);

                if (quality < 50)
                {
                    if (sellIn < 11)
                    {
                        quality = quality.Increase(1);
                    }
                    if (sellIn < 6)
                    {
                        quality = quality.Increase(1);
                    }
                }

                sellIn = sellIn.Increase(-1);

                if (sellIn < 0)
                {
                    quality = quality.Increase(-1 * quality);
                }
            }
            else
            {
                sellIn = sellIn.Increase(-1);

                if (sellIn < 0)
                {
                    quality = quality.Increase(-1 * quality);
                }
            }

            return (quality, sellIn);
        }
    }
}
