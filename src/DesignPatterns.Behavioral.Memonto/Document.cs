using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memonto
{
   public class Document
    {
        private Dictionary<int,string> lines;


        public Document( Dictionary<int, string> lines ) 
        {
            this.lines = lines;
        }

        public void AddLine(int index, string line) => lines.Add(index, line);
        public void RemoveLine(int index, string line) => lines.Remove(index);
        public void CreateMemonto() => new Memonto(lines.ToArray);

        public void SetMemonto(Memonto memonto)
        {
            lines.Clear();
            object[] templines = memonto.GetElements();
            for (int i = 0; i < templines.Length; i++)
            {
                string line = (string)templines[i];
                lines.Add(i,line);
            }
        }


        public override string ToString()
        {
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < lines.Count; i++)
            {
                temp.Append(lines.GetValueOrDefault(i)).Append(" \n");

            }
            return temp.ToString();
        }


    }
}
