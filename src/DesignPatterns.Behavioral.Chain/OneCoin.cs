using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Chain
{
    public class OneCoin:Coin
    {
       // Return String
        public override string ToString()
        {
            return "One Coin";
        }

        public OneCoin()
        {
            value = 100;
        }
    }
}
