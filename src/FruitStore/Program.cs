using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal applePrice = Fruit.CalcPrice(FruitType.Apple);
            Console.WriteLine("苹果的价格："+applePrice);
            Console.Read();
        }
    }
}
