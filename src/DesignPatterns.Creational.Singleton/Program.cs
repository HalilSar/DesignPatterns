using System;

namespace DesignPatterns.Creational.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var file= FileSingleton.CreateInstance();
            file.FileCreate("D:\\deneme.txt");
            file.FileDelete("D:\\deneme.txt");
            Console.WriteLine("Hello World!");
        }
    }
}
