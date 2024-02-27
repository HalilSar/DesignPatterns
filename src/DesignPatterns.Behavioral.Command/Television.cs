using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
   public class Television
    {
        public void Open() => Console.WriteLine("Tv opened.");

        public void Close() => Console.WriteLine("Tv opened.");

        public void Change() => Console.WriteLine("Channel Changed.");
    }
}
