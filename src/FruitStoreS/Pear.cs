

namespace FruitStoreS
{
    public class Pear : Fruit
    {
        public override decimal CalcCoupon()
        {
            return CalcPrice() * 0.5M;
        }

        public override decimal CalcPrice()
        {
            return 4m;
        }
    }
}
