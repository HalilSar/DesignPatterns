using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class PublishB : Publish
    {
        private PrintB print = new PrintB();
        public void PublishBook()
        {
            print.PrintRomanceBook();
        }

        public void PublishMagazine()
        {
            print.PrintCookMagazine();

        }
    }
}
