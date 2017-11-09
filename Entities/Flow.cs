using System;

namespace CSharpHomeCase4_2.Entities
{
    enum Status
    {
        Dispatched, Sold, Transmitted, Written
    }
    class Flow
    {
        public Goods[] Lot { get; set; }
        public Status Condition { get; set; }

        public Flow(Goods[] lot,Status condition)
        {
            Lot = lot;
            Condition = condition;
        }

        public override string ToString()
        {
            return string.Format("Set Condition:\t{0}\n",
                Condition);
        }

        public void Show()
        {
            foreach (var item in Lot)
            {
                Console.WriteLine($"Condition:\t{Condition}");
                Console.WriteLine(item);
            }
        }
    }
}
