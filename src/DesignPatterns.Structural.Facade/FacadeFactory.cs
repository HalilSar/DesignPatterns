using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class FacadeFactory
    {
        private static FacadeFactory instance = new FacadeFactory();
        private FacadeFactory()
        {

        }

        public static FacadeFactory GetInstance() => instance;
        public ComponentFacade GetFacade()
        {
            return new ConcreteFacade();
        }
    }
}
