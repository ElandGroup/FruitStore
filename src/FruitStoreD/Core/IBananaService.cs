using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FruitStoreD.Core;

namespace FruitStoreD
{
    public interface IBananaService
    {
        BananaDto GetBananaDto();
        decimal BananaDiscount(object dto);
    }
}
