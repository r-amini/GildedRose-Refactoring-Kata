using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class BackstagePasses : IItem
    {
        public void UpdateItem(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;

                if (item.Quality < 50)
                {
                    if (item.SellIn < 11)
                    {
                        item.Quality = item.Quality + 1;
                    }
                    if (item.SellIn < 6)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }

                item.SellIn = item.SellIn - 1;

                if (item.SellIn < 0)
                {
                    item.Quality = item.Quality - item.Quality;
                }
            }
            else
            {
                item.SellIn = item.SellIn - 1;

                if (item.SellIn < 0)
                {
                    item.Quality = item.Quality - item.Quality;
                }
            }
        }
    }
}
