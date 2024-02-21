using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class Magazine:Catalog
    {
        public Magazine(Publish publish):base(publish)
        {
            
        }
        public override  void CreatePublish()
        {
            CreateMagazinePublish();
        }
        public void CreateMagazinePublish()
        {
            this.publish.PublishMagazine();
        }


    }
}
