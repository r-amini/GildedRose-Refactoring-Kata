using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Sulfuras : IUpdateStrategy
    {
        public (int updatedQuality, int updatedSellIn) UpdateQuality(int quality, int sellIn)
        {
            return (quality, sellIn);
        }
    }
}
