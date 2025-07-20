namespace DesignPatterns.Structural.DynamicProxy
{
    public interface IBankAccount
    {
        // return : decimal money
        void WithDrawMoney(decimal money);
        
        // return : decimal money
        void DepositeMoney(decimal money);
        
        // return : string name
        void SetName(string name);
        
        void GetName();
        void GetSurName();

        // return : string name
        void SetSurName(string surName);

        void GetAccountStatus();
 
        // return : decimal money
        void SetAccountStatus(decimal money);
 
        void Cancel();
        bool CancelStatus();
    }
}
