using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace FruitStoreD
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = new ConfigurationBuilder()
             .AddJsonFile("appsettings.json");
            IConfigurationRoot configuration = builder.Build();

            IPromotionService promotion = FruitFactory.CreateObject<IPromotionService>(configuration["Promotion"]);
            IAppleService appleService = FruitFactory.CreateObject<IAppleService>(configuration["AppleService"]);
            IBananaService bService = FruitFactory.CreateObject<IBananaService>(configuration["BananaService"]);

            decimal aPrice = promotion.RuleA(appleService.GetAppleDto, appleService.AppleDiscount);

            decimal bPrice = promotion.RuleA(bService.GetBananaDto, bService.BananaDiscount);

            Console.WriteLine("price of apple in ruleA:"+aPrice);
            Console.WriteLine("price of banana in ruleA:"+bPrice);

            Console.ReadLine();
        }
    }
}
