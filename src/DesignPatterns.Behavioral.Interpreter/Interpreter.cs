using System;

namespace DesignPatterns.Behavioral.Interpreter
{
    public class Interpreter
    {

       // Parameter : string value
        public void Interpret(string value)
        {
            Expression expression = Parse(value);
            expression.Calculete();
        }
        
	// Return    : Expression
	// Parameter : string value
        private Expression Parse(string value)
        {
            if (value.Contains(OperationIdentifier.MULTIPLICATION))
                return new MultiplicationExperession(value);
            return null;
        }
    }
}
