using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Items
{
    class CommonItem : Item
    {
        private string[] itemAdjectives =
        {
            "Common",
            "Standard Issue",
            "Training",
            "Ordinary",
            "Service"
            };

        public CommonItem(ItemRarity pRarity) : base(pRarity)
        {

        } 

        protected override string GenerateName()
        {            
            return String.Format("{0} {1}", itemAdjectives[0], itemName[0]);
        }

        protected override int GenerateCost()
        {
            return base.GenerateCost();
        }
    }

    
}
