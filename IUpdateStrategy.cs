using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    interface IUpdateStrategy
    {
        (int updatedQuality, int updatedSellIn) UpdateQuality(int quality, int sellIn);
    }
}
