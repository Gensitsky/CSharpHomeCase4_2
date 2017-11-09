/*
    Разработать архитектуру классов иерархии товаров
    при разработке системы управления потоками товаров для
    дистрибьюторской компании. Прописать члены классов.
    Создать диаграммы взаимоотношений классов.
    Должны быть предусмотрены разные типы товаров,
    в том числе:
    • бытовая химия;
    • продукты питания.
    Предусмотреть классы управления потоком товаров
    (пришло, реализовано, списано, передано).
*/
using System;
using CSharpHomeCase4_2.Entities;

namespace CSharpHomeCase4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Goods[] goodsLot1 =
            {
                new Foodstuffs("Apple", 3.20, 10),
                new Household("Soap", 5.70, 20),
                new Household("Domestos", 7.40, 10),
                new Foodstuffs("Crackers", 1.05, 15),
                new Foodstuffs("Chocolate", 4.70, 50)
            };

            Flow flow1 = new Flow(goodsLot1, Status.Dispatched);
            flow1.Show();

            flow1.Condition = Status.Sold;
            Console.WriteLine(flow1.ToString());

            flow1.Show();

            Console.ReadKey();
        }
    }
}