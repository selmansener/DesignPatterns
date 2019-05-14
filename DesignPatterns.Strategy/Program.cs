using System;

namespace DesignPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two contexts following different strategies
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}
