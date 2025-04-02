using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memonto
{
   public class Document
    {
        private List<string> lines;
      
        public Document( ) 
        {
            this.lines = new  List<string>();
            
        }
        // parameter string line
        public void AddLine( string line) => lines.Add( line);
         // parameter string line, int id
	public void AddLine( int id, string line) => lines[id]= line;
	 // parameter int index
        public void RemoveLine(int index) => lines.Remove(lines[index]);
        // return Memonto
	public Memonto CreateMemonto() => new Memonto(lines.ToArray());
       // parameter Memonto
        public void SetMemonto(Memonto memonto)
        {
            lines.Clear();
            object[] templines = memonto.GetElements();
            for (int i = 0; i < templines.Length; i++)
            {
                string line = (string)templines[i];
                lines.Add(line);
            }
        }

        // return string
        public override string ToString()
        {
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < lines.Count; i++)
            {
                temp.Append(lines[i]).Append(" \n");

            }
            return temp.ToString();
        }


    }
}
