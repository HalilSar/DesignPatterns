using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.ObjectAdapter
{
    public  class PrintAdapter:ClientScreen
    {
        private PrintScreen print = new PrintScreen();
        public override void Screen()
        {
            print.PrintScreenMethod();
        }

    }
}
