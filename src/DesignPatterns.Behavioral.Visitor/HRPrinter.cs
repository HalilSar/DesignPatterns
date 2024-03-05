using System;

namespace DesignPatterns.Behavioral.Visitor
{
    public class HRPrinter : Printer
    {
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public void Print()
        {
            Console.WriteLine(this.ToString() + " is printing...");
        }

        public override string ToString()
        {
            return "HRPrinter ";
        }
    }
}