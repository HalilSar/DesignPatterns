using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
  public abstract  class OrderBuilder
    {
        protected Car car;
        public Car GetCar()
        {
            if(car ==null)
            {
                return new Car();
            }
            return null;
        }

        public abstract void GetBrand(string brand);
        public abstract void GetModel(string model);
        public abstract void GetColor(string color);
        public abstract void GetHorsePower(int horsePower);

    }
}
