using System;

namespace DesignPatterns.Behavioral.Visitor
{
    public class FaxVisitor : Visitor
    {
        // Parameter : HRPrinter printer
        public void Visit(HRPrinter printer)
        {
            Console.WriteLine(printer.ToString() + " is faxing...");
        }
        // Parameter : LexMarkPrinter printer
        public void Visit(LexMarkPrinter printer)
        {
            Console.WriteLine(printer.ToString() + " cannot fax.(not implemented.)");
        }
    }
}
