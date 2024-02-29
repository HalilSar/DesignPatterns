using System;

namespace DesignPatterns.Behavioral.Memonto
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            document.AddLine("-------------------------");
            document.AddLine("                         ");
            document.AddLine("                         ");
            document.AddLine("     XXX                 ");   // 4
            document.AddLine("                         ");
            document.AddLine("-------------------------");

            Console.WriteLine("First Document:");
            Memonto memonto = document.CreateMemonto();
            Console.WriteLine(document.ToString());
            document.RemoveLine(4);
            document.AddLine(4, "                YYY");
            Console.WriteLine("Second Document:");
            Console.WriteLine(document.ToString());

            document.SetMemonto(memonto);
            Console.WriteLine("Last Document:");
            Console.WriteLine(document.ToString());



        }
    }
}
