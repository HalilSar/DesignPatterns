using ImpromptuInterface;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using static System.Console;
namespace DesignPatterns.Structural.DynamicProxy
{
    public class Log<T> : DynamicObject where T: class,new()
    {
        private readonly T subject;
        private Dictionary<string, int> methodCallCount = new Dictionary<string, int>();
        public string Info 
        { 
            get
            {
                var stringBuilder = new StringBuilder();
                foreach (var k in methodCallCount)
                    stringBuilder.AppendLine($"{k.Key} called {k.Value} time(s)");
                return stringBuilder.ToString();            
            } 
        }
        public Log(T subject) => this.subject = subject;

        // Return I>class
        public static I As<I>() where I:class
        {
            if (!typeof(I).IsInterface)
            {
                throw new ArgumentException("I must be an interface type!");
            }
            return new Log<T>(new T()).ActLike<I>();
        }

        // Return     : bool
        // Parameters : InvokeMemberBinder binder, object[] args, out object result
        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            try
            {
                WriteLine($"Invoking {subject.GetType().Name}.{binder.Name} with arguments [{string.Join(",",args )}]");
                if (methodCallCount.ContainsKey(binder.Name)) methodCallCount[binder.Name]++;
                else methodCallCount.Add(binder.Name, 1);

                result = subject.GetType().GetMethod(binder.Name).Invoke(subject, args);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }

        // Return: string
        public override string ToString()
        {
            return $"{Info}\n{subject}";
        }
    }
}
