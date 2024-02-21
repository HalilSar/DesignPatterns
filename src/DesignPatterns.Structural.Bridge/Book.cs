using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class Book:Catalog
    {
        public Book(Publish publish):base(publish)
        {
            
        }
        public override  void CreatePublish()
        {
            CreateBookPublish();
        }
        public void CreateBookPublish()
        {
            this.publish.PublishBook();
        }


    }
}
