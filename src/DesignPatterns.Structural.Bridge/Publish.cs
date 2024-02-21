using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
   public interface Publish
    {
        public void PublishBook();
        public void PublishMagazine();
    }
}
