using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitStoreS
{
    public abstract class Fruit
    {
        public string Name { get; set; }

        public abstract decimal CalcPrice();
        public abstract decimal CalcCoupon();

    }
}
