using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Computer : Part
    {
        private  List<Part> partList = new List<Part>();

        // Parameter : Part part
        public void AddPart(Part part) => partList.Add(part);

        // Parameter : Part part
        public void RemovePart(Part part) => partList.Remove(part);

        // Return    : Part
        // Parameter : int id
        public Part GetPart(int id) => partList[id];
        
        // Return : int 
        public int GetPrice()
        {
            int price = 0;
            for (int i = 0; i < partList.Count; i++)
            {
                price += GetPart(i).GetPrice();
            }
            return price;
        }
    }
}