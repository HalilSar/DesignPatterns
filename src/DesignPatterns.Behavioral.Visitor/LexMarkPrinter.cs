﻿using System;

namespace DesignPatterns.Behavioral.Visitor
{
    public class LexMarkPrinter : Printer
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
            return "LexMarkPrinter ";
        }
    }
}