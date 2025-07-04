﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
   public abstract class CarFactory
    {
        public List<Car> cars = new List<Car>();
        public abstract void CreateAuto();
        public CarFactory()
        {
            CreateAuto();
        }
        // Parameter: Car car
        public void SetCarList(Car car) => this.cars.Add(car);


    }
}
