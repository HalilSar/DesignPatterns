using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class BubbleSortStrategy : ISortStrategy
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Sorting array using bubble sort");
            int n = array.Length;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-1 ; j++)
                {
                    if (array[j]>array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
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
