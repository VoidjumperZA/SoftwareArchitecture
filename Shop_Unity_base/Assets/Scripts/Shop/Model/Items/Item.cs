namespace Model.Items
{
    //This class holds data for an Item. Currently it has a name, an iconName and an amount.
    public class Item
    {
        public readonly string name;
        public readonly string iconName;
        public int amount { get; private set; }
        public enum ItemRarity { Common, Rare, Legendary, Exotic };
        private ItemRarity itemRarity;
        protected float itemCostRarityScalar = 1.83f;
        protected string[] itemName =
            {
            "Sword",
            "Scimitar",
            "Buckler",
            "Lance",
            "Halbert",
            "Dagger",
            "Helm"
            };

        //------------------------------------------------------------------------------------------------------------------------
        //                                                  Item()
        //------------------------------------------------------------------------------------------------------------------------
        public Item(ItemRarity pItemRarity, string pName = "", string pIconName = "", int pAmount = 0/*, ItemRarity pItemRarity, string pFlavourText = ""*/)
        {
            name = pName == string.Empty ? GenerateName() : pName;
            amount = pAmount == 0 ? GenerateCost() : pAmount;
            /*name = pName;
            iconName = pIconName;
            amount = pAmount;*/
            itemRarity = pItemRarity;
        }

        protected virtual string GenerateName()
        {
            //Common
            //Adj, adj, Sword
            //Sword, of Y
            //CUSTOM
            return "Unidentified Item";
        }

        protected virtual int GenerateCost()
        {
            return (int)(1 * (itemCostRarityScalar * (int)itemRarity));
        }
        


    }
}
