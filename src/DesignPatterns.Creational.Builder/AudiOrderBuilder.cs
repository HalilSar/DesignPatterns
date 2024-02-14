using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
  public   class AudiOrderBuilder:OrderBuilder
    {


        public override void GetBrand(string brand) {        
              this.car.Brand  = new Brand(brand);
        }
        public override void GetModel(string model)
        {
              this.car.Model  = new Model(model);
        }
        public override void GetColor(string color) {
            this.car.Color = color;

        }
        public override void GetHorsePower(int horsePower){
            this.car.HorsePower = horsePower;
        }

    }
}
