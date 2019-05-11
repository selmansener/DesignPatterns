using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }
}
