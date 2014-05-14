using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class Weapon : Item
    {
        const int GeneralValue = 5;

        public Weapon(string name, Location location = null)
            : base(name, Weapon.GeneralValue, ItemType.Weapon, location)
        {
        }

        static List<ItemType> GetComposingItems()
        {
            return new List<ItemType>() { ItemType.Iron };
        }
    }
}
