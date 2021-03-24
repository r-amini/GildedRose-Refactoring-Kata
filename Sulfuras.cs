using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Sulfuras : AbstractItem
    {
        public Sulfuras(int sellIn, int quality)
            : base("Sulfuras, Hand of Ragnaros", sellIn, quality)
        {
        }

        public override void UpdateItem()
        {
            
        }
    }
}
