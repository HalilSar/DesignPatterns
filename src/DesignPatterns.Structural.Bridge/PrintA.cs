using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public  class PrintA
    {
        public void PrintFootballMagazine() => Console.WriteLine("PrintA: Football Magazine Printed");
        public void PrintFantasticBook() => Console.WriteLine("PrintA: Fantastic Book Printed");
    }
}
