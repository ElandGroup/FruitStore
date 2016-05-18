using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FruitStoreD.Core;

namespace FruitStoreD
{
    public class AppleService : IAppleService
    {
        public AppleDto GetAppleDto()
        {
            return new AppleDto { Name = "a1", Price = 10 , Type="A"};
        }

        public decimal AppleDiscount(object dto)
        {
            AppleDto appleDto = dto as AppleDto;
            if (appleDto == null)
                return 0;
            if (appleDto.Type == "A")
            {
                return 3;
            }
            else
            {
                return 6;
            }
        }
    }
}
