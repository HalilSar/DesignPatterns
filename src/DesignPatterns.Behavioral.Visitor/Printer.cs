using System;

namespace DesignPatterns.Behavioral.Visitor
{
    public interface Printer
    {
        void Print();
        void Accept(Visitor visitor);
    }
}
