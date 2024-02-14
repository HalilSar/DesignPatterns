using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
  public abstract  class OrderBuilder
    {
        private Car car;
        public Car GetCar()
        {
            if(car ==null)
            {
                return new Car();
            }
            return null;
        }

        public abstract void GetBrand(string brand);
        public abstract void GetModel(string brand);
        public abstract void GetColor(string brand);
        public abstract void GetHorsePower(string horsePower);

    }
}
