using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
   public interface ISortStrategy
    {
        // Parameter int[] array
        void Sort(int[] array);
    }
}
