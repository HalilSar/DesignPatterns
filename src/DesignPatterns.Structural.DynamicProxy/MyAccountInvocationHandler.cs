namespace DesignPatterns.Structural.DynamicProxy
{
    public class MyAccountInvocationHandler : InvocationHandler
    {
        private BankAccount account;
        public MyAccountInvocationHandler(BankAccount account)
        {
            this.account = account;
        }

        public BankAccount Invoke()
        {
            return this.account
        }

       
    }
}
