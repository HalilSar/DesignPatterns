using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class TvCloseCommand : Command
    {
        private Television tv;
        public TvCloseCommand( Television tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            tv.Close();
        }
    }
}
