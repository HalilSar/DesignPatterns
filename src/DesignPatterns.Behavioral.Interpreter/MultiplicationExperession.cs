using System;

namespace DesignPatterns.Behavioral.Interpreter
{
    public class MultiplicationExperession : Expression
    {
        private int op1;
        private int op2;
        private string formula;
        
	
        public MultiplicationExperession(string formula)
        {
            int[] ops = Parse(formula);
            this.op1 = ops[0];
            this.op2 = ops[1];
            this.formula = formula;

        }
        
	// Return    : int[]
	// Parameter : string formula
        private int[] Parse(string formula)
        {
            string[] ops = formula.Split(OperationIdentifier.MULTIPLICATION);
            return new int[]
            {
                int.Parse(ops[0].Trim()), int.Parse(ops[1].Trim())
            };
        }

        public void Calculete()
        {
            Console.WriteLine("answer: " +this.op1 * this.op2 + " for " + this.formula);
        }
    }
}
