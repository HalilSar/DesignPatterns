using System;

namespace DesignPatterns.Behavioral.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SortManager sort = new SortManager(new BubbleSortStrategy());
            int[] array = { 5, 2, 7, 9, 41, 3 };
            sort.AddSortArray(array);

            sort = new SortManager(new InsertionSortStrategy());
            sort.AddSortArray(array);
        }
    }
}
