

namespace FruitStoreS
{
    public class Banana : Fruit
    {
        public override decimal CalcCoupon()
        {
            return CalcPrice() * 0.5M;
        }

        public override decimal CalcPrice()
        {
            return 4.5m;
        }
    }
}
