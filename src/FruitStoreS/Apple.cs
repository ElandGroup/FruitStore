using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitStoreS
{
    public class Apple :Fruit
    {
        public override decimal CalcCoupon()
        {
            return CalcPrice() * 0.5M;
        }

        public override decimal CalcPrice()
        {
            return 5m;
        }
    }
}
