using System;

namespace DesignPatterns.Behavioral.Visitor
{
    public interface Printer
    {
        void Print();
        // Parameter : Visitor visitor
        void Accept(Visitor visitor);
    }
}
