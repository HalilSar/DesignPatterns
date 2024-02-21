using System;

namespace DesignPatterns.Structural.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Book(new PublishA());
            catalog.CreatePublish();

            catalog = new Magazine(new PublishA());
            catalog.CreatePublish();

            Console.WriteLine("*********************");

            catalog = new Book(new PublishB());
            catalog.CreatePublish();

            catalog = new Magazine(new PublishB());
            catalog.CreatePublish();

            Console.WriteLine("*********************");
        }
    }
}
