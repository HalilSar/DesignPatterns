using System;

namespace DesignPatterns.Behavioral.Visitor
{
    public interface Visitor
    {
        void Visit(HRPrinter printer);
        void Visit(LexMarkPrinter printer);
    }
}
