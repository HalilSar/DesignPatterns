using System;

namespace DesignPatterns.Behavioral.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************");
            Control control = new Control();
            control.Press(0);
            control.Press(1);
            Console.WriteLine("************");
        }
    }
}
