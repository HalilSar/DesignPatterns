using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
   public  class Model
    {
        private string ModelName { get; set; }
        public Model(string modelName)
        {
            ModelName = modelName;
        }
        public override string ToString()
        {
            return ModelName;
        }
    }
}
