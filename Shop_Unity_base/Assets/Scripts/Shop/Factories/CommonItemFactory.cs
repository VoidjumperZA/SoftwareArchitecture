using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Items;

namespace Factories
{
    class CommonItemFactory : ItemFactory
    {
        public Item CreateItem()
        {
            return new Item(Item.ItemRarity.Common);
        }
    }
}
