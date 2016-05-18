
namespace FruitStoreS
{
    public class FruitFactory
    {
        public static Fruit CreateFruit(FruitType type)
        {
            Fruit fruit = null;
            switch (type)
            {
                case FruitType.Apple:
                    fruit = new Apple();
                    break;
                case FruitType.Pear:
                    fruit = new Pear();
                    break;
                case FruitType.Banana:
                    fruit = new Banana();
                    break;
                default:
                    break;
            }

            return fruit;
        }
    }
}
