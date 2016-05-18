using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FruitStoreD.Core;

namespace FruitStoreD
{
    public class BananaService : IBananaService
    {
        public BananaDto GetBananaDto()
        {
            return new BananaDto{ Name="b1", Price=20,Type="B"};
        }
        public decimal BananaDiscount(object dto)
        {
            BananaDto bDto = dto as BananaDto;
            if (bDto == null)
                return 0;

            if (bDto.Type == "B")
            {
                return 9;
            }
            else
            {
                return 12;
            }
        }
    }
}
