namespace DesignPatterns.Structural.DynamicProxy
{
    public class MyAccountInvocationHandler : InvocationHandler
    {
        private IBankAccount account;
        public MyAccountInvocationHandler(IBankAccount account)
        {
            this.account = account;
        }

        public IBankAccount Invoke()
        {
            return this.account;
        }

       
    }
}
