using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class TvOpenCommand : Command
    {
        private Television tv;
        public TvOpenCommand( Television tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            tv.Open();
        }
    }
}
