using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Chain
{
    public class FourCoin : Coin
    {
        // Return string
        public override string ToString()
        {
            return "Four Coin";
        }

        public FourCoin()
        {
            value = 400;
        }
    }
}
