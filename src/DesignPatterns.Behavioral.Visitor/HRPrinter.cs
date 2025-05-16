using System;

namespace DesignPatterns.Behavioral.Visitor
{
    public class HRPrinter : Printer
    {
        // Parameter : Visitor visitor
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public void Print()
        {
            Console.WriteLine(this.ToString() + " is printing...");
        }
        // Return string
        public override string ToString()
        {
            return "HRPrinter ";
        }
    }
}