using System;

namespace DesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld animalWorld = new AnimalWorld(africa);
            animalWorld.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            animalWorld = new AnimalWorld(america);
            animalWorld.RunFoodChain();

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}
