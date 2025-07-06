using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.ClassAdapter
{
    public  interface IPrintScreen
    {
        // parameter : string val
        public void Print(string val);
    }
}
