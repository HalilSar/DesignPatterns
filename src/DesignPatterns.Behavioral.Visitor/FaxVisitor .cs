﻿using System;

namespace DesignPatterns.Behavioral.Visitor
{
    public class FaxVisitor : Visitor
    {
        public void Visit(HRPrinter printer)
        {
            Console.WriteLine(printer.ToString() + " is faxing...");
        }

        public void Visit(LexMarkPrinter printer)
        {
            Console.WriteLine(printer.ToString() + " cannot fax.(not implemented.)");
        }
    }
}
