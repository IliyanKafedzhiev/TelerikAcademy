using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class Iron:Item
    {
        public Iron(string name, Location location = null)
            : base(name, 3, ItemType.Iron, location)
        {
        }

        static List<ItemType> GetComposingItems()
        {
            return new List<ItemType>() { ItemType.Iron };
        }
    }
}
