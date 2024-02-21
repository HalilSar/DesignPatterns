using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public abstract class Catalog
    {
        protected Publish publish;
        public abstract void CreatePublish();
        public Catalog(Publish publish)
        {
            this.publish = publish;
        }
    }
}
