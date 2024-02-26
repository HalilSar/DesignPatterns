using System;

namespace DesignPatterns.Structural.Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********");

            string firstLine = "First Line";

            string secondLine = "Second Line";

            string thirdLine = "Third Line";

            CharacterManager.GetInstance().AddLine(firstLine, 1);
            CharacterManager.GetInstance().AddLine(secondLine, 2);
            CharacterManager.GetInstance().AddLine(thirdLine, 3);

            CharacterManager.GetDocument();

            Console.WriteLine("**********");


        }
    }
}
