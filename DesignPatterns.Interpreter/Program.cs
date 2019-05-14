using System;
using System.Collections.Generic;

namespace DesignPatterns.Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);

            // Build the 'parse tree'

            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Interpret

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}",
              roman, context.Output);

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}
