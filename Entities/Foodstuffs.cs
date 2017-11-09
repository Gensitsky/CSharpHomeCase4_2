using System;

namespace CSharpHomeCase4_2.Entities
{
    class Foodstuffs : Goods
    {
        private string ProductGroup { get; set; }

        public Foodstuffs(string name, double price,
            int quantity, string productGroup = "Foodstuffs")
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
