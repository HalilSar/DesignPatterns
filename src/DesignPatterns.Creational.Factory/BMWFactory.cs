using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class BMWFactory : CarFactory
    {
        public override void CreateAuto()
        {
            SetCarList(new Z4(170));
            
        }
    }
}
