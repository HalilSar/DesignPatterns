namespace DesignPatterns.Structural.DynamicProxy
{
    public interface IBankAccount
    {
       // Parameter : decimal money
        void WithDrawMoney(decimal money);
        
       // Parameter : decimal money
        void DepositeMoney(decimal money);
        
       // Parameter : string name
        void SetName(string name);
        
        void GetName();
        void GetSurName();

        // Parameter : string name
        void SetSurName(string surName);

        void GetAccountStatus();
 
        // Parameter : decimal money
        void SetAccountStatus(decimal money);
 
        void Cancel();

        // return : bool
        bool CancelStatus();
    }
}
