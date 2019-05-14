using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public class Director : Employee
    {
        public Director()
         : base("Elly", 35000.0, 16)
        {
        }
    }
}
