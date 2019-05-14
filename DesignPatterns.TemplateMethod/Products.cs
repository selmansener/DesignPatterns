using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethod
{
    public class Products : DataAccessObject
    {
        public override void Select()
        {
            Console.WriteLine("Get products from db");
        }

        public override void Process()
        {
            Console.WriteLine("Products ---- ");
            Console.WriteLine("Process");
        }
    }
}
