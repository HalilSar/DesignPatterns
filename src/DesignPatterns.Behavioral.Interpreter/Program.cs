using System;

namespace DesignPatterns.Behavioral.Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string formula = "10 times 10";
            new Interpreter().Interpret(formula);
        }
    }
}
