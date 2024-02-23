using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Monitor : Part
    {
        public int GetPrice()
        {
            return 100;
        }
    }
}
