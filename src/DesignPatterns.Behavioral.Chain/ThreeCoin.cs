using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Chain
{
    public class ThreeCoin : Coin
    {

        public override string ToString()
        {
            return "Three Coin";
        }

        public ThreeCoin()
        {
            value = 300;
        }
    }
}
