using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
   public class OrderManager
    {
        private OrderBuilder orderBuilder;
        // parameters : string brand,string model,string color,int horsePower
        // return : Car
        public Car  CreateOrder(string brand,string model,string color,int horsePower)
        {
            if(brand=="Ford")
            {
                orderBuilder= new FordOrderBuilder();
            }
                
            else if (brand=="Audi")
            {
                 orderBuilder = new AudiOrderBuilder();
            }
               
            orderBuilder.SetBrand(brand);
            orderBuilder.SetModel(model);
            orderBuilder.SetColor(color);
            orderBuilder.SetHorsePower(horsePower);

            return orderBuilder.GetCar();
        }
        public void  ShowOrder()
        {
            Console.WriteLine("Brand:"+ " "+ orderBuilder.GetCar().Brand);
            Console.WriteLine("Model:" + " "+ orderBuilder.GetCar().Model);
            Console.WriteLine("Color:" + " "+ orderBuilder.GetCar().Color);
            Console.WriteLine("HorsePower:" + " "+ orderBuilder.GetCar().HorsePower);
        }
    }
}
