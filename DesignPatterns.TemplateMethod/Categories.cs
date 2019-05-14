using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethod
{
    public class Categories : DataAccessObject
    {
        public override void Select()
        {
            Console.WriteLine("Get Categories from db");
        }

        public override void Process()
        {
            Console.WriteLine("Categories ---- ");
            Console.WriteLine("Process");
        }
    }
}
