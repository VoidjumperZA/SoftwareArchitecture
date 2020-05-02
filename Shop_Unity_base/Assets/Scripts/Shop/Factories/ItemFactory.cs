using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories
{
    interface ItemFactory
    {
        public Model.Items.Item CreateItem();
    }
}
