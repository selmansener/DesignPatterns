using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight
{
    public class CharacterZ : Character
    {
        public CharacterZ()
        {
            this.symbol = 'Z';
            this.height = 100;
            this.width = 100;
            this.ascent = 68;
            this.descent = 0;
        }

        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine(this.symbol +
              " (pointsize " + this.pointSize + ")");
        }
    }
}
