using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.ClassAdapter
{
    public  class PrintScreen
    { 
        // parameter : string val
        public void Screen(string val)
        {
            Console.WriteLine(val);
        }
    }
}
