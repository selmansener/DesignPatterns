using System;

namespace DesignPatterns.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup employee collection

            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            // Employees are 'visited'

            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}
