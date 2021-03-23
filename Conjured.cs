using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Conjured : IItem
    {
        public void UpdateItem(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality.Increase(-2);
            }

            item.SellIn = item.SellIn.Increase(-1);

            if (item.SellIn < 0)
            {
                if (item.Quality > 0)
                {
                    item.Quality = item.Quality.Increase(-2);
                }
            }
        }
    }
}
