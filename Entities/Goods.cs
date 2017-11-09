using System;

namespace CSharpHomeCase4_2.Entities
{
    abstract class Goods
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Goods(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public abstract override string ToString();
    }
}