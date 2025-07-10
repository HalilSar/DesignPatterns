using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.ClassAdapter
{
    public class PrintAdapter :PrintScreen, IPrintScreen
    {
         // parameter : string val
        public void Print(string val)
        {
            this.Screen(val);
        }
    }
}
