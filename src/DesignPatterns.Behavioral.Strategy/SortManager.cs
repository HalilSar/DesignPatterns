using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
   public class SortManager
    {
        private ISortStrategy sortStrategy;
        public SortManager(ISortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }
        // parameter int[] array
        public void AddSortArray(int[] array) => this.sortStrategy.Sort(array);
    }
}
