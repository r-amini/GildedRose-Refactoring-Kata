using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class ItemFactory
    {
        private readonly IItem _item = null;
        public ItemFactory(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    _item = new AgedBrie();
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    _item = new BackstagePasses();
                    break;
                case "Sulfuras, Hand of Ragnaros":
                    _item = new Sulfuras();
                    break;
                case "Conjured":
                    _item = new Conjured();
                    break;
                default:
                    _item = new NormalItem();
                    break;
            }
        }

        public void UpdateItem(Item item)
        {
            _item.UpdateItem(item);
        }
    }
}
