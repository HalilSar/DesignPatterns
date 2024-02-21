using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public  class PrintB
    {
        public void PrintCookMagazine() => Console.WriteLine("PrintA: Cook Magazine Printed");
        public void PrintRomanceBook() => Console.WriteLine("PrintA: Romance Book Printed");
    }
}
