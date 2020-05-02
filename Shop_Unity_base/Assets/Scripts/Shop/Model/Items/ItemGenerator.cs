using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factories;

namespace Model.Items
{
    class ItemGenerator
    {
        ItemFactory itemFactory;
        public ItemGenerator(ItemFactory pFactory)
        {
            itemFactory = pFactory;
        }

        public Item GenerateNewItem()
        {
            return itemFactory.CreateItem();                        
        }
    }
}
