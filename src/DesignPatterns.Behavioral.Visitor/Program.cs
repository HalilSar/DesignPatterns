using System;

namespace DesignPatterns.Behavioral.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer hp = new HRPrinter();
            Printer lex = new LexMarkPrinter();

            hp.Print();
            lex.Print();

            Visitor visitor = new FaxVisitor();
            hp.Accept(visitor);
            lex.Accept(visitor);

            Console.WriteLine("+-----------------------------+");
        }
    }
}
