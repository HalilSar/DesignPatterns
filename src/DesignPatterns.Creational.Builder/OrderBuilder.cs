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
        public Car GetCar() => car;

        public abstract void SetBrand(string brand);
        public abstract void SetModel(string model);
        public abstract void SetColor(string color);
        public abstract void SetHorsePower(int horsePower);

    }
}
