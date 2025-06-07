using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
  public   class AudiOrderBuilder:OrderBuilder
    {

        // parameter string brand
        public override void SetBrand(string brand) {        
              this.car.Brand  = new Brand(brand);
        }
        // parameter string model
        public override void SetModel(string model)
        {
              this.car.Model  = new Model(model);
        }
        // parameter string color
        public override void SetColor(string color) {
            this.car.Color = color;

        }
        // parameter int horsepower
        public override void SetHorsePower(int horsePower){
            this.car.HorsePower = horsePower;
        }

    }
}
