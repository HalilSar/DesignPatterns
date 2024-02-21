using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class PublishA : Publish
    {
        public void PublishBook()
        {
            throw new NotImplementedException();
        }

        public void PublishMagazine()
        {
            throw new NotImplementedException();
        }
    }
}
