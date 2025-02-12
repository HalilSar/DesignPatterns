using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Chain
{
    public class TwoCoin : Coin
    {
       // Parameter string
        public override string ToString()
        {
            return "Two Coin";
        }

        public TwoCoin()
        {
            value = 200;
        }
    }
}
