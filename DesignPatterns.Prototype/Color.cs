using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public sealed class Color : ColorPrototype
    {
        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public override ColorPrototype Clone()
        {
            Console.WriteLine(
           "Cloning color RGB: {0,3},{1,3},{2,3}", Red, Green, Blue);

            return this.MemberwiseClone() as ColorPrototype;
        }

        public int Red { get; private set; }
        public int Green { get; private set; }
        public int Blue { get; private set; }
    }
}
