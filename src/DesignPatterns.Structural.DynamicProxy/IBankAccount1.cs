namespace DesignPatterns.Structural.DynamicProxy
{
    public interface IBankAccount1
    {
        void Cancel();
        bool CancelStatus();
        void DepositeMoney(decimal money);
        void GetAccountStatus();
        void GetName();
        void GetSurName();
        void SetAccountStatus(decimal money);
        void SetName(string name);
        void SetSurName(string surName);
        void WithDrawMoney(decimal money);
    }
}