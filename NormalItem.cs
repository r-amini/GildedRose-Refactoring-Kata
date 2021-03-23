using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class NormalItem : IItem
    {
        public void UpdateItem(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality.Increase(-1);
            }

            item.SellIn = item.SellIn.Increase(-1);

            if (item.SellIn < 0)
            {
                if (item.Quality > 0)
                {
                    item.Quality = item.Quality.Increase(-1);
                }
            }
        }
    }
}
