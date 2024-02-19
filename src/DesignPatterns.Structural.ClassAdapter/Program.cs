using System;

namespace DesignPatterns.Structural.ClassAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintScreen print = new PrintAdapter();
            print.Print("Hello World!");
        }
    }
}
