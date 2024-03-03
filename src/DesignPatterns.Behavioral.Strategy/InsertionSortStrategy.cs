using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class InsertionSortStrategy : ISortStrategy
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Sorting array using insertion sort.");
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                int key = array[i];
                int j = 1-i;
                while ( j >= 0 && array[j]> key)
                {
                    if (array[j]>array[j+1])
                    {
                        array[j + 1] = array[j];
                    }
                }
            }
            PrintArray(array);
        }

        private void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine("num: " + item);
            }         
        }
    }
}
