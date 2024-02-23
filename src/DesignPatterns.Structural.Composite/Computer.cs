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
        public void AddPart(Part part) => partList.Add(part);
        public void RemovePart(Part part) => partList.Remove(part);
        public Part GetPart(int id) => partList[id];
        
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
