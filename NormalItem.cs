using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class NormalItem : AbstractItem
    {
        public NormalItem(string name, int sellIn, int quality)
            : base(name, sellIn, quality)
        {
        }

        public override void UpdateItem()
        {
            if (Quality > 0)
            {
                Quality = Quality.Increase(-1);
            }

            SellIn = SellIn.Increase(-1);

            if (SellIn < 0)
            {
                if (Quality > 0)
                {
                    Quality = Quality.Increase(-1);
                }
            }
        }
    }
}
