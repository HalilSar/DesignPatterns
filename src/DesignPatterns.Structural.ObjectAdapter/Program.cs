using System;

namespace DesignPatterns.Structural.ObjectAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientScreen client = new PrintAdapter();
            client.Screen();
            Console.WriteLine("*********");
        }
    }
}
