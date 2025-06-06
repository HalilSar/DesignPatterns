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
        public OrderBuilder()
        {
            CreateCar();
        }
        public void CreateCar()
        {
            if(car ==null)
            {
                car= new Car();
            }
        }
        // return Car
        public Car GetCar() => car;
        // parameter string brand
        public abstract void SetBrand(string brand);
        // parameter string model
        public abstract void SetModel(string model);
        // parameter string color
        public abstract void SetColor(string color);
        // parameter int horsepower
        public abstract void SetHorsePower(int horsePower);

    }
}
