using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitStore
{

    public class Fruit
    {
        public string Name { get; set; }
        public static decimal CalcPrice(FruitType type)
        {
            decimal price = 0m;
            switch (type)
            {
                case FruitType.Apple:
                    price = 5;
                    break;
                case FruitType.Pear:
                    price = 4;
                    break;
                case FruitType.Banana:
                    price = 4.5m * 0.7m;
                    break;
                default:
                    break;
            }
            price = price * 0.5m;
            return price;
        }
    }
}
