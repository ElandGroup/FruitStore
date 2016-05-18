

namespace FruitStoreS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Fruit fruit = FruitFactory.CreateFruit(FruitType.Banana);
            decimal price = fruit.CalcPrice();



        }
    }
}
