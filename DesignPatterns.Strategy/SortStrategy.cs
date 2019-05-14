using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
