
using System;

namespace FruitStoreD
{
    public class FruitFactory
    {
        public static T CreateObject<T>(string classAndAssemblyName)
        {
            return (T)Activator.CreateInstance(Type.GetType(classAndAssemblyName));
        }
    }
}
