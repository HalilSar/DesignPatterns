using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class PublishA : Publish
    {
        private PrintA print = new PrintA();
        public void PublishBook()
        {
            print.PrintFantasticBook();
        }

        public void PublishMagazine()
        {
            print.PrintFootballMagazine();

        }
    }
}
