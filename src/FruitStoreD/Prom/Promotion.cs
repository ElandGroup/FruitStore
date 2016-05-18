using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitStoreD
{
    public class Promotion : IPromotion
    {
        public decimal RuleA(GetDto getDto, CalcDiscount calcDiscount)
        {
            object obj = getDto();
            decimal price = calcDiscount(obj);
            return price * 0.8M;
        }
    }
}
