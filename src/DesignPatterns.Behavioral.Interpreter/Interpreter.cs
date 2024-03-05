using System;

namespace DesignPatterns.Behavioral.Interpreter
{
    public class Interpreter
    {


        public void Interpret(string value)
        {
            Expression expression = Parse(value);
            expression.Calculete();
        }

        private Expression Parse(string value)
        {
            if (value.Contains(OpreationIdentifier.MULTIPLICATION))
                return new MultiplicationExperession(value);
            return null;
        }
    }
}
