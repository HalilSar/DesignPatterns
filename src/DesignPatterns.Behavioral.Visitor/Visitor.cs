using System;

namespace DesignPatterns.Behavioral.Visitor
{
    public interface Visitor
    {
        // Parameter : HRPrinter printer
        void Visit(HRPrinter printer);
        // Parameter : LexMarkPrinter printer
        void Visit(LexMarkPrinter printer);
    }
}
