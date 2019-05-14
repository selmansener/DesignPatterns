using System;

namespace DesignPatterns.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}
