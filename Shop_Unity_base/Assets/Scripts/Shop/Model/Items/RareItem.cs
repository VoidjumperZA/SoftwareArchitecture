using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Items
{
    class RareItem : Item
    {
        private string[] itemOwner =
            {
            "Knight",
            "Witch",
            "Cataphract",
            "Caliph",
            "Queen",
            "Hermit",
            "Mad Man"
            };

        private string[] itemAdjectives =
            {
            "Gleaming",
            "Scintillating",
            "Humming",
            "Unbreakable",
            "Glowing",
            "Enchanted",
            "Cursed"
            };

        public RareItem(ItemRarity pRarity) : base(pRarity)
        {

        }
        
        protected override string GenerateName()
        {
            return String.Format("A {0}'s {1} {2}", itemOwner[0], itemAdjectives[0], itemName[0]);
        }
    }
}
