using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
  public   class AudiOrderBuilder:OrderBuilder
    {


        public override void SetBrand(string brand) {        
              this.car.Brand  = new Brand(brand);
        }
        public override void SetModel(string model)
        {
              this.car.Model  = new Model(model);
        }
        public override void SetColor(string color) {
            this.car.Color = color;

        }
        public override void SetHorsePower(int horsePower){
            this.car.HorsePower = horsePower;
        }

    }
}
