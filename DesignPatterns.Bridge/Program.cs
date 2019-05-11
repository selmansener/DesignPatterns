using System;

namespace DesignPatterns.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create RefinedAbstraction
            Customers customers = new Customers("Chicago");

            // Set ConcreteImplementor
            customers.Data = new CustomersData();

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}
