using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitStoreD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPromotion promotion = new Promotion();
            IAppleService appleService = new AppleService();
            IBananaService bService = new BananaService();
            decimal aPrice = promotion.RuleA(appleService.GetAppleDto, appleService.AppleDiscount);

            decimal bPrice = promotion.RuleA(bService.GetBananaDto, bService.BananaDiscount);

            Console.WriteLine("price of apple in ruleA:"+aPrice);
            Console.WriteLine("price of banana in ruleA:"+bPrice);

            Console.ReadLine();
        }
    }
}
