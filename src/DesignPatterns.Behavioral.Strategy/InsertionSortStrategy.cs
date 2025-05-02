using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class InsertionSortStrategy : ISortStrategy
    {
        // Parameter int[] array
        public void Sort(int[] array)
        {
            Console.WriteLine("Sorting array using insertion sort.");
            int n = array.Length;
            for (int i = 0; i < n; ++i)
            {
                int key = array[i];
                int j = i-1;
                while ( j >= 0 && array[j]> key)
                {                               
                    array[j + 1] = array[j];
                    j -= 1;
                }
                array[j + 1] = key;
            }
            PrintArray(array);
        }
        // Parameter int[] array
        private void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine("num: " + item);
            }         
        }
    }
}
