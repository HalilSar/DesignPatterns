using System;

namespace DesignPatterns.Behavioral.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsPaper sun = new Sun();
            NewsPaper guardian = new Guardian();
            Subscriber subs = new Customer("John", "Smith");
            subs.AddSubscribe(sun);
            Subscriber subs2 = new Customer("Jane", "Smith");
            subs2.AddSubscribe(guardian);
            

        }
    }
}
