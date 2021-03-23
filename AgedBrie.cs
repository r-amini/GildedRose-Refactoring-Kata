using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class AgedBrie : IItem
    {
        public void UpdateItem(Item item)
        {
            item.SellIn = item.SellIn.Increase(-1);

            if (item.Quality < 50)
            {
                item.Quality = item.Quality.Increase(1);

                if (item.SellIn < 0 && item.Quality < 50)
                {
                    item.Quality = item.Quality.Increase(1);
                }
            }
        }
    }
}
