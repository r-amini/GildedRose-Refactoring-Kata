using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public static class IntExtension
    {
        public static int Increase(this int baseValue, int addedValue)
        {
            return baseValue + addedValue;
        }
    }
}
