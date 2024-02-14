using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
   public  class Brand
    {
        private string BrandName { get; set; }
        public Brand(string brandName)
        {
            BrandName = brandName;
        }
        public override string ToString()
        {
            return BrandName;
        }
    }
}
