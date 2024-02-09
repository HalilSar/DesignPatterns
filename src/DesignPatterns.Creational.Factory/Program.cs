using System;

namespace DesignPatterns.Creational.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory bmw = new BMWFactory();
            foreach (var item in bmw.cars)
            {
                Console.WriteLine(item.Brand + " " + item.Model + + item.HorsePower);
            }
          
        }
    }
}
