using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); // Default is Quicksort

            Console.WriteLine("QuickSorted list ");
        }
    }
}
