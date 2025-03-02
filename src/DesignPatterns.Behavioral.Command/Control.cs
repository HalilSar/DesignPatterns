using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
   public class Control
    {
        public Command[] commands = new Command[2];
        public Control()
        {
            Television tv = new Television();
            commands[0] = new TvOpenCommand(tv);
            commands[1] = new TvCloseCommand(tv);
        }
        
	// Parameter : int command
        public void Press(int command)
        {
            if ( command>commands.Length  ||  command < 0)
            {
                Console.WriteLine("Invalid command");
            }

            commands[command].Execute();
        }
    }
}
