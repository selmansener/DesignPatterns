using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
}
