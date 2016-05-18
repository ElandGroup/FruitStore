using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitStoreD
{
    public delegate object GetDto();
    public delegate decimal CalcDiscount(object dto);
    public interface IPromotion
    {
        decimal RuleA(GetDto getDto, CalcDiscount calcDiscount);
    }
}
