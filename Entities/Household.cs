using System;

namespace CSharpHomeCase4_2.Entities
{
    class Household : Goods
    {
        string ProductGroup { get; set; }

        public Household(string name, double price,
            int quantity, string productGroup = "Household")
            : base(name, price, quantity)
        {
            ProductGroup = productGroup;
        }

        public override string ToString()
        {
            return string.Format("Group Name:\t" + ProductGroup
                + "\nDescription:\t" + Name + "\nHot Price:\t"
                + Price + "\nQuantity:\t" + Quantity + "\n");
        }
    }
}
